using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class clsBookSale
    {
        string title;
        int quality;
        decimal price;

        static decimal saleTotal = 0;
        static int saleCount = 0;

        const float discountRate = 0.1f;
        bool isDiscount;

        public string Title { get => title; set => title = value; }
        public int Quality
        {
            get => quality; 
            set
            {
                if (value > 0)
                {
                    quality = value;
                }
                else throw new Exception(); 
            } 
        }
        public decimal Price
        {
            get => price; 
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else throw new Exception();
            } 
        }

        public static decimal SaleTotal { get => saleTotal; }
        public static int SaleCount { get => saleCount; }
        public bool IsDiscount { get => isDiscount; set => isDiscount = value; }

        public clsBookSale(string _title, int _quality, decimal _price, bool _discount)
        {
            this.title = _title;
            this.quality = _quality;
            this.price = _price;
            this.isDiscount = _discount;
        }

        public virtual decimal DiscountAmount()
        {
            decimal disAmount;

            if (isDiscount)
            {
                disAmount = quality * price * Convert.ToDecimal(discountRate);
            }
            else
            {
                disAmount = 0m;
            }

            return disAmount;
        }

        public decimal NetDue()
        {
            decimal netDue = ExtendedPrice() - DiscountAmount();

            saleTotal += netDue;
            saleCount++;

            return netDue;
        }

        public decimal ExtendedPrice()
        {
            decimal exPrice = quality * price;

            //saleTotal += exPrice;

            //saleCount++;

            return exPrice;
        }
       
    }
}
