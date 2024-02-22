namespace Catalog.Infrasctructure.Products
{
    public class CreateProduct : ICommand
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
