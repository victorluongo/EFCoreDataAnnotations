using System;
using EFCoreQuerys.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            using var _context = new ApplicationContext();

            _context.Database.EnsureDeleted();

            _context.Database.EnsureCreated();
        }
    }
}
