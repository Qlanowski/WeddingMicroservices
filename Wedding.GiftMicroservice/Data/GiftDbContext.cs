using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding.GiftMicroservice.Data.Model;

namespace Wedding.GiftMicroservice.Data
{
  public class GiftDbContext:DbContext
  {
    public GiftDbContext(DbContextOptions<GiftDbContext> options) : base(options)
    {
    }

    public DbSet<Gift> Gifts { get; set; }
  }
}
