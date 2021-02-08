using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    { 
        static void Main()
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            Anwendungscontroller controller = new Anwendungscontroller(view, model);

            controller.Ausfuehren();
        }
    }
}
