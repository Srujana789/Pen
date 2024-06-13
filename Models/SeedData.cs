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
                    Name = "Astra",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Blue",
                    Material = "Plastic",
                    Retractable = "Yes",
                    Price = 400
                },
                new Pens
                {
                    Name = "Kidzee",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 400
                },
                new Pens
                {
                    Name = "Phoenix",
                    InkType = "Water",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Silicon",
                    Retractable = "Yes",
                    Price = 799
                },
                new Pens
                {
                    Name = "Monster",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 400
                },
                new Pens
                {
                    Name = "Easybee",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),
                    
                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 400
                }
            );
            context.SaveChanges();
        }
    }
}