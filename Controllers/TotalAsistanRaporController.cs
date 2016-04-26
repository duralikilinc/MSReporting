using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Dal;
using Microsoft.Reporting.WebForms;

namespace AsistanTakipSistemi.Controllers
{
    public class TotalAsistanRaporController : Controller
    {
        private Entities db = new Entities();

        
        // GET: TotalAsistanRapor
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ExportPdf()
        {

                string id = "PDF";
                LocalReport lr = new LocalReport();
                string path = Path.Combine(Server.MapPath("~/Report"), "Report_TotalAsistan.rdlc");
                if (System.IO.File.Exists(path))
                {
                    lr.ReportPath = path;
                }
                else
                {
                    return RedirectToAction("", "");
                }


                var cm = db.View_Personel_TotalAsistan.ToList().OrderBy(d => d.Ad);


                ReportDataSource rd = new ReportDataSource("DataSet_TotalAsistan", cm);
                lr.DataSources.Add(rd);
                string reportType = id;
                string mimeType;
                string encoding;
                string fileNameExtension;



                string deviceInfo =

                    "<DeviceInfo>" +
                    "  <OutputFormat>" + id + "</OutputFormat>" +
                    "  <PageWidth>16.54in</PageWidth>" +
                    "  <PageHeight>11.69in</PageHeight>" +
                    "  <MarginTop>0.5in</MarginTop>" +
                    "  <MarginLeft>1in</MarginLeft>" +
                    "  <MarginRight>1in</MarginRight>" +
                    "  <MarginBottom>0.5in</MarginBottom>" +
                    "</DeviceInfo>";


                Warning[] warnings;
                string[] streams;
                byte[] renderedBytes;

                renderedBytes = lr.Render(
                    reportType,
                    deviceInfo,
                    out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings);
                return File(renderedBytes, mimeType);

            }
        }

    }
}