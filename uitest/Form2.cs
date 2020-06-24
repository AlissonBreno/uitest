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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            panel8.Height = 50;
            panel9.Height = 50;
            panel11.Visible = false; 
        }

        private void btn1_Click(object sender, EventArgs e) {
            if(panel8.AutoSize == true) {
                panel12.BackColor = Color.FromArgb(0, 41, 72);
                panel8.AutoSize = false;
                panel8.Height = 50;
            }
            else {
                panel8.AutoSize = true;
                panel12.BackColor = Color.FromArgb(2, 29, 49);
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            if(panel9.AutoSize == true) {
                panel19.BackColor = Color.FromArgb(0, 41, 72);
                panel9.AutoSize = false;
                panel9.Height = 50;
            }
            else {
                panel9.AutoSize = true;
                panel19.BackColor = Color.FromArgb(2, 29, 49);
            }
        }

        private void panel5_Click(object sender, EventArgs e) {
            if(panel11.Visible == false) {
                panel11.Visible = true;
            }
            else {
                panel11.Visible = false;
            }
        }



    }
}
