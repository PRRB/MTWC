using System;
using System.Collections.Generic;

namespace TWCompare
{
    public class Row
    {
        public int RowNum { get; }

        public string RawStr { get; }
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

        public string GetValue(string colName)
        {
            var type = TypeForCol(colName);
            return Cols.Find(c => c.Type == type).Text;
        }

        private ColType TypeForCol(string colName)
        {
            return (ColType)Enum.Parse(typeof(ColType),colName);
        }
    }
}
