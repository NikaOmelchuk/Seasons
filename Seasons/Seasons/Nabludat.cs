using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    public interface Obs
    {
        string Update(InformNotify In);
    }

    public class LetoObs: Obs
    {
        public string Update(InformNotify In)
        {
            if (In.f == 6 && In.t == 7 && In.d == 8)
                return "Я заметил лето";
            else
                return null;
        }
    }

    public class ZymaObs : Obs
    {
        public string Update(InformNotify In)
        {
            if (In.f == 3 && In.t == 4 && In.d == 5)
                return "Я заметил зиму";
            else
                return null;
        }
    }

    public class VesnaObs : Obs
    {
        public string Update(InformNotify In)
        {
            if (In.f == 0 && In.t == 1 && In.d == 2)
                return "Я заметил весну";
            else
                return null;
        }
    }

    public class OsenObs : Obs
    {
        public string Update(InformNotify In)
        {
            if (In.f == 9 && In.t == 10 && In.d == 11)
                return "Я заметил осень";
            else
                return null;
        }
    }
}
