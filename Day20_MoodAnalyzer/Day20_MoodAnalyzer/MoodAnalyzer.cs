using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class MoodAnalyzer
    {
        
        public string AnalyzeMood(string message)
        {
            if (this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
