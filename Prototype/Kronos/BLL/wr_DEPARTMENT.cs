using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronos.BLL
{
    class wr_DEPARTMENT
    {
        public string deptID { get; set; }
        public string deptName { get; set; }
        public string deptDesription { get; set; }
        public string position { get; set; } 

        public wr_DEPARTMENT()
        {}

        public wr_DEPARTMENT(string deptID, string deptName, string deptDescription, string position)
        {
            this.deptID = deptID;
            this.deptName = deptName;
            this.deptDesription = deptDesription;
            this.position = position;
        
        
        }

    }
}
