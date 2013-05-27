using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_SHIFT
    {
        private int shiftID { get; set; }
        private string shiftName { get; set; }
        private DateTime shiftStart { get; set; }
        private DateTime shiftEnd { get; set; }

        public wr_SHIFT()
        {
        }

        public wr_SHIFT(int shiftID, string shiftName, DateTime shiftStart, DateTime shiftEnd)
        {
            this.shiftID = shiftID;
            this.shiftName = shiftName;
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;
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
