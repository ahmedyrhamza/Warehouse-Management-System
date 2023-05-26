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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trading_Company
{
    public partial class CompanyForm : Form
    {
        private Trading_CompanyEntities Context;
        private ListViewItem row;
        WarehouseEditForm edit;
        ItemForm It_Edit;
        SupplierForm Supp_Edit;
        ClientForm Client_Edit;

        public CompanyForm()
        {
            InitializeComponent();

            Context = new Trading_CompanyEntities();

            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker2.CustomFormat = "MM/yyyy";
            SDate.CustomFormat = "MM/yyyy";
            SExDate.CustomFormat = "MM/yyyy";
            SProDate.CustomFormat = "MM/yyyy";

            SNUpdateBtn.Enabled = false;

        }

        /***************************************************************************************/
        // Warehouse
        /***************************************************************************************/
        private void WarehouseTab_Enter(object sender, EventArgs e)
        {
            WarehousesListView.Items.Clear();
            try
            {
                var Wharehouses = Context.SelectAllWarehouses();
                foreach (var Wh in Wharehouses)
                {
                    row = new ListViewItem();
                    row.Text = Wh.Wh_Name;
                    row.SubItems.Add(Wh.Wh_Address);
                    row.SubItems.Add(Wh.Wh_Manager);

                    WarehousesListView.Items.Add(row);
                }
            }
            catch
            {
                WarehousesListView.Items.Add("No Warehouse Found!");
            }
        }

        private void InsertWhBtn_Click(object sender, EventArgs e)
        {
            edit = new WarehouseEditForm(1, "");
            var dg = edit.ShowDialog(this);

            if (dg == DialogResult.OK)
            {
                Wh_Refresh();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (WarehousesListView.SelectedItems.Count > 0)
            {
                string Name = WarehousesListView.SelectedItems[0].SubItems[0].Text;
                edit = new WarehouseEditForm(2, Name);
                var dg = edit.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                    Wh_Refresh();
                }

            }
            else
            {
                MessageBox.Show("Please select Warehouse!");
            }

        }

        private void Wh_Refresh()
        {
            WarehousesListView.Items.Clear();
            try
            {
                var Wharehouses = Context.SelectAllWarehouses();
                foreach (var Wh in Wharehouses)
                {
                    row = new ListViewItem();
                    row.Text = Wh.Wh_Name;
                    row.SubItems.Add(Wh.Wh_Address);
                    row.SubItems.Add(Wh.Wh_Manager);

                    WarehousesListView.Items.Add(row);
                }
            }
            catch
            {
                WarehousesListView.Items.Add("No Warehouse found!");
            }
        }
        /***************************************************************************************/
        // Items
        /***************************************************************************************/
        private void ItemTab_Enter(object sender, EventArgs e)
        {
            ItemListView.Items.Clear();
            WhBox.Items.Clear();
            WhBox.Items.Add("All Items");
            WhBox.SelectedIndex = 0;
            // ComboBox-----------
            var WhNames = Context.Warehouses.Select(wh => wh.Wh_Name);
            foreach (var wh in WhNames)
            {
                WhBox.Items.Add(wh);
            }
        }

        private void WhBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            It_Refresh();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            It_Edit = new ItemForm(1,-1, Context);
            var dg = It_Edit.ShowDialog(this);

            if (dg == DialogResult.OK)
            {
                It_Refresh();
            }
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            if (ItemListView.SelectedItems.Count > 0)
            {
                int Code = int.Parse(ItemListView.SelectedItems[0].SubItems[0].Text);
                It_Edit = new ItemForm(2, Code, Context);
                var dg = It_Edit.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                    It_Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }
        }

        private void It_Refresh()
        {
            ItemListView.Items.Clear();
            string whName = WhBox.Text;
            if (whName == "All Items")
            {
                var Items = Context.Items.Select(item => item);
                foreach (var Item in Items)
                {
                    row = new ListViewItem();
                    row.Text = Item.It_Code.ToString();
                    row.SubItems.Add(Item.It_Name);
                    row.SubItems.Add(Item.Wh_Name);
                    row.SubItems.Add(Item.Amount.ToString());
                    //foreach (var it in Item.Item_Unit)
                    //{
                    row.SubItems.Add(Item.Item_Unit.FirstOrDefault().It_Unit);
                    //}

                    ItemListView.Items.Add(row);
                }
            }
            else
            {
                var WhItems = from Items in Context.Items
                              where Items.Wh_Name == whName
                              select Items;
                foreach (var Item in WhItems)
                {
                    row = new ListViewItem();
                    row.Text = Item.It_Code.ToString();
                    row.SubItems.Add(Item.It_Name);
                    row.SubItems.Add(Item.Wh_Name);
                    row.SubItems.Add(Item.Amount.ToString());
                    foreach (var it in Item.Item_Unit)
                    {
                        row.SubItems.Add(it.It_Unit);
                    }


                    ItemListView.Items.Add(row);
                }
            }
        }

        /***************************************************************************************/
        // Supplier
        /***************************************************************************************/
        private void SupplierTab_Enter(object sender, EventArgs e)
        {
            SupplierListView.Items.Clear();
            try
            {
                var Suppliers = Context.Suppliers.Select(s => s);
                foreach (var supp in Suppliers)
                {
                    row = new ListViewItem();
                    row.Text = supp.Supplier_ID.ToString();
                    row.SubItems.Add(supp.Supplier_Name);
                    row.SubItems.Add(supp.Supplier_Phone);
                    row.SubItems.Add(supp.Supplier_Fax);
                    row.SubItems.Add(supp.Supplier_Email);
                    row.SubItems.Add(supp.Supplier_Mobile);
                    row.SubItems.Add(supp.Supplier_WebSite);

                    SupplierListView.Items.Add(row);
                }
            }
            catch
            {
                SupplierListView.Items.Add("No Supplier Found!");
            }

        }


        private void SuppAddBtn_Click(object sender, EventArgs e)
        {
            Supp_Edit = new SupplierForm(1, -1, Context);
            var dg = Supp_Edit.ShowDialog(this);

            if (dg == DialogResult.OK)
            {
                //Context.SaveChangesAsync();
                Supp_Refresh();
            }
        }

        private void SuppUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SupplierListView.SelectedItems.Count > 0)
            {
                int ID = int.Parse(SupplierListView.SelectedItems[0].SubItems[0].Text);
                Supp_Edit = new SupplierForm(2, ID, Context);
                var dg = Supp_Edit.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                    Supp_Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }
        }

        private void Supp_Refresh()
        {
            SupplierListView.Items.Clear();
            try 
            {
                var Suppliers = Context.Suppliers.Select(supp => supp);
                foreach (var Supp in Suppliers)
                {
                    row = new ListViewItem();
                    row.Text = Supp.Supplier_ID.ToString();
                    row.SubItems.Add(Supp.Supplier_Name);
                    row.SubItems.Add(Supp.Supplier_Phone);
                    row.SubItems.Add(Supp.Supplier_Fax);
                    row.SubItems.Add(Supp.Supplier_Email);
                    row.SubItems.Add(Supp.Supplier_Mobile);
                    row.SubItems.Add(Supp.Supplier_WebSite);

                    SupplierListView.Items.Add(row);
                }
            }
            catch
            {
                WarehousesListView.Items.Add("No Suppliers found!");
            }
        }
        /***************************************************************************************/
        // Client
        /***************************************************************************************/
        private void ClientTab_Enter(object sender, EventArgs e)
        {
            ClientListView.Items.Clear();
            try
            {
                var Clients = Context.Clients.Select(c => c);
                foreach (var c in Clients)
                {
                    row = new ListViewItem();
                    row.Text = c.Client_ID.ToString();
                    row.SubItems.Add(c.Client_Name);
                    row.SubItems.Add(c.Wh_Name);
                    row.SubItems.Add(c.Client_Phone);
                    row.SubItems.Add(c.Client_Fax);
                    row.SubItems.Add(c.Client_Email);
                    row.SubItems.Add(c.Client_Mobile);
                    row.SubItems.Add(c.Client_WebSite);

                    ClientListView.Items.Add(row);
                }
            }
            catch
            {
                ClientListView.Items.Add("No Client Found!");
            }
        }

        private void ClientAddBtn_Click(object sender, EventArgs e)
        {
            Client_Edit = new ClientForm(1, -1, Context);
            var dg = Client_Edit.ShowDialog(this);

            if (dg == DialogResult.OK)
            {
                //Context.SaveChangesAsync();
                Client_Refresh();
            }
        }

        private void ClientUpdateBtn_Click(object sender, EventArgs e)
        {
            if (ClientListView.SelectedItems.Count > 0)
            {
                int ID = int.Parse(ClientListView.SelectedItems[0].SubItems[0].Text);
                Client_Edit = new ClientForm(2, ID, Context);
                var dg = Client_Edit.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                    Client_Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }
        }

        private void Client_Refresh()
        {
            ClientListView.Items.Clear();
            try
            {
                var Clients = Context.Clients.Select(c => c);
                foreach (var c in Clients)
                {
                    row = new ListViewItem();
                    row.Text = c.Client_ID.ToString();
                    row.SubItems.Add(c.Client_Name);
                    row.SubItems.Add(c.Wh_Name);
                    row.SubItems.Add(c.Client_Phone);
                    row.SubItems.Add(c.Client_Fax);
                    row.SubItems.Add(c.Client_Email);
                    row.SubItems.Add(c.Client_Mobile);
                    row.SubItems.Add(c.Client_WebSite);

                    ClientListView.Items.Add(row);
                }
            }
            catch
            {
                ClientListView.Items.Add("No Client Found!");
            }
        }

        /***************************************************************************************/
        // Supply Notice
        /***************************************************************************************/
        private void SDisplayBtn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(SNIDBox.Text);
            if (SNIDBox.Text == "")
                MessageBox.Show("Please Enter Valid ID!", "Warning");
            else
            {
                var SN = Context.Supply_Notice.Where(sn => sn.SN_ID == ID).FirstOrDefault();
                if (SN == null)
                    MessageBox.Show("Please Enter Valid ID!", "Warning");
                else
                {
                    SNUpdateBtn.Enabled = true;
                    DateTime ex = (DateTime)SN.Supply_Notice_Item.FirstOrDefault().Expiry_Date;
                    DateTime pr = (DateTime)SN.Supply_Notice_Item.FirstOrDefault().Production_Date;
                    SDate.Value = SN.SN_Date;
                    SWHBox.Text = SN.Wh_Name;
                    //SN.Supplier_ID = (from supp in Context.Suppliers
                    //                 where supp.Supplier_Name == SSupplierBox.Text
                    //                 select supp.Supplier_ID).FirstOrDefault();
                    SSupplierBox.Text = SN.Supplier.Supplier_Name;
                    SItemBox.Text = SN.Supply_Notice_Item.FirstOrDefault().Item.It_Name;
                    SAmountBox.Text = SN.Supply_Notice_Item.FirstOrDefault().Amount.ToString();
                    SExDate.Value = ex;
                    SProDate.Value = pr;
                }
            }
        }

        private void SupplyNoticeTab_Enter(object sender, EventArgs e)
        {
            SWHBox.Items.Clear();
            SSupplierBox.Items.Clear();
            var WhNames = Context.Warehouses.Select(wh => wh.Wh_Name);
            foreach (var wh in WhNames)
            {
                SWHBox.Items.Add(wh);
            }
            var Suppliers = Context.Suppliers.Select(s => s.Supplier_Name);
            foreach (var s in Suppliers)
            {
                SSupplierBox.Items.Add(s);
            }

        }
        private void SNAddBtn_Click(object sender, EventArgs e)
        {
            if (SSupplierBox.Text == "" || SWHBox.Text == "" || SItemBox.Text == "" || SAmountBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                var wh = Context.Warehouses.Find(SWHBox.Text);
                var it = Context.Items.Where(i => i.It_Name == SItemBox.Text).Select(i => i).FirstOrDefault();
                var supp = Context.Suppliers.FirstOrDefault(sup => sup.Supplier_Name == SSupplierBox.Text);

                if (wh != null  && supp != null)
                {
                    try {
                        Supply_Notice ssp = new Supply_Notice();
                        var sni = new Supply_Notice_Item();
                        ssp.Wh_Name = SWHBox.Text;
                        ssp.Supplier.Supplier_Name = SSupplierBox.Text;
                        sni.It_Code = it.It_Code;
                        sni.Expiry_Date = SExDate.Value;
                        sni.Production_Date = SProDate.Value;
                        sni.Amount = int.Parse(SAmountBox.Text);
                        ssp.Supply_Notice_Item.Add(sni);
                        Context.Supply_Notice.Add(ssp);

                        var item = Context.Items.Where(i => i.It_Code == ssp.Supply_Notice_Item.FirstOrDefault().It_Code && it.Wh_Name == ssp.Wh_Name).FirstOrDefault();

                        if (item == null)
                        {
                            item = new Item();
                            item.It_Name = SItemBox.Text;
                            item.Amount = int.Parse(SAmountBox.Text);
                            item.Wh_Name = SWHBox.Text;
                            Context.Items.Add(item);
                        }
                        else
                        {
                            item.Amount += int.Parse(SAmountBox.Text);
                        }
                        Context.SaveChanges();
                        MessageBox.Show("Done!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
        }

        private void SNUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SSupplierBox.Text == "" || SWHBox.Text == "" || SItemBox.Text == "" || SAmountBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                var wh = Context.Warehouses.Find(SWHBox.Text);
                var it = Context.Items.Where(i => i.It_Name == SItemBox.Text).Select(i => i).FirstOrDefault();
                var supp = Context.Suppliers.FirstOrDefault(sup => sup.Supplier_Name == SSupplierBox.Text);

                if (wh != null && supp != null)
                {
                    var ssp = Context.Supply_Notice.Where(s => s.Wh_Name == wh.Wh_Name && s.Supplier_ID == supp.Supplier_ID).Select(s => s).FirstOrDefault();
                    if (ssp != null)
                    {

                        ssp.Wh_Name = SWHBox.Text;
                        ssp.Supplier.Supplier_Name = SSupplierBox.Text;
                        ssp.Supply_Notice_Item.FirstOrDefault().It_Code = it.It_Code;
                        ssp.Supply_Notice_Item.FirstOrDefault().Expiry_Date = SExDate.Value;
                        ssp.Supply_Notice_Item.FirstOrDefault().Production_Date = SProDate.Value;
                        ssp.Supply_Notice_Item.FirstOrDefault().Amount = int.Parse(SAmountBox.Text);

                        Context.SaveChanges();
                        MessageBox.Show("Done!");
                    }

                    else
                    {
                        MessageBox.Show("Failed");

                    }
                }
            }
        }
        /***************************************************************************************/
        // Report 1
        /***************************************************************************************/
        private void Report1Btn_Click(object sender, EventArgs e)
        {
            Report1ListView.Items.Clear();
            string whName = WHReportBox.Text;
            if (whName == "All Items")
            {
                var Items = Context.Items.Select(item => item);
                foreach (var item in Items)
                {
                    //DateTime exDate = (DateTime)item.Supply_Notice_Item.FirstOrDefault().Expiry_Date;
                    //DateTime productionDate = (DateTime)item.Supply_Notice_Item.FirstOrDefault().Production_Date;
                    row = new ListViewItem();
                    row.Text = item.It_Code.ToString();
                    row.SubItems.Add(item.It_Name);
                    row.SubItems.Add(item.Amount.ToString());

                    Report1ListView.Items.Add(row);
                }
            }
            else
            {
                var WhItems = from Items in Context.Items
                              where Items.Wh_Name == whName
                              select Items;
                foreach (var Item in WhItems)
                {
                    row = new ListViewItem();
                    row.Text = Item.It_Code.ToString();
                    row.SubItems.Add(Item.It_Name);
                    row.SubItems.Add(Item.Amount.ToString());

                    Report1ListView.Items.Add(row);
                }
            }
        }
        private void Report1Tab_Enter(object sender, EventArgs e)
        {
            Report1ListView.Items.Clear();
            WHReportBox.Items.Clear();
            WHReportBox.Items.Add("All Items");
            WHReportBox.SelectedIndex = 0;
            var WhNames = Context.Warehouses.Select(wh => wh.Wh_Name);
            foreach (var wh in WhNames)
            {
                WHReportBox.Items.Add(wh);
            }
        }

        private void WHReportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /***************************************************************************************/
        // Report 4
        /***************************************************************************************/
        private void Report4Tab_Enter(object sender, EventArgs e)
        {
            Report4ListView.Items.Clear();
            RWHBox.Items.Clear();
            var WhNames = Context.Warehouses.Select(wh => wh.Wh_Name);
            foreach (var wh in WhNames)
            {
                RWHBox.Items.Add(wh);
            }
        }
        private void Report4Btn_Click(object sender, EventArgs e)
        {
            int years = dateTimePicker2.Value.Year;
            int months = dateTimePicker2.Value.Month;

            List<Supply_Notice_Item> items = new List<Supply_Notice_Item>();
            var note = Context.Supply_Notice.Where(SN => SN.Wh_Name == RWHBox.Text).FirstOrDefault();
            if (note != null)
            {
                foreach (var d in Context.Supply_Notice_Item.Where(SNI => SNI.SN_ID == note.SN_ID))
                {
                    items.Add(d);
                }

                Report4ListView.Items.Clear();
                foreach (var it in items)
                {
                    DateTime givenDate = DateTime.Now.AddYears(years).AddMonths(months);
                    DateTime ProductionDate = (DateTime)it.Production_Date;
                    DateTime expDate = (DateTime)it.Expiry_Date;
                    DateTime expireDate = ProductionDate.AddYears(it.Expiry_Date.Value.Year).AddMonths(it.Expiry_Date.Value.Month);
                    TimeSpan remainingDate = givenDate - expireDate;
                    if (remainingDate.TotalDays >= 0)
                    {
                        string ItemName = Context.Items.Select(item => item).Where(item => item.It_Code == it.It_Code).FirstOrDefault().It_Name.Trim();
                        string SupplierName = it.Supply_Notice.Supplier.Supplier_Name;
                        row = new ListViewItem();
                        row.Text = it.It_Code.ToString();
                        row.SubItems.Add(ItemName);
                        row.SubItems.Add(((int)(remainingDate.TotalDays)).ToString() + " Day");
                        row.SubItems.Add(it.Amount.ToString());
                        row.SubItems.Add(expDate.ToShortDateString());
                        row.SubItems.Add(ProductionDate.ToShortDateString());
                        row.SubItems.Add(SupplierName);
                        Report4ListView.Items.Add(row);
                    }
                }
            }
            else
            {
                Report4ListView.Items.Clear();
            }
        }
        

        /***************************************************************************************/
        // Report 5
        /***************************************************************************************/
        private void Report5Btn_Click(object sender, EventArgs e)
        {
            int years = dateTimePicker1.Value.Year;
            int months = dateTimePicker1.Value.Month;

            List<Supply_Notice_Item> items = new List<Supply_Notice_Item>();
            foreach (var d in Context.Supply_Notice_Item)
            {
                items.Add(d);
            }

            listView1.Items.Clear();
            foreach (var it in items)
            {
                DateTime givenDate = DateTime.Now.AddYears(years).AddMonths(months);
                DateTime ProductionDate = (DateTime)it.Production_Date;
                DateTime expDate = (DateTime)it.Expiry_Date;
                DateTime expireDate = ProductionDate.AddYears(it.Expiry_Date.Value.Year).AddMonths(it.Expiry_Date.Value.Month);
                TimeSpan remainingDate = givenDate - expireDate;
                if (remainingDate.TotalDays >= 0)
                {
                    string ItemName = Context.Items.Select(item => item).Where(item => item.It_Code == it.It_Code).FirstOrDefault().It_Name.Trim();
                    string SupplierName = it.Supply_Notice.Supplier.Supplier_Name;
                    row = new ListViewItem();
                    row.Text = it.It_Code.ToString();
                    row.SubItems.Add(ItemName);
                    row.SubItems.Add(((int)(remainingDate.TotalDays)).ToString() + " Day");
                    row.SubItems.Add(it.Amount.ToString());
                    row.SubItems.Add(expDate.ToShortDateString());
                    row.SubItems.Add(ProductionDate.ToShortDateString());
                    row.SubItems.Add(SupplierName);
                    listView1.Items.Add(row);
                }
            }
        }
    }
}
