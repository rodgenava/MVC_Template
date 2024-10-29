using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPdotNetCoreWebApp.Domain;

namespace ASPdotNetCoreWebApp.Application
{
    public class DMS_RCRpdfService : IDMS_RCRpdfService
    {
        private readonly IDMS_RCRpdfRepository _DMS_RCRpdfRepository;
        public DMS_RCRpdfService(IDMS_RCRpdfRepository DMS_RCRpdfRepository) {
            _DMS_RCRpdfRepository = DMS_RCRpdfRepository;
        }

        public DMS_RCRpdf GetAllMembers()
        {
            return _DMS_RCRpdfRepository.GetMembersAsync();
        }
    }
}
