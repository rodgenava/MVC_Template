using ASPdotNetCoreWebApp.Application;
using ASPdotNetCoreWebApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPdotNetCoreWebApp.Infrastructure
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _context;
        public MemberRepository(AppDbContext context)
        {
            _context = context;
        }

        public static List<Member> lstMembers = new List<Member>()
        {
           new Member{  Id =1 ,Name= "Kirtesh Shah", Type ="G" , Address="Vadodara"},
           new Member{  Id =2 ,Name= "Mahesh Shah", Type ="S" , Address="Dabhoi"},
           new Member{  Id =3 ,Name= "Nitya Shah", Type ="G" , Address="Mumbai"},
           new Member{  Id =4 ,Name= "Dilip Shah", Type ="S" , Address="Dabhoi"},
           new Member{  Id =5 ,Name= "Hansa Shah", Type ="S" , Address="Dabhoi"},
           new Member{  Id =6 ,Name= "Mita Shah", Type ="G" , Address="Surat"}
        };

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            return null; // await _context.Members.ToListAsync();
        }

        //public List<Member> GetAllMembers()
        //{
        //    return lstMembers;
        //}
    }
}
