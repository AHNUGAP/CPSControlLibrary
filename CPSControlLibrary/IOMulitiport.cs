using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSControlLibrary
{
    class IOMultiport : Port
    {
        public IOMultiport()
        {
            base.InitializeComponent();
            this.pictureBox.DoubleClick += new System.EventHandler(this.IOmultiport_DoubleClick);
            this.pictureBox.Image = CPSControlLibrary.Properties.Resources.OutputMultiport;
            this.Name = "IOMultiport";
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void IOmultiport_DoubleClick(object sender, EventArgs e)
        {
            EditParameters edit = new EditParameters();
            edit.label_width.Visible = true;
            edit.textBox_width.Visible = true;
            edit.Show();
        }
    }
}
