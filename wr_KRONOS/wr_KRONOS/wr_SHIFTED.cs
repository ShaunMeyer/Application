using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_SHIFTED
    {
        private string empID { get; set; }
        private int shiftID { get; set; }
        private DateTime shiftDate { get; set; }
        private DateTime clockStartShift { get; set; }
        private DateTime clockEndShift { get; set; }
        private int dutyID { get; set; }

        public wr_SHIFTED()
        {
        }

        public wr_SHIFTED(int shiftID, string empID, DateTime shiftDate, DateTime clockStartShift, DateTime clockEndShift, int dutyID)
        {
            this.shiftID = shiftID;
            this.empID = empID;
            this.shiftDate = shiftDate;
            this.clockStartShift = clockStartShift;
            this.clockEndShift = clockEndShift;
            this.dutyID = dutyID;
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
