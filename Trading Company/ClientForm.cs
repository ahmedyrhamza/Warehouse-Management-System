using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class ClientForm : Form
    {
        private Trading_CompanyEntities Context;
        int ClientID;
        public ClientForm(int InertOrUpdate, int ClnID, Trading_CompanyEntities Con)
        {
            InitializeComponent();

            ClientID = ClnID;
            Context = Con;
            var WhNames = Context.Warehouses.Select(wh => wh.Wh_Name);
            foreach (var wh in WhNames)
            {
                WHBox.Items.Add(wh);
            }

            if (InertOrUpdate == 1)
            {
                UpdateBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = false;

                var cln = Context.Clients.Where(c => c.Client_ID == ClientID).Select(c => c).FirstOrDefault();

                if (cln != null)
                {
                    NameBox.Text = cln.Client_Name;
                    PhoneBox.Text = cln.Client_Phone;
                    FaxBox.Text = cln.Client_Fax;
                    EmailBox.Text = cln.Client_Email;
                    MobileBox.Text = cln.Client_Mobile;
                    WSBox.Text = cln.Client_WebSite;
                    WHBox.SelectedIndex = WHBox.FindStringExact(cln.Wh_Name);
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
                    Client cln = new Client();
                    cln.Client_Name = NameBox.Text;
                    cln.Client_Phone = PhoneBox.Text;
                    cln.Wh_Name = WHBox.Text;
                    cln.Client_Fax = FaxBox.Text;
                    cln.Client_Email = EmailBox.Text;
                    cln.Client_Mobile = MobileBox.Text;
                    cln.Client_WebSite = WSBox.Text;
                    Context.Clients.Add(cln);
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
                    var Result = Context.Clients.Where(c => c.Client_ID == ClientID).Select(c => c).FirstOrDefault();
                    if (Result != null)
                    {
                        Result.Client_Name = NameBox.Text;
                        Result.Client_Phone = PhoneBox.Text;
                        Result.Wh_Name = WHBox.Text;
                        Result.Client_Fax = FaxBox.Text;
                        Result.Client_Email = EmailBox.Text;
                        Result.Client_Mobile = MobileBox.Text;
                        Result.Client_WebSite = WSBox.Text;
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
