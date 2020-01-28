using System;

namespace Task4
{
    class Store
    {
        Article[] articles;

        public Store()
        {
            articles = new Article[1];
        }

        public Store(params Article[] array)
        {
            articles = new Article[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                articles[i] = array[i];
                Console.WriteLine($"Article {array[i].Name} added to store");
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < articles.Length)
                {
                    return articles[index].ShowArticleInfo();
                }
                return "No such article";
            }

        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name == index)
                    {
                        return articles[i].ShowArticleInfo();
                    }
                }
                return "No such article";
            }
        }

        public void AddArticleToStore(params Article[] array)
        {
            Article[] newArticles = new Article[articles.Length + array.Length];
            articles.CopyTo(newArticles, 0);

            for (int i = articles.Length, j = 0; i < newArticles.Length; i++, j++)
            {
                newArticles[i] = array[j];
                Console.WriteLine($"Article {array[j].Name} added to store");
            }

            articles = newArticles;
        }


    }
}
