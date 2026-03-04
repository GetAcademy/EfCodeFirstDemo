using EfCodeFirstDemo.Data;
using Microsoft.EntityFrameworkCore;

var context = new SchoolContext();
context.Database.Migrate();
DataSeeder.Seed(context);

var recent = context.Enrollments
    .Where(e => e.StartDate >= new DateTime(2024, 2, 1))
    .OrderByDescending(e => e.StartDate)
    .Take(5)
    .ToList();