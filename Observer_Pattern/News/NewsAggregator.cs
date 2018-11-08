using Observer_Pattern.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.News
{
    public class NewsAggregator : ISubject
    {
        private static Random _random; // рандомизатор (объявление)
        private List<IObserver> _observers; // коллекция типа List для хранения наблюдателей

        public NewsAggregator()
        {
            // инициализация
            _random = new Random();
            _observers = new List<IObserver>(); 
        }

        public void RegisterObserver(IObserver observer) // добавление нового наблюдателя в список
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) // удаление налблюдателя из списка
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()   // "оповещение": сбор новостей из методов, выдающих случайную новость
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            foreach (var observer in _observers) // и передача этих самых новостей в метод Update каждого наблюдателя
            {
                observer.Update(twitter, lenta, tv);
            }
        }

        public string GetTwitterNews()  // содержит список новостей, возвращает случайную
        {
            var news = new List<string>
            {
                "Новость из Twitter номер 1",
                "Новость из Twitter номер 2",
                "Новость из Twitter номер 3"
            };
            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
            {
                "Новость из Lenta номер 1",
                "Новость из Lenta номер 2",
                "Новость из Lenta номер 3"
            };
            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
            {
                "Новость из Tv номер 1",
                "Новость из Tv номер 2",
                "Новость из Tv номер 3"
            };
            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            NotifyObservers();
        }
    }
}
