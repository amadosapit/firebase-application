using _3ITFWebApplicationProject.Models;
using _3ITFWebApplicationProject.Models.Context;
using _3ITFWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3ITFWebApplicationProject.Controllers
{
    public class ITFApplicationController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult AboutPage()
        {
            return View();
        }

        public string GetUsername()
        {
            return "amado.sapit";
        }

        public string UpdateUsername(string username)
        {
            var updatedusername = username + " - updated";
            return updatedusername;
        }

        public JsonResult ManipulateData(UserModel umodel)
        {

            umodel.FirstName = "updated";
            umodel.MiddleName = "updated";
            umodel.LastName = "updated";

            return Json(umodel, JsonRequestBehavior.AllowGet);

        }

        public JsonResult CreateEmployee(UserModel userModel)
        {
            try
            {
                using(var db = new EmpContext())
                {
                    var empData = new TblEmployeesModel()
                    {
                        empFName = userModel.FirstName,
                        empMName = userModel.MiddleName,
                        empLName = userModel.LastName,
                        postID = 1,
                        deptID = 1,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };


                    db.tblemployees.Add(empData);
                    db.SaveChanges();

                    var allData = GetEmployeesData();

                    return Json(allData.Data, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex) {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult UpdateEmployee (UserModel userModel)
        {
            try
            {
                using(var db = new EmpContext())
                {
                    var empdata = db.tblemployees.Where(x => x.empID.Equals(userModel.UserID)).FirstOrDefault();
                    empdata.empFName = userModel.FirstName;
                    empdata.empMName = userModel.MiddleName;
                    empdata.empLName = userModel.LastName;
                    empdata.updatedAt = DateTime.Now;

                    db.SaveChanges();

                    var allData = GetEmployeesData();

                    return Json(allData.Data, JsonRequestBehavior.AllowGet);
                }

            }catch(Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult RemoveEmployee(int userID)
        {
            try
            {
                using(var db = new EmpContext())
                {
                    var empdata = db.tblemployees.Where(x => x.empID.Equals(userID)).FirstOrDefault();
                    db.tblemployees.Remove(empdata);
                    db.SaveChanges();

                    var allData = GetEmployeesData();

                    return Json(allData.Data, JsonRequestBehavior.AllowGet);
                }
            }catch(Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetEmployeesData()
        {
            try
            {
                using (var db = new EmpContext())
                {

                    var empdata = db.tblemployees.Select(x => x).ToList();
                    return Json(empdata, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }
        }




    }
}