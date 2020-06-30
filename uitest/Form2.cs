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


        private Form currentChildForm;

        public Form2() {
            InitializeComponent();
            panel8.Height = 50;
            panel9.Height = 50;
        }

        private void OpenChildForm(Form childForm) {
            //open only form
            if(currentChildForm != null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        Panel panelOpened;
        Panel panelChildOpened;

        private void resetDropdown(Panel panel1, Panel panel2) {
            if(panel1 != null || panel2 != null){
                panel2.BackColor = Color.FromArgb(0, 41, 72);
                panel1.AutoSize = false;
                panel1.Height = 50;
            }
            
        }

        private void chooseDropdown(Panel panel1, Panel panel2) {

            if(panel1.AutoSize == true) {
                resetDropdown(panel1, panel2);
            }
            else {
                if(panelOpened != null){
                    resetDropdown(panelOpened, panelChildOpened);
                }
                panel1.AutoSize = true;
                panel2.BackColor = Color.FromArgb(2, 29, 49);
                panelOpened = panel1;
                panelChildOpened = panel2;
            }

        }

        private void btn1_Click(object sender, EventArgs e) {
            OpenChildForm(new Form3());
            chooseDropdown(panel8, panel12);
            
        }

        private void button10_Click(object sender, EventArgs e) {
            OpenChildForm(new Form4());          
            chooseDropdown(panel9, panel19);
        }

        private void panel5_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //OpenChildForm(new Form3());
        }

        private void button3_Click(object sender, EventArgs e) {
            //OpenChildForm(new Form1());

        }


        private void Form2_Load(object sender, EventArgs e) {

        }

        private void panel2_Click(object sender, EventArgs e) {
            resetDropdown(panelOpened, panelChildOpened);
            if(currentChildForm != null){
                currentChildForm.Close();
            }
        }
    }
}
