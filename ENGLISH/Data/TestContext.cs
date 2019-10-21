﻿using ENGLISH.Models;
using Microsoft.EntityFrameworkCore;

namespace ENGLISH.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public DbSet<Test> Test { get; set; }
    }
}
