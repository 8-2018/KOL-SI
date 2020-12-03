using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MenuItem = DataLayer.Models.MenuItem;

namespace PresentationLayerWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private MenuItemBusiness menuItemBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.menuItemBusiness = new MenuItemBusiness();
            GetAllMenuItems();
        }

        private void GetAllMenuItems()
        {
            ListBoxMenuItem.Items.Clear();

            List<MenuItem> listOfMenuItems = this.menuItemBusiness.GetAllMenuItems();

            foreach (MenuItem mi in listOfMenuItems)
            {
                ListBoxMenuItem.Items.Add(mi.Id + ". " + mi.Title + " – " + mi.Description + " — " + mi.Price);
            }
        }

        protected void ButtonMenuItemInsert_Click(object sender, EventArgs e)
        {
            MenuItem mi = new MenuItem();
            mi.Title = TextBoxMenuItemTitle.Text;
            mi.Description = TextBoxMenuItemDescription.Text;
            mi.Price = Convert.ToDecimal(TextBoxMenuItemPrice.Text);

            LabelMessages.Text = this.menuItemBusiness.InsertMenuItem(mi).ToString();

            GetAllMenuItems();

            TextBoxMenuItemTitle.Text = "";
            TextBoxMenuItemDescription.Text = "";
            TextBoxMenuItemPrice.Text = "";
        }

        protected void ButtonMenuItemRefreshListBoxMenuItem_Click(object sender, EventArgs e)
        {
            GetAllMenuItems();
        }
    }
}