using ASPdotNetCoreWebApp.Application;
using ASPdotNetCoreWebApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Infrastructure
{
    public class DMS_RCRpdfRepository : IDMS_RCRpdfRepository
    {
        private readonly AppDbContext _context;
        public DMS_RCRpdfRepository(AppDbContext context)
        {
            _context = context;
        }

        public DMS_RCRpdf GetMembersAsync()
        {
            return _context.DMS_RCRpdf.Select(a => new DMS_RCRpdf
                            {
                                RCRNumber = a.RCRNumber,
                                PDF = a.PDF,
                                PDFpath = a.PDFpath
                            }).FirstOrDefault();
        }
    }
}
