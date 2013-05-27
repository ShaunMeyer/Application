using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_SHIFTED
    {
        private string empID { get; set; }
        private int shiftID { get; set; }
        private DateTime shiftDate { get; set; }
        private int dutyID { get; set; }

        public wr_SHIFTED()
        { 
        }

        public wr_SHIFTED(int shiftID, string empID, DateTime shiftDate, int dutyID)
        {
            this.shiftID = shiftID;
            this.empID = empID;
            this.shiftDate = shiftDate;
            this.dutyID = dutyID;
        }
    }
}
