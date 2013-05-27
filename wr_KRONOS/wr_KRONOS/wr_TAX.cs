using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_TAX
    {
        private int taxID { get; set; }
        private string taxName { get; set; }
        private double taxAmt { get; set; }

        public wr_TAX()
        {
        }

        public wr_TAX(int taxID, string taxName, double taxAmt)
        {
            this.taxID = taxID;
            this.taxName = taxName;
            this.taxAmt = taxAmt;
        }
        //ADD, CHANGE AND DELETE
        public void ADD()
        {

        }
        public void CHANGE()
        {

        }
        public void DELETE()
        {

        }
    }
}
