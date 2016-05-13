using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
   public interface IObserver
    {
        //void Update(Object data);
        void Update(double nouvelleTemperature);
    }
}
