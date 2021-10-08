using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lbFirst.Text = Resource1.firstName;
            lbLast.Text = Resource1.lastName;
            btnAdd.Text = Resource1.Add;

            lbDefault.DataSource = users;
            lbDefault.ValueMember = "ID";
            lbDefault.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                lastName = lbLast.Text,
            firstName = lbFirst.Text
            };
            users.Add(u);
        }
    }
}
