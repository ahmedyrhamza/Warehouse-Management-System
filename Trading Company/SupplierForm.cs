using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class SupplierForm : Form
    {
        private Trading_CompanyEntities Context;
        int SuppID;
        public SupplierForm(int InertOrUpdate, int SupplierID, Trading_CompanyEntities Con)
        {
            InitializeComponent();
            SuppID = SupplierID;
            Context = Con;

            if (InertOrUpdate == 1)
            {
                UpdateBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = false;

                var supp = Context.Suppliers.Where(sp => sp.Supplier_ID == SuppID).Select(sp => sp).FirstOrDefault();

                if (supp != null)
                {
                    //CodeBox.Text = item.It_Code.ToString();
                    NameBox.Text = supp.Supplier_Name;
                    PhoneBox.Text = supp.Supplier_Phone;
                    FaxBox.Text = supp.Supplier_Fax;
                    EmailBox.Text = supp.Supplier_Email;
                    MobileBox.Text = supp.Supplier_Mobile;
                    WSBox.Text = supp.Supplier_WebSite;
                }
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || PhoneBox.Text == "" || FaxBox.Text == "" || EmailBox.Text == "" || MobileBox.Text == "" || WSBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    Supplier supp = new Supplier();
                    supp.Supplier_Name = NameBox.Text;
                    supp.Supplier_Phone = PhoneBox.Text;
                    supp.Supplier_Fax = FaxBox.Text;
                    supp.Supplier_Email = EmailBox.Text;
                    supp.Supplier_Mobile = MobileBox.Text;
                    supp.Supplier_WebSite = WSBox.Text;
                    Context.Suppliers.Add(supp);
                    Context.SaveChanges();
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
            if (NameBox.Text == "" || PhoneBox.Text == "" || FaxBox.Text == "" || EmailBox.Text == "" || MobileBox.Text == "" || WSBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    var Result = Context.Suppliers.Where(sp => sp.Supplier_ID == SuppID).Select(sp => sp).FirstOrDefault();
                    if (Result != null)
                    {
                        Result.Supplier_Name = NameBox.Text;
                        Result.Supplier_Phone = PhoneBox.Text;
                        Result.Supplier_Fax = FaxBox.Text;
                        Result.Supplier_Email = EmailBox.Text;
                        Result.Supplier_Mobile = MobileBox.Text;
                        Result.Supplier_WebSite = WSBox.Text;
                        //Context.Entry(Result).State = EntityState.Modified;
                        Context.SaveChanges();
                        MessageBox.Show($"Done!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    MessageBox.Show("Failed!");
                }
            }
        }
    }
}
