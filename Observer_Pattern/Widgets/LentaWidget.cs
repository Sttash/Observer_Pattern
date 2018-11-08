using Observer_Pattern.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Widgets
{
    class LentaWidget : IObserver // реализация интерфейса наблюдателя
    {
        private string _lenta;

        public LentaWidget(ISubject subject)
        {
            subject.RegisterObserver(this); // в конструкторе виджет регистрирует сам себя через субъект
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _lenta = lenta; // используется только нужная переменная
            Display();
        }

        public void Display()   // выводится рандомная новость из одного источника
        {
            Console.WriteLine("Lenta: {0}", _lenta); 
        }
    }
}
