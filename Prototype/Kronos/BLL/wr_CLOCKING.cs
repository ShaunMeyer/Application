using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_CLOCKING
    {
        private int clockingID { get; set; }
        private DateTime clockIn { get; set; }
        private DateTime clockOut { get; set; }
        private string reason { get; set; }
        private string clockingDescription { get; set; }
        private string empID { get; set; }
        private int shiftID { get; set; }
        private DateTime shiftDate { get; set; }

        public wr_CLOCKING()
        {
        }

        public wr_CLOCKING(int clockingID, DateTime clockIn, DateTime clockOut, string reason, string clockingDescription, string empID, int shiftID, DateTime shiftDate)
        {
            this.clockingID = clockingID;
            this.clockIn = clockIn;
            this.clockOut = clockOut;
            this.reason = reason;
            this.clockingDescription = clockingDescription;
            this.empID = empID;
            this.shiftID = shiftID;
            this.shiftDate = shiftDate;
        }
    }
}
