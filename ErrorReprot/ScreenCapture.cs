using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorReprot
{

    public sealed class ScreenCapture
    {
        private static volatile ScreenCapture instance;
        private static object syncRoot = new Object();

        private ScreenCapture() { }

        public static ScreenCapture Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ScreenCapture();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Capture the screen of objet
        /// </summary>
        public void Capture(Form frm)
        {
            Rectangle bounds = frm.Bounds;
            Capture(bounds);
        }

        public void Capture(Rectangle bounds)
        {

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save("test.jpg", ImageFormat.Jpeg);
            }
        }


    }
}
