using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3ITFWebApplicationProject.Models.Tables
{
    public class TblDepartmentsModel
    {
        public int deptID { get; set; }
        public string deptDescription { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}