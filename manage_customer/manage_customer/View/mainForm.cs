using manage_customer.Controller;
using manage_customer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_customer.View
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void lviCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lviHistory.Items.Clear();
            string searchString = lviCustomer.SelectedItems[0].Text;
            SlotController slotController = new SlotController();
            List<Slot> listSlot = slotController.getBySearchString(searchString);
            ListViewItem dummyItem = new ListViewItem();
            foreach (Slot slot in listSlot)
            {
                dummyItem.Text = slot.Name;
                dummyItem.SubItems.Add(slot.Date);
                dummyItem.SubItems.Add(slot.Service);
                dummyItem.SubItems.Add(slot.Product);
                dummyItem.SubItems.Add(slot.Staff);
                dummyItem.SubItems.Add(slot.Note);
                lviHistory.Items.Add(dummyItem);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            lviCustomer.Items.Clear();
            CustomerController customerController = new CustomerController();
            List<Customer> listCustomer = customerController.getBySearchString(txtFind.Text);
            ListViewItem dummyItem = new ListViewItem();
            foreach (Customer customer in listCustomer)
            {
                dummyItem.Text = customer.Id;
                dummyItem.SubItems.Add(customer.Name);
                dummyItem.SubItems.Add(customer.Phone);
                dummyItem.SubItems.Add(customer.Address);
                lviCustomer.Items.Add(dummyItem);
            }
        }
    }
}
