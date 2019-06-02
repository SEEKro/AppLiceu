using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienRamade.Forms
{
    public partial class elev_login : Form
    {

        ClienRamade.ServiceReference1.WebServiceSoapClient service = new ClienRamade.ServiceReference1.WebServiceSoapClient();
        Thread t;

        public elev_login()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(676, 496);
            this.Name = "elev_login";
            this.Load += new System.EventHandler(this.elev_login_Load);
            this.ResumeLayout(false);
        }

        private void openelev(object obj)
        {
            Application.Run(new Forms.elev_form(textBox1.Text));
        }

        private void elev_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == service.getPassword("elev", textBox1.Text).Tables[0].Rows[0][0].ToString())
            {
                t = new Thread(openelev);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!", "Eroare de logare");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
