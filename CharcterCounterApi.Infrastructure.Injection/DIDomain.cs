using CharacterCounterApi.Abstract;
using CharacterCounterApi.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CharcterCounterApi.Infrastructure.Injection
{
    public static class DIDomain
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ICounterEntity,CounterEntity>();
        }
    }
}
