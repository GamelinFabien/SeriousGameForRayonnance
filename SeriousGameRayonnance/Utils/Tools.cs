using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriousGameRayonnance.Utils
{
    //Class "tools" in this one I just make some code wich will help me on my program later
    class Tools
    {
        public List<string> ReadFile(string filename)
        {
            List<string> content = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    content.Add(sr.ReadToEnd());
                }
                return content;
            }
            catch(Exception e)
            {
                content.Add(e.Message);
                return content;
            }
        }
    }
}
