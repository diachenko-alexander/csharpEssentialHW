namespace Task4
{
    class Article
    {
        private string name;
        private string shop;
        private double price;

        public string Name { get { return name; } }
        public string Shop { get { return shop; } }
        public double Price { get { return price; } }

        public Article(string name, string shop, double price)
        {
            this.name = name;
            this.shop = shop;
            this.price = price;
        }

        public string ShowArticleInfo()
        {
            return string.Format($"Name: {Name} Shop: {Shop} Price: {Price}");
        }
    }
}
