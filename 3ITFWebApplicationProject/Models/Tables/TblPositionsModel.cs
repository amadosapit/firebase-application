using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3ITFWebApplicationProject.Models.Tables
{
    public class TblPositionsModel
    {
        public int postID { get; set; }
        public string postDescription { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}