using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbFirst.Text = Resource1.firstName;
            lbLast.Text = Resource1.lastName;
            btnAdd.Text = Resource1.Add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
