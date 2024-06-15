using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace Programowanie;

public class CreateProductCommand 
{
    public CreateProductCommand(string name, bool isOrdered)
    {
        Name = name;
        IsOrdered = isOrdered;
    }
   public string Name { get; set; }
   public bool IsOrdered { get; set; }
}

public class CreateProductCommandHandler
{
private readonly ProductRepository _repository;

    public CreateProductCommandHandler(ProductRepository repository)
    {
        _repository = repository;
    }
     public void Handle(CreateProductCommand command)
     {
         var product = new Product()
         {
            Name = command.Name,
            IsOrdered = command.IsOrdered
         };
         _repository.AddProduct(product);
     }
     
}