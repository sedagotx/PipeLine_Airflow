using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace DataLibrary;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterDataServices(this IServiceCollection services , IConfiguration configuration) 
    {
        services.AddDbContext<PiplineAirflowContext>(o => o.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}
