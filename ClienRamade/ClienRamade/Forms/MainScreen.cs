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

namespace ClienRamade
{
    public partial class Form1 : Form
    {

        private Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void openadmin(object obj)
        {
            //Application.Run(new admin_log());
        }
        private void openprofesor(object obj)
        {
            Application.Run(new Forms.profesor_login());
        }
        private void openelev(object obj)
        {
            Application.Run(new Forms.elev_login());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dsadsada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openadmin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openprofesor);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openelev);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
