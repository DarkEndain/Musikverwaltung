using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prototyp_Net_Framework.Data;


namespace Prototyp_Net_Framework.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            if (context.Interpreten.Any())
            {
                return;
            }

            
        }
    }
}
