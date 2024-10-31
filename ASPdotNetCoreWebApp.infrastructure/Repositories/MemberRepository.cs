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
           new Member{  Id =1 ,Name= "Kirtesh Shah", Email ="myemail@email.com" , Age=23, Password="Vadodara"},
           new Member{  Id =2 ,Name= "Mahesh Shah", Email ="Smyemail@email.com" , Age=37, Password="Dabhoi"},
           new Member{  Id =3 ,Name= "Nitya Shah", Email ="Gmyemail@email.com" , Age=22, Password="Mumbai"},
           new Member{  Id =4 ,Name= "Dilip Shah", Email ="Smyemail@email.com" , Age=25, Password="Dabhoi"},
           new Member{  Id =5 ,Name= "Hansa Shah", Email ="Smyemail@email.com" , Age=23, Password="Dabhoi"},
           new Member{  Id =6 ,Name= "Mita Shah", Email ="Gmyemail@email.com" , Age=31, Password="Surat"}
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
