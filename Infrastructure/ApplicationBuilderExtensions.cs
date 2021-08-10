namespace TrekkingStore.Infrastructure
{

    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;
    using TrekkingStore.Data;
    using TrekkingStore.Data.Models;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<TrekkingStorebContext>();

            data.Database.Migrate();

            

            return app;
        }

        private static void SeedCategories(TrekkingStorebContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category {Name = "Backpak"},
                new Category {Name = "Shoes and Boots"},
                new Category {Name = "Tents"},
                new Category {Name = "Hiking Clothings"},
                new Category {Name = "Cooking"},
                new Category {Name = "Compass"},
                new Category {Name = "Caps and Bandana"}
            });

            data.SaveChanges();
        }
    }
}
