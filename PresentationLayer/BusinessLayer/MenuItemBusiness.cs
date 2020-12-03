using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MenuItemBusiness
    {
        private readonly MenuItemRepository menuItemRepository;

        public MenuItemBusiness()
        {
            this.menuItemRepository = new MenuItemRepository();
        }

        public List<MenuItem> GetAllMenuItems()
        {
            return this.menuItemRepository.GetAllMenuItems();
        }

        public bool InsertMenuItem(MenuItem mi)
        {
            if (this.menuItemRepository.InsertMenuItem(mi) > 0)
            {
                return true;
            }
            return false;
        }

        public List<MenuItem> GetAllMenuItemsBetween(decimal max, decimal min)
        {
            return this.GetAllMenuItems().Where(mi => mi.Price > min && mi.Price < max).ToList();
        }
    }
}
