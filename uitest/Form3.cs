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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void hoverPanelEffect(Panel panel) {
            panel.Top = 100;
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

        private void panel3_MouseHover(object sender, EventArgs e) {
            hoverPanelEffect(panel3);
        }

        private void panel3_MouseLeave(object sender, EventArgs e) {
            panel3.Location = new Point(561, 110);
        }

        private void panel4_MouseHover(object sender, EventArgs e) {
            hoverPanelEffect(panel4);
        }

        private void panel4_MouseLeave(object sender, EventArgs e) {
            panel4.Location = new Point(814, 110);
        }



    }
}
