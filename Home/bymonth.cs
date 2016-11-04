using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class bymonth
    {
        double _rent;
        double _internet;
        double _electrcity;
        int _roomate;
        //double _total;
        public bymonth(int roomate,double rent, double internet, double electrcity) //consturucor 
        {
            theRoomate = roomate;
            theRent = rent;
            theInternet = internet;
            theElectrcity = electrcity;
        }
        public int theRoomate
        {
            get
            {
                return _roomate;
            }
            set
            {
                _roomate = value;
            }
        }
        public double theRent
        {
            get
            {
                return _rent;
            }
            set
            {
                _rent = value;
            }
        }
        public double theInternet
        {
            get
            {
                return _internet;
            }
            set
            {
                _internet = value;
            }
        }
        public double theElectrcity
        {
            get
            {
                return _electrcity;
            }
            set
            {
                _electrcity = value;
            }
        }
        //public double theTotal
        //{
        //    get
        //    {
        //        return _total;
        //    }
        //    set
        //    {
        //        _total = value;
        //    }
        //}
        //public void calc(double amount)
        //{
        //    theTotal = amount / theRoomate;
        //}

    }
}
