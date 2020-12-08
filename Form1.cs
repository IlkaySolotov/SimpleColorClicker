using Pranas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            goahead();
        }
        async Task goahead()
        {
            var proc = Process.GetProcessesByName(siticoneMaterialTextBox1.Text)[0];
            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);
            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            var cast = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(cast);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    Color pixelColor = cast.GetPixel(w, h);
                    if (pixelColor.R == screenColorPicker1.Color.R && pixelColor.G == screenColorPicker1.Color.G && pixelColor.B == screenColorPicker1.Color.B)
                    {
                        InputSimulator a = new InputSimulator();
                        Point leftTop = new Point(w + rect.left, h + rect.top);
                        Cursor.Position = leftTop;
                        a.Mouse.LeftButtonClick();
                        graphics.Flush();
                        graphics.Dispose();
                        cast.Dispose();
                        break;
                    }
                }
            }
        }
    }

    class User32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
    }
}
