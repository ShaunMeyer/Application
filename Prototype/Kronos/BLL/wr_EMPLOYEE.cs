using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BAL
{
    class wr_EMPLOYEE
    {
        private string empID { get; set; }
        private string identityNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private string cellNumber { get; set; }
        private string telNumber { get; set; }
        public string taxNumber { get; set; }
        private string bankingDetails { get; set; }
        private string payPackage { get; set; }
        private bool empActive { get; set; }
        private DateTime dateEmployed { get; set; }
        private string empStatus { get; set; }
        private string deptID { get; set; }


        public wr_EMPLOYEE()
        { }


        public wr_EMPLOYEE(string empID, string identityNumber, string firstName, string lastName, string address, string cellNumber
            , string telNumber, string taxNumber, string bankingDetails, string payPackage, bool empActive, DateTime dateEmployed, string empStatus, string deptID)
        {
            this.empID = empID;
            this.identityNumber = identityNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.cellNumber = cellNumber;
            this.telNumber = telNumber;
            this.taxNumber = taxNumber;
            this.bankingDetails = bankingDetails;
            this.payPackage = payPackage;
            this.empActive = empActive;
            this.dateEmployed = dateEmployed;
            this.empStatus = empStatus;
            this.deptID = deptID;
        
        
        
        }



    }

    
}
