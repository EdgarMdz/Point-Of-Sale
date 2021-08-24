using System.Windows.Forms;
using System.ComponentModel;
using System;

namespace POS
{
    public static class dispose
    {
        public static void DisposeControls(Control parent)
        {
            try
            {
                foreach (Control child in parent.Controls)
                {
                    if (child.Controls.Count > 0)
                        DisposeControls(child);
                    else if (!child.Disposing && !child.IsDisposed)
                        child.Dispose();
                }
                parent.Dispose();
            }
            catch(Exception) { }
        }

        public  static void disposeArray(Control[] controls)
        {
            foreach (Control control1 in controls)
            {
                DisposeControls(control1);
            }
        }
        public static void disposeArray(Component[] components)
        {
            foreach (Component component in components)
            {
                component.Dispose();
            }
        }

    }
}
