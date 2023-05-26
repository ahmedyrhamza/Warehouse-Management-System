using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class ItemForm : Form
    {
        Trading_CompanyEntities Context;
        int ItCode;

        public ItemForm(int InertOrUpdate, int ItemCode, Trading_CompanyEntities Con)
        {
            InitializeComponent();
            Context = Con;
            ItCode = ItemCode;

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
                //CodeBox.Enabled = false;
                //CodeBox.Cursor = Cursors.No;
                var item = Context.Items.Where(it => it.It_Code == ItemCode).Select(it => it).FirstOrDefault();

                if (item != null)
                {
                    //CodeBox.Text = item.It_Code.ToString();
                    NameBox.Text = item.It_Name;
                    UnitBox.Text = item.Item_Unit.FirstOrDefault().It_Unit;
                    AmountBox.Text = item.Amount.ToString();
                    WHBox.SelectedIndex = WHBox.FindStringExact(item.Wh_Name);
                }
                


            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || UnitBox.Text == "" || AmountBox.Text == "" || WHBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    Item item = new Item();
                    Item_Unit unit = new Item_Unit();
                    item.It_Name = NameBox.Text;
                    item.Wh_Name = WHBox.Text;
                    item.Amount = int.Parse(AmountBox.Text);
                    unit.It_Code = ItCode;
                    unit.It_Unit = UnitBox.Text;
                    item.Item_Unit.Add(unit);
                    Context.Items.Add(item);
                    Context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show($"Done!");  
                }
                catch
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || UnitBox.Text == "" || AmountBox.Text == "" || WHBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
            else
            {
                try
                {
                    var Result = Context.Items.FirstOrDefault(i => i.It_Code == ItCode);
                    if (Result != null)
                    {
                        Result.It_Name = NameBox.Text;
                        Result.Wh_Name = WHBox.Text;
                        Result.Amount = int.Parse(AmountBox.Text);
                        var UnitFound = false;
                        foreach (var unit in Result.Item_Unit)
                        {
                            if (unit.It_Unit == UnitBox.Text)
                            {
                                UnitFound = true;
                            }
                        }
                        if (!UnitFound)
                        {
                            Item_Unit NewUnit = new Item_Unit();
                            NewUnit.It_Unit = UnitBox.Text;
                            Result.Item_Unit.Add(NewUnit);
                        }
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
