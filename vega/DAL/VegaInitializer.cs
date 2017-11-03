using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using vega.Models;

namespace vega.DAL
{
    public static class VegaInitializer
    {
        public static void Initialize(VegaContext context) {
            context.Database.EnsureCreated();

            if(context.Makes.Any()) {
                return;
            }
        }
    }
}