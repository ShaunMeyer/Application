using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_DEDUCT_TYPE
    {
        private string dTypeID { get; set; }
        private string deductDescription { get; set; }
        private string defaultInstallment { get; set; }
        private int numOfInstallment { get; set; }

        public wr_DEDUCT_TYPE()
        {
        }

        public wr_DEDUCT_TYPE(string dTypeID, string deductDescription, string defaultInstallment, int numOfInstallment)
        {
            this.dTypeID = dTypeID;
            this.deductDescription = deductDescription;
            this.defaultInstallment = defaultInstallment;
            this.numOfInstallment = numOfInstallment;


        }
    }
}
