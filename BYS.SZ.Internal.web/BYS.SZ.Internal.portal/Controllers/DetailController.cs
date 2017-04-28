using BYS.SZ.Internal.db.Model;
using BYS.SZ.Internal.portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BYS.SZ.Internal.portal.Controllers
{
    public class DetailController : Controller
    {
        public ActionResult Billing()
        {
            List<BillingModel> list = new List<BillingModel>();

            BillingModel billing1 = new BillingModel
            {
                SOWName = "ASG Cortana/Carina dev",
                UserName = "郁霖",
                UserAlias = "v-yln",
                OnboardDate = DateTime.Now.AddYears(-1).ToString("YYYY/MM/dd"),
                Location = "Suzhou OF",
                MicroTitle = "SDE Lead",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing2 = new BillingModel
            {
                SOWName = "ASG Cortana/Carina dev",
                UserName = "亢晓江",
                UserAlias = "v-xikan",
                OnboardDate = DateTime.Now.AddYears(-1).ToString("YYYY/MM/dd"),
                Location = "Suzhou OF",
                MicroTitle = "PM 3",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing3 = new BillingModel
            {
                SOWName = "ASG Cortana/Carina dev",
                UserName = "窦素娥",
                UserAlias = "v-suedou",
                OnboardDate = DateTime.Now.AddYears(-1).ToString("YYYY/MM/dd"),
                Location = "Suzhou OF",
                MicroTitle = "SDE 2",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing4 = new BillingModel
            {
                SOWName = "ASG Cortana/Carina dev",
                UserName = "徐培",
                UserAlias = "v-peix",
                OnboardDate = DateTime.Now.AddYears(-1).ToString("YYYY/MM/dd"),
                Location = "Suzhou OF",
                MicroTitle = "SDE 2",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };

            list.Add(billing1);
            list.Add(billing2);
            list.Add(billing3);
            list.Add(billing4);


            return View("_Billing", list);
        }
      
    }
}