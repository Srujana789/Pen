using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pen.Data;
using System;
using System.Linq;

namespace Pen.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PenContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<PenContext>>()))
        {
            // Look for any movies.
            if (context.Pens.Any())
            {
                return;   // DB has been seeded
            }
            context.Pens.AddRange(
                new Pens
                {
                    Name = "Seiko",
                    Year = DateTime.Parse("1989-2-12"),
                    InkType = "Water",
                    Color = "Blue",
                    Price = 230
                },
                new Pens
                {
                    Name = "Pheonix",
                    Year = DateTime.Parse("1989-2-23"),
                    InkType = "Gel",
                    Color = "Black",
                    Price = 299
                },
                new Pens
                {
                    Name = "Astra",
                    Year = DateTime.Parse("2000-2-07"),
                    InkType = "Oil",
                    Color = "Green",
                    Price = 799
                },
                new Pens
                {
                    Name = "Monster",
                    Year = DateTime.Parse("2021-2-23"),
                    InkType = "Water",
                    Color = "Red",
                    Price = 400
                },
                new Pens
                {
                    Name = "Kidzee",
                    Year = DateTime.Parse("2024-5-22"),
                    InkType = "Gel",
                    Color = "Black",
                    Price = 400
                }
            );
            context.SaveChanges();
        }
    }
}