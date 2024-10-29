using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Domain
{
    public class DMS_RCRpdf
    {
        public string ID { get; set; }
        public DateTime? Createdby  { get; set; }
        public string Datecreated { get; set; }
        public string RCRNumber { get; set; }
        public string PDF { get; set; }
        public string? PDFpath { get; set; }
    }
}
