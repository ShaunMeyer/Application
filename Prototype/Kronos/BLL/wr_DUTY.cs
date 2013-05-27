using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_DUTY
    {
        private int dutyID { get; set; }
        private string dutyName {get; set;} 
        private string dutyDescription {get; set;}
        private string deptID { get; set; }

        public wr_DUTY()
        {
        }

        public wr_DUTY(int dutyID, string dutyName, string dutyDescription, string deptID)
        {
            this.dutyID = dutyID;
            this.dutyName = dutyName;
            this.dutyDescription = dutyDescription;
            this.deptID = deptID;


        }
    }
}
