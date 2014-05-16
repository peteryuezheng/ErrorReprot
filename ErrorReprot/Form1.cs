using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorReprot
{
    public partial class Form1 : Form
    {
        ScreenCapture Sc;
        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            Sc = ScreenCapture.Instance;
            frm2.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GetScreenShot();
        }

        private void GetScreenShot()
        {
            Sc.Capture(frm2);                
        }





    }
}
