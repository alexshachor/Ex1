using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /// <summary>
    /// This class is responsible for handling a single mission and calculates its result
    /// </summary>
    public class SingleMission : IMission
    {
        private Func<double, double> func;
        private string name;
        private string type;

        public SingleMission(Func<double, double> func, string name)
        {
            this.func = func;
            this.name = name;
            this.type = "Single";
        }

        public string Name => this.name;

        public string Type => this.type;


        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result = this.func(value);
            if (OnCalculate != null)
            {
                //notify the subscriber for the result 
                OnCalculate.Invoke(sender: this, e: result);
            }
            return result;
        }
    }
}
