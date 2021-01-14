using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System.Collections.Generic;
using System;

namespace Com.Cognizant.Truyum.Dao
{
    class MenuItemDaoCollection : IMenuItemDao
    {
        private static List<MenuItem> menuItemList;


        public MenuItemDaoCollection()
        {
            if(menuItemList == null)
            {
                menuItemList = new List<MenuItem>();
                menuItemList.Add(new MenuItem(id: 1, name: "Sandwich", price: 99.00f, active: true, dateOfLaunch: DateUtility.ConvertToDate("2017/03/15"), category: "Main Course", freeDelivery: true));
                menuItemList.Add(new MenuItem(id: 2, name: "Burger", price: 129.00f, active: true, dateOfLaunch: DateUtility.ConvertToDate("2017/12/23"), category: "Main Course", freeDelivery: false));
                menuItemList.Add(new MenuItem(id: 3, name: "Pizza", price: 149.00f, active: true, dateOfLaunch: DateUtility.ConvertToDate("2018/08/21"), category: "Main Course", freeDelivery: false));
                menuItemList.Add(new MenuItem(id: 4, name: "French Fries", price: 57.00f, active: false, dateOfLaunch: DateUtility.ConvertToDate("2017/07/02"), category: "Starters", freeDelivery: true));
                menuItemList.Add(new MenuItem(id: 5, name: "Chocolate Brownie", price: 32.00f, active: true, dateOfLaunch: DateUtility.ConvertToDate("2022/11/02"), category: "Dessert", freeDelivery: true));
               
            }
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> custommerMenuItem = new List<MenuItem>();
            foreach(MenuItem item in menuItemList)
            {
                if(item.DateOfLaunch > DateTime.Now && item.Active == true)
                {
                    custommerMenuItem.Add(item);
                }
             
            }
            return custommerMenuItem;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            foreach(MenuItem item in menuItemList)
            {
                if (item.Equals(menuItem))
                {
                    menuItemList.Add(item);
                }
            }
        }

        public MenuItem GetMenuItem(long menuItemId)
        {
            List<MenuItem> getMenuItem = new List<MenuItem>();
            foreach(MenuItem item in menuItemList)
            {
                if(item.Id == menuItemId)
                {
                    getMenuItem.Add(item); 
                    
                }
            }
            return getMenuItem[0];    
        }
    }
}
