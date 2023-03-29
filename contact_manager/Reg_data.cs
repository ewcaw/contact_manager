using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_manager
{
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // SAVE BUTTON
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(this.id_textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID !");
                return;
            }
            //------------------------------
            this.Save_button.Enabled = false;
            this.new_button.Enabled = true;
            //------------------------------
            this.info_gbox.Enabled = false;
            //------------------------------
            string fn;
            fn = "C:\\Users\\ewoln\\OneDrive\\Desktop\\tuts\\";
            string p;
            //------ first name ------------
            p = fn + this.id_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox2.Text, Encoding.UTF8);
            //------ last name -------------
            p = fn + this.id_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox3.Text, Encoding.UTF8);
            //------ tel -------------
            p = fn + this.id_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_textBox4.Text, Encoding.UTF8);
            //------ cell -------------
            p = fn + this.id_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cell_textBox5.Text, Encoding.UTF8);
            //------ email -------------
            p = fn + this.id_textBox1.Text + "_mail.txt";
            System.IO.File.WriteAllText(p, this.mail_textBox6.Text, Encoding.UTF8);
            //------ address -------------
            p = fn + this.id_textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.adress_textBox7.Text, Encoding.UTF8);
            //------ comment -------------
            p = fn + this.id_textBox1.Text + "_comm.txt";
            System.IO.File.WriteAllText(p, this.com_textBox8.Text, Encoding.UTF8);
            //------------------------------
            MessageBox.Show("Saved");

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            this.new_button.Enabled = false;
            this.Save_button.Enabled = true;
            //------------------------------
            this.info_gbox.Enabled = true;
            //---------Clear Texboxes-------
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText();
            this.ln_textBox3.ResetText();
            this.tel_textBox4.ResetText();
            this.cell_textBox5.ResetText();
            this.mail_textBox6.ResetText();
            this.adress_textBox7.ResetText();
            this.com_textBox8.ResetText();
            //------------------------------
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.info_gbox.Enabled = false;
        }
    }
}
