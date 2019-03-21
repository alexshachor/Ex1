using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public SingleMission()
        {
            this.
        }

        string IMission.Name => throw new NotImplementedException();

        string IMission.Type => throw new NotImplementedException();

        event EventHandler<double> IMission.OnCalculate
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        double IMission.Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
