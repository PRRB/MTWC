namespace TWCompare
{
    public class Col
    {
        public Col(int colNum, string str, ColInfo info = null)
        {
            ColNum = colNum;

            str = str.Trim();
            if (str.StartsWith("\"") && str.EndsWith("\"") && !str[1..^2].Contains("\""))
            {
                str = str[1..^2];
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
