using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class clsStudentBookSale : clsBookSale
    {
        bool isStudentDiscount;
        const float stdDiscountRate = 0.15f;

        public bool IsStudentDiscount { get => isStudentDiscount; set => isStudentDiscount = value; }

        public clsStudentBookSale(string _title, int _quality, decimal _price, bool _discount,bool _student) : base(_title, _quality, _price, _discount)
        {
            isStudentDiscount = _student;
        }

        public override decimal DiscountAmount()
        {
            decimal disAmount;

            disAmount = base.DiscountAmount();

            if (isStudentDiscount)
            {
                disAmount += ExtendedPrice() * Convert.ToDecimal(stdDiscountRate);
            }

            return disAmount;
        }
    }
}
