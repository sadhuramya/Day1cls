using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvc_assignment.Models
{
    public class Moviesdb : DbContext
    {
        public Moviesdb() : base("name = Movies")
        {

        }
        public DbSet<Movies> movies { get; set; }
    }
}