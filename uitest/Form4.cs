using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uitest {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void hoverPanelEffect(Panel panel) {
            panel.Top = 100;
        }

        private void Form4_Load(object sender, EventArgs e) {

        }

        private void panel1_MouseHover(object sender, EventArgs e) {
            hoverPanelEffect(panel1);
        }

        private void panel1_MouseLeave(object sender, EventArgs e) {
            panel1.Location = new Point(55, 110);
        }

        private void panel2_MouseHover(object sender, EventArgs e) {
            hoverPanelEffect(panel2);
        }

        private void panel2_MouseLeave(object sender, EventArgs e) {
            panel2.Location = new Point(308, 110);
        }

    }
}
