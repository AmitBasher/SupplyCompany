using SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;
using SupplyCompany.Infrastructure.DAL.Repository;

namespace SupplyCompany.Application.Products.Commands.Create;
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product> {
    private readonly IProductRepository _productRepository;
    public CreateProductCommandHandler(IProductRepository productRepository){
            _productRepository = productRepository;
    }
    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken) {
        SupplierId SID;
        var entity = Product.Create(
            SID=SupplierId.CreateFrom(request.SupplierId),
            request.Name,
            request.Description,
            request.SubProducts.ConvertAll(sp => SubProduct.Create(
                SID,
                sp.SubTitle,
                sp.price,
                sp.SupplyAvailability,
                sp.Attributes.ConvertAll(at => ProductAttribute.Create(
                    at.Title,
                    at.Value)
                    )
                )
            )
        );
        await _productRepository.AddProduct(entity);
        return entity;
    }
}
