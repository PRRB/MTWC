using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TWCompare
{
    class Main
    {
        const string path
            //= @"C:\Program Files (x86)\Steam\steamapps\common\Total War Medieval 1 Gold\";
            = @"C:\Users\Phil\Documents\MTW\MTW\";
        const string fullpath = path + "CRUSADERS_UNIT_PROD11.TXT";
        const string newpath = path + "CRUSADERS_UNIT_PROD11-2.TXT";

        public string[] Lines;
        public string Text;
        public List<ColInfo> Info = new List<ColInfo>();
        public List<Row> Rows = new List<Row>();
        public Main()
        {
            Text = File.ReadAllText(fullpath);
            Text = Text
                .Replace("\r\n", "###")
                .Replace("\n", "@@@")
                .Replace("###", "\r\n");

            File.WriteAllText(newpath, Text, Encoding.UTF8);
            Lines = File.ReadAllLines(newpath);

            
            LoadStructure();

            var lighthalberdier = GetRows("lighthalberdier", ColType.UnitId).First();
            var lightspearmen = GetRows("lightspearmen", ColType.UnitId).First();
            var lightcavalry = GetRows("lightcavalry", ColType.UnitId);
            var peasantcavalry = GetRows("peasantcavalry", ColType.UnitId);
            var mountedscouts = GetRows("mountedscouts", ColType.UnitId);
        }

        private List<Row> GetRows(string value, ColType filter = ColType.UnitId)
        {
            return Rows.Where(r => r.HasValue(value, filter)).ToList();
        }

        private void LoadStructure()
        {
            LoadColInfo(new Row(0, Lines[0]), new Row(1, Lines[1]), new Row(2, Lines[2]));
            for (var i = 4; i < Lines.Length; i++)
            {
                var str = Lines[i];
                if (str.Length > 0 && char.IsLetter(str[0]))
                {
                    Rows.Add(new Row(i, str, Info));
                    continue;
                }
                break;
            }
        }

        private void LoadColInfo(Row row1, Row row2, Row row3)
        {
            for (var i = 0; i < row1.Cols.Count; i++)
            {
                var colInfo = new ColInfo
                {
                    RowNum = i,
                    Type = (ColType)i,
                    Title = row1.Cols[i].Text,
                    DataType = row2.Cols[i].Text,
                    Description = row3.Cols[i].Text
                };
                Info.Add(colInfo);
            }
        }
    }

    public class Row
    {
        public int RowNum { get; }

        string RawStr { get; }
        public List<Col> Cols { get; }
        private readonly List<ColInfo> ColInfo;
        public Row(int rownum, string str, List<ColInfo> info = null)
        {
            RowNum = rownum;
            RawStr = str;
            Cols = new List<Col>();
            ColInfo = info;
            LoadCols(str);
        }

        private void LoadCols(string str)
        {
            var cols = str.Split('\t');
            for (var i = 0; i < cols.Length; i++)
            {
                Cols.Add(new Col(i, cols[i], ColInfo?[i]));
            }
        }

        public bool HasValue(string value, ColType col)
        {
            return Cols[(int)col]
                .Text.IndexOf(value, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }

    public class Col
    {
        public Col(int colNum, string str, ColInfo info = null)
        {
            ColNum = colNum;
            Text = str;
            Type = (ColType)colNum;
            Info = info;
        }
        public int ColNum { get; }
        public string Text { get; }
        ColType Type { get; }
        ColInfo Info { get; }
    }
}
