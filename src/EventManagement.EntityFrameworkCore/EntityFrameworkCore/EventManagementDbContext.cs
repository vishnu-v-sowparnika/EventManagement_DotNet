using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EventManagement.Authorization.Roles;
using EventManagement.Authorization.Users;
using EventManagement.MultiTenancy;
using EventManagement.Models;

namespace EventManagement.EntityFrameworkCore
{
    public class EventManagementDbContext : AbpZeroDbContext<Tenant, Role, User, EventManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Address> Address { get; set; }
        public DbSet<Organiser> Organiser { get; set; }
        public DbSet<Models.Events> Events { get; set; }
        public DbSet<Models.Participants> participants { get; set; }

        public DbSet<Models.Registration> Registration { get; set; }
        public EventManagementDbContext(DbContextOptions<EventManagementDbContext> options)
            : base(options)
        {
        }
    }
}
