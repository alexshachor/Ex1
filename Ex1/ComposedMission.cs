using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<Func<double, double>> funcList;
        private string name;
        private string type;

        public ComposedMission(string name)
        {
            this.name = name;
            this.type = "Composed";
            this.funcList = new List<Func<double, double>>();
        }

        public string Name => this.name;

        public string Type => this.type;

        public ComposedMission Add(Func<double, double> func)
        {
            this.funcList.Add(func);
            return this;
        }


        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result = 0, tempValue = value;
            foreach (Func<double, double> func in funcList)
            {
                tempValue = func(tempValue);
                result = tempValue;
            }
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(sender: this, e: result);
            }
            return result;
        }
    }
}
