﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MTWC
{
    public class MTWCData
    {
        const string path =
            //@"C:\MTW\MTW";
            //@"D:\SteamLibrary\steamapps\common\Total War Medieval 1 Gold";
            @"..\..\..\..\GameFiles\Original";
        const string fullpath = path + @"\CRUSADERS_UNIT_PROD11.TXT";
        const string newpath = path + @"\CRUSADERS_UNIT_PROD11-2.TXT";

        public string[] Lines { get; set; }
        public string Text { get; set; }
        public List<ColInfo> ColInfo { get; set; } = new List<ColInfo>();
        public List<Row> Rows { get; set; } = new List<Row>();
        public List<RowInfo> RowInfo { get; set; } = new List<RowInfo>();

        public MTWCData()
        {
            try
            {
                Init();
            }
            catch
            {
                Console.WriteLine("well sheeee...");
            }
        }

        void Init()
        {
            Text = File.ReadAllText(fullpath);
            Text = Text
                .Replace("\r\n", "###")
                .Replace("\n", "@@@")
                .Replace("###", "\r\n");

            File.WriteAllText(newpath, Text, Encoding.UTF8);

            Lines = File.ReadAllLines(newpath);
            ColInfo = LoadColInfo(Lines);
            Rows = LoadStructure();

            var props = typeof(RowInfo).GetProperties();
            foreach (var row in Rows)
            {
                var rowInfo = new RowInfo
                {
                    RowNum = row.RowNum
                };
                foreach (var col in row.Cols)
                {
                    var colName = col.Type.ToString();
                    var prop = props.First(p
                        => p.Name.Equals(colName, StringComparison.OrdinalIgnoreCase));

                    if (prop.PropertyType == typeof(int?))
                        prop.SetValue(rowInfo, col.Text.ToInt());
                    else
                        prop.SetValue(rowInfo, col.Text);
                }
                RowInfo.Add(rowInfo);
            }

            //var lighthalberdier = GetRows("lighthalberdier", ColType.UnitId).First();
            //var lightspearmen = GetRows("lightspearmen", ColType.UnitId).First();
        }

        private List<ColInfo> LoadColInfo(string[] lines)
        {
            var row1 = new Row(0, lines[0]);
            var row2 = new Row(1, lines[1]);
            var row3 = new Row(2, lines[2]);
            var info = new List<ColInfo>();
            var i = 0;
            while (i < row1.Cols.Count)
            {
                var colInfo = new ColInfo
                {
                    RowNum = i,
                    Type = (ColType)i,
                    Title = row1.Cols[i].Text,
                    DataType = row2.Cols[i].Text,
                    Description = row3.Cols[i].Text
                };
                info.Add(colInfo);
                i++;
            }
            var count = Enum.GetValues(typeof(ColType)).Length;
            while (i < count)
            {
                var colInfo = new ColInfo
                {
                    RowNum = i,
                    Type = (ColType)i,
                    Title = ((ColType)i).ToString(),
                    DataType = null,
                    Description = ((ColType)i).ToString()
                };
                info.Add(colInfo);
                i++;
            }
            return info;
        }

        private List<Row> LoadStructure()
        {
            var rows = new List<Row>();
            for (var i = 4; i < Lines.Length; i++)
            {
                var str = Lines[i];
                if (str.Length > 0 && char.IsLetter(str[0]))
                {
                    rows.Add(new Row(i, str, ColInfo));
                    continue;
                }
                break;
            }
            return rows;
        }

        public List<RowInfo> ShownRows()
            => RowInfo.Where(r => r._isActive).ToList();

        public void SetShownRows(IList selected)
        {
            var showAll = selected.Count == 0;
            foreach (RowInfo row in RowInfo)
            {
                row._isActive = showAll;
            }
            foreach (RowInfo row in selected)
            {
                row._isActive = true;
            }
        }

        public List<RowInfo> FilterRows(string filter)
        {
            var search = filter.Trim() ?? "";
            if (search == "") return RowInfo;
            var regex = new Regex(search, RegexOptions.IgnoreCase);
            return RowInfo.FindAll(r => regex.IsMatch(r.UnitId));
        }

        public List<RowInfo> DefaultRows
            => FilterRows(Def.RowSelect);

        public List<ColInfo> DefaultCols()
        {
            return ColInfo.Where(c => Def.ColSelect.Any(d => d == c.Type)).ToList();
        }

    }
}