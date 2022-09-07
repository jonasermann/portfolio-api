﻿using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;
using System.ComponentModel;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace PortfolioApi.Data;

public class PortfolioAppContext : DbContext
{
    public PortfolioAppContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<HomeContent>? HomeContent { get; set; }
    public DbSet<HomeHistory>? HomeHistory { get; set; }
    public DbSet<HomeLinks>? HomeLinks { get; set; }
    public DbSet<Project>? Projects { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<PortfolioImage> PortfolioImages { get; set; }

}