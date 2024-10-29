using ASPdotNetCoreWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Application
{
    public interface IMemberService
    {
        //List<Member> GetAllMembers();
        Task<IEnumerable<Member>> GetAllMembers();
    }
}
