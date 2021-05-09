namespace MTWC
{
    public static class ExtensionMethods
    {
        public static int? ToInt(this string @this)
        {
            int.TryParse(@this, out var result);
            return result;
        }
    }
}
