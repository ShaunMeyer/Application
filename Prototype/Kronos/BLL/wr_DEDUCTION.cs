using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_DEDUCTION
    {
        private int deductID { get; set; }
        private string empID { get; set; }
        private DateTime deductDate { get; set; }
        private string deductName { get; set; }
        private double totalAmt { get; set; }
        private string dTypeID { get; set; }

        public wr_DEDUCTION()
        {
        }

        public wr_DEDUCTION(int deductID, string empID, DateTime deductDate, string deductName, double totalAmt, string dTypeID)
        {
            this.deductID = deductID;
            this.empID = empID;
            this.deductDate = deductDate;
            this.deductName = deductName;
            this.totalAmt = totalAmt;
            this.dTypeID = dTypeID;


        }
    }
}
