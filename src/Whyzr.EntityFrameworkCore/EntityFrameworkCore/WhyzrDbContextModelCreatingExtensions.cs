using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Whyzr.EntityFrameworkCore
{
    public static class WhyzrDbContextModelCreatingExtensions
    {
        public static void ConfigureWhyzr(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(WhyzrConsts.DbTablePrefix + "YourEntities", WhyzrConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}