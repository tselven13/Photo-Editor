using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class ProDialog : Form
    {
        public ProDialog()
        {
            InitializeComponent();
        }
        private void ProDialog_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ParamPro.path);
            ImageFormat format = img.RawFormat;
            label2.Text = ParamPro.fname;
            label4.Text = format.ToString();


        }
    }
}
