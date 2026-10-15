using _3ITFWebApplicationProject.Models.Maps;
using _3ITFWebApplicationProject.Models.Tables;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _3ITFWebApplicationProject.Models.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmpContext : DbContext
    {
        static EmpContext()
        {
            Database.SetInitializer<EmpContext>(null);
        }

        public EmpContext() : base("Name=dbConnection") { }

        public virtual DbSet<TblEmployeesModel> tblemployees { get; set; }
        public virtual DbSet<TblPositionsModel> tblpositions { get; set; }
        public virtual DbSet<TblDepartmentsModel> tbldepartments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new TblEmployeesMap());
            modelBuilder.Configurations.Add(new TblPositionsMap());
            modelBuilder.Configurations.Add(new TblDepartmentsMap());
        }
    }
}