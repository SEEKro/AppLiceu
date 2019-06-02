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
    public partial class profesor_login : Form
    {

        ClienRamade.ServiceReference1.WebServiceSoapClient service = new ClienRamade.ServiceReference1.WebServiceSoapClient();
        Thread t;

        public profesor_login()
        {
            InitializeComponent();
        }

        private void openmenu(object obj)
        {
            //Application.Run(new MainScreen());
        }

        private void openprofesor(object obj)
        {
            Application.Run(new Forms.profesor_form(textBox1.Text));
        }

        private void profesor_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == service.getPassword("profesor", textBox1.Text).Tables[0].Rows[0][0].ToString())
            {
                this.Close();
                t = new Thread(openprofesor);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!", "Eroare de logare");
            }
        }
    }
}
