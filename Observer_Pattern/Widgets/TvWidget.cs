using Observer_Pattern.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Widgets
{
    class TvWidget : IObserver
    {
        private string _tv;

        public TvWidget(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Tv: {0}", _tv);
        }
    }
}
