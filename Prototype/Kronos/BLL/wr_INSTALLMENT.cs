using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_INSTALLMENT
    {
        private int installID { get; set; }
        private DateTime installDate { get; set; }
        private double installAmt { get; set; }
        private string dTypeID { get; set; }
        private int slipID { get; set; }

        public wr_INSTALLMENT()
        { 
        }

        public wr_INSTALLMENT(int installID, DateTime installDate, double installAmt, string dTypeID, int slipID)
        {
            this.installID = installID;
            this.installDate = installDate;
            this.installAmt = installAmt;
            this.dTypeID = dTypeID;
            this.slipID = slipID;


        }
    }
}
