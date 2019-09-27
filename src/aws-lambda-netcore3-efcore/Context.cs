using Microsoft.EntityFrameworkCore;

namespace aws_lambda_netcore3_efcore
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<Member> Members { get; set; }

    }
}