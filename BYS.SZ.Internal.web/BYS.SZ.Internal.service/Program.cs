using BYS.SZ.Internal.db.DBContext;
using BYS.SZ.Internal.db.DbOperation;
using BYS.SZ.Internal.db.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BYS.SZ.Internal.web.Service;
using System.Data;
using BYS.SZ.Internal.db.Entities;

namespace BYS.SZ.Internal.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Basic_DbContext context = new Basic_DbContext();
            ManageService manageService = new ManageService(context);
            ExcelHelper helper = null;
            if (args.Length == 0)
            {
                Console.WriteLine("Please specifiy excel file path!");
            }

            string testPath = args[0];
            try
            {
                helper = new ExcelHelper(testPath);
                DataTable dt = helper.ExcelToDataTable();
                if (dt != null)
                {
                    var allBllings = helper.TableToEntity(dt, typeof(BillingModel));

                    if(manageService.ConvertModel2Context(allBllings))
                    {
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Failed!");
                    }
                }
                else
                {
                    Console.WriteLine("Table doesn't exsit！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                helper.Dispose();
            }
            Console.ReadKey();
        }
    }
}
