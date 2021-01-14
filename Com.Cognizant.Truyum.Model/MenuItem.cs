using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private long _id;
        private string _name;
        private float _price;
        private bool _active;
        private DateTime _dateOfLaunch;
        private string _category;
        private bool _freeDelivery;

        //properties
        public long Id
        {
            get => _id;
            set { _id = value; }
        }
        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        public float Price
        {
            get => _price;
            set { _price = value; }
        }
        public bool Active
        {
            get => _active;
            set { _active = value; }
        }
        public DateTime DateOfLaunch
        {
            get => _dateOfLaunch;
            set { _dateOfLaunch = value; }
        }
        public string Category
        {
            get => _category;
            set { _category = value; }
        }
        public bool FreeDelivery
        {
            get => _freeDelivery;
            set { _freeDelivery = value; }
        }
        public MenuItem() { }

        // parameter constructor
        public MenuItem(long id, string name, float price, bool active, DateTime dateOfLaunch, string category, bool freeDelivery)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            DateOfLaunch = dateOfLaunch;
            Category = category;
            FreeDelivery = freeDelivery;
        }

        //generated ToString()
        public override string ToString()
        {
            return base.ToString();
        }

        //generated Equal()
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
