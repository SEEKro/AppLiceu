using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClienRamade.Forms;

namespace ClienRamade.Forms
{
    public partial class Admin_login : Form
    {
        ClienRamade.ServiceReference1.WebServiceSoapClient service = new ClienRamade.ServiceReference1.WebServiceSoapClient();
        Thread t;

        public Admin_login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
