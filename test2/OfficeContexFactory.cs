﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace test2
{
    public class OfficeContexFactory : IDesignTimeDbContextFactory<OfficeContex>
    {
        public OfficeContex CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OfficeContex>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7GGELFU\\SQLEXPRESS;Initial Catalog=Out_of_Office;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            return new OfficeContex(optionsBuilder.Options);
        }

    }
}