using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenShot;
using System.Drawing.Imaging;
using System.Diagnostics;
namespace CSharpScreenCapture
{
    public partial class Form1 : Form
    {
        string link;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            ScreenShot.ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // display image in a Picture control named imageDisplay
            this.imgdisp.Image = img;
            // capture this window, and save it
            string d= DateTime.Now.ToString();
            d = d.Replace(':', '-');
            string name = @"D:\"+d+".png";
            link = name;
            lblsaved.Text = link;
            sc.CaptureScreenToFile( name , ImageFormat.Png);

        }

        private void imgdisp_Click(object sender, EventArgs e)
        {
            Process.Start(link);
        }

        private void lblsaved_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(lblsaved.Text);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
