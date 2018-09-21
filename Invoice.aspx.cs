using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspxToPdfTutorial
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var AspxToPdfOptions = new IronPdf.PdfPrintOptions()
            {
                Header = new IronPdf.SimpleHeaderFooter()
                {
                    CenterText = "Invoice",
                    DrawDividerLine = false,
                    FontFamily = "Arial",
                    FontSize = 12
                },
                Footer = new IronPdf.SimpleHeaderFooter()
                {
                    LeftText = "{date} - {time}",
                    DrawDividerLine = true,
                    RightText = "Page {page} of {total-pages}",
                    FontFamily = "Arial",
                    FontSize = 11
                },
                 PaperSize = IronPdf.PdfPrintOptions.PdfPaperSize.A4,
                 PaperOrientation = IronPdf.PdfPrintOptions.PdfPaperOrientation.Portrait

            };

            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.InBrowser, "Invoice.pdf", AspxToPdfOptions);
        }
    }
}