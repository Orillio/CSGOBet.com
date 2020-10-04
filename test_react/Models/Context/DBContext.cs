using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOBet.Models.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
