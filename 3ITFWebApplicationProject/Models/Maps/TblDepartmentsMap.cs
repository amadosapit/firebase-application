using _3ITFWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace _3ITFWebApplicationProject.Models.Maps
{
    public class TblDepartmentsMap : EntityTypeConfiguration<TblDepartmentsModel>
    {
        public TblDepartmentsMap()
        {
            HasKey(x => x.deptID);
            ToTable("tbldepartments");
        }
    }
}