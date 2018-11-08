using Observer_Pattern.News;
using Observer_Pattern.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление новых наблюдателей (виджетов)
            var newsAggregator = new NewsAggregator();
            var twitterWidget = new TwitterWidget(newsAggregator); // регистрация во время создания объекта
            var lentaWidget = new LentaWidget(newsAggregator);
            var tvWidget = new TvWidget(newsAggregator);

            //вызов метода, производящего обновление новостей
            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
