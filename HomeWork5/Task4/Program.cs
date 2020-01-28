namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("mouse", "rosetka", 50);
            Article a2 = new Article("mouse2", "foxtrot", 150);
            Article a3 = new Article("keybord", "fotos", 200);
            Article a4 = new Article("monitor", "fotos", 200);

            Store store = new Store(a1, a2);
            store.AddArticleToStore(a3, a4);

            System.Console.WriteLine(store[4]);
            System.Console.WriteLine(store[2]);
            System.Console.WriteLine(store["mouse"]);
        }
    }
}
