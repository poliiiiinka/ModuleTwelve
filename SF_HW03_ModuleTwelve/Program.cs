namespace SF_HW03_ModuleTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Name = "Владислав",
                Login = "mr.vlad",
                Subscription = false
            };

            User user2 = new User()
            {
                Name = "Кирилл",
                Login = "abramov.k",
                Subscription = true
            };

            // добавляем пользователей в список
            var Users = new List<User>() { user1, user2 };

            foreach (var user in Users)
            {
                Console.WriteLine($"Здравствуйте, {user.Name}!");
                if (user.Subscription != true)
                    ShowAds();
                Console.WriteLine();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
