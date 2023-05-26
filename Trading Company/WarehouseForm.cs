using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class WarehouseEditForm : Form
    {
        private Trading_CompanyEntities Context;
        private string Old_Name;
        public WarehouseEditForm(int InertOrUpdate, string NameOfWarehouse)
        {
            InitializeComponent();
            Context = new Trading_CompanyEntities();

            Old_Name = NameOfWarehouse;
            if (InertOrUpdate == 1)
            {
                UpdateBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = false;
                var Wareh = Context.SelectWarehouseByName(Old_Name).FirstOrDefault();
                if (Wareh != null)
                {
                    NameBox.Text = Wareh.Wh_Name;
                    AddressBox.Text = Wareh.Wh_Address;
                    ManagerBox.Text = Wareh.Wh_Manager;
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || AddressBox.Text == "" || ManagerBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    var Result = Context.InsertNewWH(NameBox.Text, AddressBox.Text, ManagerBox.Text);
                    MessageBox.Show($"Done!");
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || AddressBox.Text == "" || ManagerBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    var Result = Context.UpdateWH(Old_Name, NameBox.Text, AddressBox.Text, ManagerBox.Text);
                    this.Close();
                    MessageBox.Show($"Done!");
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Failed!");
                }
            }
        }


    }
}

