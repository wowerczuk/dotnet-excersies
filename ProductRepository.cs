﻿using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Programowanie;

public class ProductRepository
{
   private readonly ProductDbContext _dbContext;

   public ProductRepository(ProductDbContext dbContext)
   {
    _dbContext = dbContext;
   }

   public void AddProduct(Product product)
   {
      _dbContext.Add(product);
   }
   
}
