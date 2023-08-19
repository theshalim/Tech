using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Areas.HrAddress.Models;
using Tech.Models;
//using Tech.Models.ImageImplementation;

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
        public virtual DbSet<BookInfo> BookInfos { get; set; }
        public virtual DbSet<AuthorInfo> AuthorInfos { get; set; }
        public virtual DbSet<HrDivision> HrDivisions { get; set; }
        public virtual DbSet<HrDistrict> HrDistricts { get; set; }
        public virtual DbSet<HrThana> HrThanas { get; set; }
        public virtual DbSet<EmpInfo> EmpInfos { get; set; }
    }
    

}
