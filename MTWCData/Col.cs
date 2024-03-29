﻿namespace MTWC
{
    public class Col
    {
        public Col(int colNum, string str, ColInfo info = null)
        {
            ColNum = colNum;

            str = str.Trim();
            if (str.Length > 2 && str.StartsWith("\"") && str.EndsWith("\""))
            {
                str = str.Substring(1, str.Length - 2);
            }

            Text = str;
            Type = (ColType)colNum;
            Info = info;
        }
        public int ColNum { get; }
        public string Text { get; }
        public ColType Type { get; }
        public ColInfo Info { get; }
    }
}
