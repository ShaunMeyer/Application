using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_NOTIFICATION
    {
        private int noteID { get; set; }
        private DateTime noteDate { get; set; }
        private string noteEvent { get; set; }
        private string noteAction { get; set; }
        private int nTypeID { get; set; }

        public wr_NOTIFICATION()
        {
        }

        public wr_NOTIFICATION(int noteID, DateTime noteDate, string noteEvent,
                               string noteAction, int nTypeID)
        {
            this.noteID = noteID;
            this.noteDate = noteDate;
            this.noteEvent = noteEvent;
            this.noteAction = noteAction;
            this.nTypeID = nTypeID;
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
