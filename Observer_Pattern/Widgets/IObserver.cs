using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Widgets
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string tv);
        void Display();
    }
}
