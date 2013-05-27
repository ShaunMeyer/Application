using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_DEDUCT_TYPE
    {
        private string dTypeID { get; set; }
        private string deductDescription { get; set; }
        private string defaultInstallment { get; set; }


        public wr_DEDUCT_TYPE()
        {
        }

        public wr_DEDUCT_TYPE(string dTypeID, string deductDescription, string defaultInstallment)
        {
            this.dTypeID = dTypeID;
            this.deductDescription = deductDescription;
            this.defaultInstallment = defaultInstallment;
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
