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
    public partial class Search_Data : Form
    {
        public Search_Data()
        {
            InitializeComponent();
        }

        private void search_button1_Click(object sender, EventArgs e)
        {
            if (this.search_button1.Text == "")
            {
                MessageBox.Show("You must enter the ID !");
                return;
            }
            //------------------------------
            string fn;
            fn = "C:\\Users\\ewoln\\OneDrive\\Desktop\\tuts\\";
            string p;
            string r;
            //------ first name ------------
            p = fn + this.textBox1.Text + "_fn.txt";
            if (System.IO.File.Exists(p) == true )
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_textBox2.Text = r;
            }
            //------ las name ------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_textBox3.Text = r;
            }
            //---------- tel -------------
            p = fn + this.textBox1.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_textBox4.Text = r;
            }
            //--------- cell -------------
            p = fn + this.textBox1.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_textBox5.Text = r;
            }
            //--------- mail -------------
            p = fn + this.textBox1.Text + "_mail.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.mail_textBox6.Text = r;
            }
            //-------- Address ------------
            p = fn + this.textBox1.Text + "_address.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.adress_textBox7.Text = r;
            }
            //--------- Comment -----------
            p = fn + this.textBox1.Text + "_comm.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.com_textBox8.Text = r;
            }
            // ----------- ID -------------
            this.id_textBox1.Text = this.textBox1.Text;



        }
    }
}
