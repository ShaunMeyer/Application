using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr_KRONOS
{
    public class wr_DEPARTMENT
    {
        public string deptID { get; set; }
        public string deptName { get; set; }
        public string deptDesription { get; set; }
        public string deptPosition { get; set; }

        public wr_DEPARTMENT()
        { }

        public wr_DEPARTMENT(string deptID, string deptName,
                             string deptDescription, string deptPosition)
        {
            this.deptID = deptID;
            this.deptName = deptName;
            this.deptDesription = deptDesription;
            this.deptPosition = deptPosition;
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
