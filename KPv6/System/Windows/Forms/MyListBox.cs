using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    internal class MyListBox : ListBox
    {
        [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt(
               [In()] System.IntPtr hdc, int x, int y, int cx, int cy,
               [In()] System.IntPtr hdcSrc, int x1, int y1, uint rop);

        public MyListBox() : base() { }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            Rectangle newBounds = new Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height);
            using (BufferedGraphics bufferedGraphics = currentContext.Allocate(e.Graphics, newBounds))
            {
                DrawItemEventArgs newArgs = new DrawItemEventArgs(bufferedGraphics.Graphics, e.Font, newBounds, e.Index, e.State, e.ForeColor, e.BackColor);
                base.OnDrawItem(newArgs);
                BitBlt(e.Graphics.GetHdc(), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height, bufferedGraphics.Graphics.GetHdc(), 0, 0, 0x00CC0020U);
            }
        }
    }
}