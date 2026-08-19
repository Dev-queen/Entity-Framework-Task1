using DotNet_Template1.Models;

namespace DotNet_Template1.Repistories.Interfaces
{
    public interface IProductRepistory
    {
        public Product CreateProduct(Product product);
        public IEnumerable<Product> GetAll();

    }
}
