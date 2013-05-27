using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_DUTY
    {
        private int dutyID { get; set; }
        private string dutyName { get; set; }
        private string dutyDescription { get; set; }
        private string dutyGender { get; set; }
        private string deptID { get; set; }

        public wr_DUTY()
        {
        }

        public wr_DUTY(int dutyID, string dutyName, string dutyDescription, string dutyGender, string deptID)
        {
            this.dutyID = dutyID;
            this.dutyName = dutyName;
            this.dutyDescription = dutyDescription;
            this.dutyGender = dutyGender;
            this.deptID = deptID;
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
