using BARAZAIS.Data.Database;
using BARAZAIS.Data.Models;
using BARAZAIS.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BARAZAIS.Data.Repos;

public class ProductPriceRepo : BaseRepo<ProductPrice> , IProductPrice
{
    public ProductPriceRepo(BarazaContext ctx) : base(ctx) { }
}
