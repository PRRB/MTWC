namespace TWCompare
{
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
