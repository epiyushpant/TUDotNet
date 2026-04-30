namespace BlazorTU.Model
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>();

        public IEnumerable<Product> GetProducts() => products;

        public void AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
                products.Remove(product);
        }
    }
}
