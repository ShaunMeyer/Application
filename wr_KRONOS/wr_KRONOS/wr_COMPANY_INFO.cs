using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_COMPANY_INFO
    {
        private int companyID { get; set; }
        private string companyName { get; set; }
        private string companyAddress { get; set; }
        private string vatNumber { get; set; }
        private string telNumber { get; set; }
        private byte[] companyLogo { get; set; }

        public wr_COMPANY_INFO()
        {
        }

        public wr_COMPANY_INFO(int companyID, string companyName, string companyAddress,
                               string vatNumber, string telNumber, byte[] companyLogo)
        {
            this.companyID = companyID;
            this.companyName = companyName;
            this.companyAddress = companyAddress;
            this.vatNumber = vatNumber;
            this.telNumber = telNumber;
            this.companyLogo = companyLogo;
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
