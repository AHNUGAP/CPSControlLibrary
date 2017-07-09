using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSControlLibrary
{
    class InputMultiport : Port
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
            EditParameters edit = new EditParameters();
            edit.label_width.Visible = true;
            edit.textBox_width.Visible = true;
            edit.Show();
        }
    }

}
