using System;
using System.Reflection;
using System.Windows.Forms;

namespace MTWC
{
    public static class ExtensionMethods
    {
        public static int? ToInt(this string @this)
        {
            int.TryParse(@this, out var result);
            return result;
        }

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
