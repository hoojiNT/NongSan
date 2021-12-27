using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Domain.Generator
{
    public class IdGenerator : ValueGenerator<string>
    {
        private readonly ShopDbContext _shopDbContext;
        private readonly string _prefix;
        public override bool GeneratesTemporaryValues => false;

        IdGenerator(string prefix)
        {
            _shopDbContext = new ShopDbContext();
            _prefix = prefix;
        }
        public override string Next([NotNullAttribute] EntityEntry entry)
        {
            var lasVal = _shopDbContext.Entry(entry).Property("Id").CurrentValue;
            //Console.WriteLine(lasVal.);
            var a = _shopDbContext;
            return new Guid().ToString();
        }
    }
}
