using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_PUBLIC_HOLIDAY
    {
        private int dayID { get; set; }
        private string dayName { get; set; }
        private string dayNotes { get; set; }
        private DateTime dayDate { get; set; }
        private int sprID { get; set; }

        public wr_PUBLIC_HOLIDAY()
        {
        }

        public wr_PUBLIC_HOLIDAY(int dayID, string dayName, string dayNotes,
             DateTime dayDate, int sprID)
        {
            this.dayID = dayID;
            this.dayName = dayName;
            this.dayNotes = dayNotes;
            this.dayDate = dayDate;
            this.sprID = sprID;
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
