using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_NOTE_TYPE
    {
        private int nTypeID { get; set; }
        private string noteName { get; set; }
        private string priority { get; set; }

        public wr_NOTE_TYPE()
        {
        }

        public wr_NOTE_TYPE(int nTypeID, string noteName, string priority)
        {
            this.nTypeID = nTypeID;
            this.noteName = noteName;
            this.priority = priority;
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
