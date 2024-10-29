using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ASPdotNetCoreWebApp.Domain;

namespace ASPdotNetCoreWebApp.Application
{
    public interface IMemberRepository
    {
        //List<Member> GetAllMembers();
        Task<IEnumerable<Member>> GetMembersAsync();
    }
}
