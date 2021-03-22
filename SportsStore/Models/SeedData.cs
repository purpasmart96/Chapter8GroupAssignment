using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Teton Sports Scout 3400",
                    Description = "45 Liter internal frame backpack",
                    Category = "Backpacks",
                    Price = 76
                },
                new Product
                {
                    Name = "Sleepingo Sleeping Pad",
                    Description = "Inflatable air sleeping pad",
                    Category = "Sleeping Pads",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "Trademark Supplies Tarp",
                    Description = "Heavy duty waterproof tarp 6x8 Feet",
                    Category = "Tarps",
                    Price = 19.88m
                },
                new Product
                {
                    Name = "Corona RS16150 Saw",
                    Description = "10 inch Foldable Saw",
                    Category = "Saws",
                    Price = 22.65m
                },
                new Product
                {
                    Name = "Becker BK2 Knife",
                    Description = "Campanion Fixed 5.25 Inch Blade Knife",
                    Category = "Knives",
                    Price = 87.91m
                },
                new Product
                {
                    Name = "Clostnature Tent",
                    Description = "3 Season Lightweight Backpacking Tent",
                    Category = "Tents",
                    Price = 79.99m
                },
                new Product
                {
                    Name = "Big Agnes Torchlight 20 Sleeping bag",
                    Description = "Down filled mummy sleeping bag",
                    Category = "Sleeping Bags",
                    Price = 299.95m
                },
                new Product
                {
                    Name = "Stanley Adventure Cookset Kit",
                    Description = "Portable Stainless steel cookset with nesting cups",
                    Category = "Cooking",
                    Price = 10
                },
                new Product
                {
                    Name = "Arcturus Military Wool Blanket",
                    Description = "Warm Thick Washable Blanket Large 64 x 88 inches",
                    Category = "Blankets",
                    Price = 40.95m
                },
                new Product
                {
                    Name = "LifeStraw Water Filter",
                    Description = "Filters up to 1,000 gallons of water",
                    Category = "Water Filters",
                    Price = 14.97m
                },
                new Product
                {
                    Name = "Nalgene Stainless Bottle",
                    Description = "Single Wall Stainless Steel 38oz Water Bottle",
                    Category = "Water Bottles",
                    Price = 29.90m
                });

                context.SaveChanges();
            }
        }
    }
}
