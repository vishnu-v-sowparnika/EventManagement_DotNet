using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EventManagement.Configuration;
using EventManagement.Web;

namespace EventManagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EventManagementDbContextFactory : IDesignTimeDbContextFactory<EventManagementDbContext>
    {
        public EventManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EventManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EventManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EventManagementConsts.ConnectionStringName));

            return new EventManagementDbContext(builder.Options);
        }
    }
}
