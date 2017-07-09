using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSControlLibrary
{
   public  class InputMultiport : Port
    {
        public InputMultiport()
        {
            base.InitializeComponent();
            this.pictureBox.DoubleClick += new System.EventHandler(this.inputmultiport_DoubleClick);
            this.pictureBox.Image = CPSControlLibrary.Properties.Resources.InputMultiport;
            this.Name = "InputMultiport";
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void inputmultiport_DoubleClick(object sender, EventArgs e)
        {
            PictureBox inmul = (PictureBox)sender;
            EditParameters edit = new EditParameters(this);
            edit.label_width.Visible = true;
            edit.textBox_width.Visible = true;
            edit.Name = "EditParameters for port" + this.Index;
            edit.Text = edit.Name;
            edit.Show();
        }
    }

}
