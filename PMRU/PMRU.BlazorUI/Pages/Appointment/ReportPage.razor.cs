using iText.IO.Source;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.XMP.Impl;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Services;
using PMRU.Domain.Entities;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace PMRU.BlazorUI.Pages.Appointment
{
    public partial class ReportPage
    {
        [Inject]
        IAppointmentService appointmentService { get; set; }


        private DateOnly selectedDate;
        private List<AppointmentVM> reportResult;
        private string doctorFilter = "";
    



        protected override void OnInitialized()
        {
            selectedDate = DateOnly.FromDateTime(DateTime.Now);
        }

        private async Task ReceiveReport()
        {
            reportResult = await appointmentService.GetAppointmentsByDate(selectedDate);

            if (!string.IsNullOrWhiteSpace(doctorFilter))
            {
                reportResult = reportResult
                    .Where(r => r.Doctor.Name.ToLower().Contains(doctorFilter.ToLower()) || r.Doctor.Surname.ToLower().Contains(doctorFilter.ToLower()))
                    .ToList();
            }
        }

        public static byte[] MyPdf(List<AppointmentVM> reportResult)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            PdfWriter pdfWriter = new PdfWriter(memoryStream);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            iText.Layout.Document document = new iText.Layout.Document(pdfDocument);
            Table table = new Table(6, false);
            table.SetWidth(500); Cell cell11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Doctor Name"));
            table.SetWidth(500); Cell cell12 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Employee Name"));
            table.SetWidth(500); Cell cell13 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Appointment Date"));
            table.SetWidth(500); Cell cell14 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Appointment Start Hour"));
            table.SetWidth(500); Cell cell15 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Appointment End Hour"));
            table.SetWidth(500); Cell cell16 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Description"));
            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);
            table.AddCell(cell14);
            table.AddCell(cell15);
            table.AddCell(cell16);

            foreach (var result in reportResult)
            {
                var doctorName = Convert.ToString(result.Doctor.Name);
                var doctorSurName = Convert.ToString(result.Doctor.Surname);
                var employeeName = Convert.ToString(result.Employee.Name);
                var employeeSurName = Convert.ToString(result.Employee.Surname);
                var appointmentDate = Convert.ToString(result.AppointmentDate);
                var appointmentStartHour = Convert.ToString(result.AppointmentStartHour);
                var appointmentEndHour = Convert.ToString(result.AppointmentEndHour);
                var description = Convert.ToString(result.Description);

                Cell cellDoctorName = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph($"{doctorName} {doctorSurName}"));
                Cell cellEmployeeName = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph($"{employeeName} {employeeSurName}"));
                Cell cellad = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(appointmentDate));
                Cell cellash = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(appointmentStartHour));
                Cell cellaeh = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(appointmentEndHour));
                Cell cellDescription = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(description));

                table.AddCell(cellDoctorName);
                table.AddCell(cellEmployeeName);
                table.AddCell(cellad);
                table.AddCell(cellash);
                table.AddCell(cellaeh);
                table.AddCell(cellDescription);

            }



            document.Add(table);
            document.Close();
            return memoryStream.ToArray();
            

        }

        
    }
}
