using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    public interface Season
    {
        void Attach(Obs observer);
        void Detach(Obs observer);
        string Notify(InformNotify In);
    }

    public class Information: Season
    {
        List<Obs> ob;
        public Information()
        {
            ob = new List<Obs>();
        }

        public void Attach(Obs obs)
        {
            ob.Add(obs);
        }

        public void Detach(Obs obs)
        {
            ob.Remove(obs);
        }

        public string Notify(InformNotify In)
        {
            foreach (Obs o in ob)
            {
                if (o.Update(In) != null)
                    return o.Update(In);
            }
            return "";
        }
    }

    public class InformNotify
    {
        public int f;
        public int d;
        public int t;

        public InformNotify()
        {
            f = 0;
            d = 0;
            t = 0;
        }

        public InformNotify(int f, int t, int d)
        {
            this.f = f;
            this.d = d;
            this.t = t;
        }
    }
}
