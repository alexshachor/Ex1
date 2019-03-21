using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /// <summary>
    /// This class manages a functions dictionary which can be accessed through indexer.
    /// </summary>
    public class FunctionsContainer
    {
        private Dictionary<string, Func<double, double>> funcDictionary;
        
        public FunctionsContainer()
        {
            funcDictionary = new Dictionary<string, Func<double, double>>();
        }
        /// <summary>
        /// Indexer implementation
        /// </summary>
        /// <param name="key">the function name</param>
        /// <returns>function whose form is Func<double, double></returns>
        public Func<double, double> this[string key]
        {
            get
            {
                if (!funcDictionary.ContainsKey(key))
                {
                    //the Stam function
                    funcDictionary[key] = (param => param);
                }
                return funcDictionary[key];
            }
            set
            {
                funcDictionary[key] = value;
            }
        }

        public IEnumerable<string> getAllMissions()
        {
            return new List<string>(funcDictionary.Keys);
        }
    }
}
