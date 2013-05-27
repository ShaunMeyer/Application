using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_SPECIAL_RATE
    {
        private int sprID { get; set; }
        private string sprName { get; set; }
        private double sprValue { get; set; }

        public wr_SPECIAL_RATE()
        {
        }

        public wr_SPECIAL_RATE(int sprID, string sprName, double sprValue)
        {
            this.sprID = sprID;
            this.sprName = sprName;
            this.sprValue = sprValue;
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
