namespace Catalog.Core.Domain
{
    public class Product
    {
        public Guid Id { get; protected set; }

        public int Code { get; protected set; }

        public string Name { get; protected set; }

        public double Price { get; protected set; }
        
        private Product(int code, string name, double price)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            Price = price;
        }
        
        public static Product Create(int code, string name, double price)
            => new(code, name, price);
    }
}