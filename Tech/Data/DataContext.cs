﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;

namespace Tech.Data
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<ProductUnit> productUnits { get; set; }
        public virtual DbSet<Color> colors { get; set; }
        public virtual DbSet<PriceRange> priceRanges { get; set; }
        public virtual DbSet<ProductionYear> productionYears { get; set; }
        public virtual DbSet<ManufracturingAddress> manufracturingAddresses { get; set; }
    }
    

}
