﻿using SimApi.Data.Context;
using SimApi.Data;

namespace SimApi.Data.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(SimDbContext context) : base(context)
    {

    }
}
