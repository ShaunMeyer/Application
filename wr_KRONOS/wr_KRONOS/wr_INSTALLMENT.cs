using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_INSTALLMENT
    {
        private int installID { get; set; }
        private DateTime installDate { get; set; }
        private double installAmt { get; set; }
        private int deductID { get; set; }
        private string empID { get; set; }
        private DateTime deductDate { get; set; }
        private int slipID { get; set; }

        public wr_INSTALLMENT()
        {
        }

        public wr_INSTALLMENT(int installID, DateTime installDate, double installAmt, int deductID,
                              string empID, DateTime deductDate, int slipID)
        {
            this.installID = installID;
            this.installDate = installDate;
            this.installAmt = installAmt;
            this.deductID = deductID;
            this.empID = empID;
            this.deductDate = deductDate;
            this.slipID = slipID;
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
