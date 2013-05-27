using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_PAY_SLIP
    {
        private int slipID { get; set; }
        private DateTime slipDate { get; set; }
        private DateTime slipStart { get; set; }
        private DateTime slipEnd { get; set; }
        private string empID { get; set; }

        public wr_PAY_SLIP()
        {
        }

        public wr_PAY_SLIP(int slipID, DateTime slipDate, DateTime slipStart, DateTime slipEnd, string empID)
        {
            this.slipID = slipID;
            this.slipDate = slipDate;
            this.slipStart = slipStart;
            this.slipEnd = slipEnd;
            this.empID = empID;
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
