using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = DataLayer.Models.MenuItem;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private MenuItemBusiness menuItemBusiness;
        public Form1()
        {
            this.menuItemBusiness = new MenuItemBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<MenuItem> menuItems = this.menuItemBusiness.GetAllMenuItems();
            listBoxMenuItems.Items.Clear();

            foreach (MenuItem mi in menuItems)
            {
                listBoxMenuItems.Items.Add(mi.Id + ". " + mi.Title + "(" + mi.Description + ") - " +
                    mi.Price);
            }
        }
        private void buttonInsertMenuItem_Click(object sender, EventArgs e)
        {
            MenuItem mi = new MenuItem();
            mi.Title = textBoxTitle.Text;
            mi.Description = textBoxDescription.Text;
            mi.Price = Convert.ToDecimal(textBoxPrice.Text);

            if (this.menuItemBusiness.InsertMenuItem(mi))
            {
                RefreshData();
                textBoxTitle.Text = "";
                textBoxDescription.Text = "";
                textBoxPrice.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }
    }
}
