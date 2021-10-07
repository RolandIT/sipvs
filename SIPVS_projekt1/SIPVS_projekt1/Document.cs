using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPVS_projekt1
{
    class Document
    {
        private string name;
        private string surname;
        private DateTime date;
        private Boolean coupon;
        private string couponStr;
        private LinkedList<MovieTableEntry> movies;

        public Document()
        {
            this.movies = new LinkedList<MovieTableEntry>();
        }
        public Document(string name, string surname, DateTime date, Boolean coupon, string couponStr, LinkedList<MovieTableEntry> movies)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.coupon = coupon;
            this.couponStr = couponStr;
            this.movies = new LinkedList<MovieTableEntry>();
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Coupon { get => coupon; set => coupon = value; }
        public string CouponStr { get => couponStr; set => couponStr = value; }
        internal LinkedList<MovieTableEntry> Movies { get => movies; set => movies = value; }
    }
}
