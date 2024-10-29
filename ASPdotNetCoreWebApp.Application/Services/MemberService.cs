using ASPdotNetCoreWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Application
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        //public List<Member> GetAllMembers()
        //{ 
        //    return _memberRepository.GetAllMembers();
        //}
        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            return await _memberRepository.GetMembersAsync();
        }
    }
}
