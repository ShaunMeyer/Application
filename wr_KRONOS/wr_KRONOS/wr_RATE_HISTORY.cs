using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_RATE_HISTORY
    {
        private int rateID { get; set; }
        private double payRate { get; set; }
        private DateTime rateStarted { get; set; }
        private DateTime rateEnded { get; set; }
        public string deptID { get; set; }

        public wr_RATE_HISTORY()
        {
        }

        public wr_RATE_HISTORY(int rateID, double payRate, DateTime rateStarted, DateTime rateEnded, string deptID)
        {
            this.rateID = rateID;
            this.payRate = payRate;
            this.rateStarted = rateStarted;
            this.rateEnded = rateEnded;
            this.deptID = deptID;
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
