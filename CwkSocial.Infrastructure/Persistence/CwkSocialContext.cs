using CwkSocial.Domain.Aggregates.PostAggregate;
using CwkSocial.Domain.Aggregates.UserProfileAggregare;
using CwkSocial.Infrastructure.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CwkSocial.Infrastructure.Persistence
{
    public class CwkSocialContext : IdentityDbContext
    {
        public CwkSocialContext(DbContextOptions<CwkSocialContext> options) : base(options)
        {
            
        }
        public DbSet<UserProfile> userProfiles { get; set; }
        public DbSet<Post> posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CwkSocialContext).Assembly);
            modelBuilder.ApplyConfiguration(new PostCommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostInterationConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
            //modelBuilder.ApplyConfiguration(new IdentityUserLoginConfiguration());
            //modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
