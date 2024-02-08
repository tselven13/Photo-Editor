using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class LayersPanel : UserControl
    {
        public LayersPanel()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        private void LayersPanel_Load(object sender, EventArgs e)
        {
            LName.Text = ParamPro.LName;

        }
        int locked = 0;
        int vis = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {//For the show hide layer icon change.
            if (vis == 1)
            {
                pictureBox1.Image = global::PhotoEditor.Properties.Resources.hide_2767146;
                vis = 0;
                //((PictureBox)f1.artBoard.Controls.Find(this.Name, true)[0]).Visible = false;

            }
            else
            {
                pictureBox1.Image = global::PhotoEditor.Properties.Resources.visible_5340135;
                vis = 1;
                //((PictureBox)f1.Controls.Find(this.Name, true)[0]).Visible = false;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (locked == 0)
            {
                locked = 1;
                pictureBox3.Image = global::PhotoEditor.Properties.Resources.padlock_3064155;
            }
            else
            {
                locked = 0;
                pictureBox3.Image = global::PhotoEditor.Properties.Resources.unlock_8287029;
            }
        }

        private void LayersPanel_Click(object sender, EventArgs e)
        {
        }

        private void LName_Click(object sender, EventArgs e)
        {
        }
    }
}
