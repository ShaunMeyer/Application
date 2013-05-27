using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_DEDUCTION
    {
        private int deductID { get; set; }
        private string empID { get; set; }
        private DateTime deductDate { get; set; }
        private string deductName { get; set; }
        private double totalAmt { get; set; }
        private int numInstall { get; set; }
        private double amtOwed { get; set; }
        private string dTypeID { get; set; }

        public wr_DEDUCTION()
        {
        }

        public wr_DEDUCTION(int deductID, string empID, DateTime deductDate, string deductName,
                            double totalAmt, int numInstall, double amtOwed, string dTypeID)
        {
            this.deductID = deductID;
            this.empID = empID;
            this.deductDate = deductDate;
            this.deductName = deductName;
            this.totalAmt = totalAmt;
            this.numInstall = numInstall;
            this.amtOwed = amtOwed;
            this.dTypeID = dTypeID;
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
