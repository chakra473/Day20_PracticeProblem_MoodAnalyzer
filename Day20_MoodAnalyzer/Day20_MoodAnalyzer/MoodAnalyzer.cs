using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
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
            catch
            {
                return "HAPPY";
            }
        }
    }
}
