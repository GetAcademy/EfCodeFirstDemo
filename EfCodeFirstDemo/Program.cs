using EfCodeFirstDemo.Data;
using Microsoft.EntityFrameworkCore;

var context = new SchoolContext();
context.Database.Migrate();
DataSeeder.Seed(context);