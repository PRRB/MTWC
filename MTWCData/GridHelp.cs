using System.Collections.Generic;
using System.Reflection;

namespace MTWC
{
    public static class GridHelp
    {

        public static void RowSort(List<RowInfo> row, PropertyInfo sortProp)
        {
            if (sortProp.PropertyType == typeof(int?))
            {
                row.Sort((x, y) =>
                {
                    var xx = sortProp.GetValue(x) as int?;
                    var yy = sortProp.GetValue(y) as int?;

                    var result = xx == null
                        ? yy == null ? 0 : 1
                        : yy == null ? -1 : (int)yy - (int)xx;
                    return result;
                });
            }
            else
            {
                row.Sort((x, y) =>
                {
                    var xx = sortProp.GetValue(x).ToString();
                    var yy = sortProp.GetValue(y).ToString();

                    var result = string.IsNullOrWhiteSpace(xx)
                        ? string.IsNullOrWhiteSpace(yy) ? 0 : 1
                        : string.IsNullOrWhiteSpace(yy) ? -1 : xx.CompareTo(yy);
                    return result;
                });
            }
        }
    }
}