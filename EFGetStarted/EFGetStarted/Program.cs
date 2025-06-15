// See https://aka.ms/new-console-template for more information
using EFGetStarted;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

 using var db = new BloggingContext();
// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");
// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
await db.SaveChangesAsync();

Console.WriteLine("Hello, World!");
