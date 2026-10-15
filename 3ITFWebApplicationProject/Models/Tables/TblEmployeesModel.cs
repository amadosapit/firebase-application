using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3ITFWebApplicationProject.Models.Tables
{
    public class TblEmployeesModel
    {
        public int empID { get; set; }
        public string empFName { get; set; }
        public string empMName { get; set; }
        public string empLName { get; set; }
        public int postID { get; set; }
        public int deptID { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}