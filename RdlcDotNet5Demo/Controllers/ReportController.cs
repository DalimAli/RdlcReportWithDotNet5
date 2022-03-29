using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdlcDotNet5Demo.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ReportController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        private readonly IEnumerable<Employee> employees = Employee.Gets();



        // GET: HomeController/Details/5
        public ActionResult SimpleReport()
        {
            var path = $"{_webHostEnvironment.ContentRootPath}" + "\\Reports" + "\\SimpleReport.rdlc";
            LocalReport localReport = new LocalReport(path);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("ReportTitle", "a simple report to start with dot net core rdlc");

            localReport.AddDataSource("DataSet", employees);

            var result = localReport.Execute(RenderType.Pdf, 1, param, "");
            return File(result.MainStream, "application/pdf");
        }

        public ActionResult GroupReport()
        {
            var path = $"{_webHostEnvironment.ContentRootPath}" + "\\Reports" + "\\GroupReport.rdlc";
            LocalReport localReport = new LocalReport(path);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("ReportTitle", "Group By Rdlc Report");

            localReport.AddDataSource("GroupDataSet", employees);

            var result = localReport.Execute(RenderType.Pdf, 1, param, "");
            return File(result.MainStream, "application/pdf");
        }


    }
}
