using Observer_Pattern.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Widgets
{
    class TwitterWidget : IObserver
    {
        private string _twitter;

        public TwitterWidget(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
