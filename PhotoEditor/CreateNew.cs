using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PhotoEditor
{
    public partial class CreateNew : KryptonForm
    {
        public CreateNew()
        {
            InitializeComponent();
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cnsl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nxt_Click(object sender, EventArgs e)
        {
            ParamPro.abWidth = Convert.ToInt32(textBox1.Text);
            ParamPro.abHeight = Convert.ToInt32(textBox2.Text);
            ParamPro.Res = Convert.ToInt32(textBox3.Text);
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
