using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Word//单词
    {
        public int TotalWord(string filename)
        {
            Encoding encod = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encod);

            int nchar;
            int WordCount = 0;
            char[] symbol = { ' ', '\t', ',', '.', '?', '!', ':', ';', '\'', '\"', '\n', '{', '}', '(', ')', '+', '-', '*', '=' };//间隔符
            while((nchar = sr.Read())!= -1)
            {
                foreach(char c in symbol)
                {
                    if(nchar == (int)c)
                    {
                        WordCount++;
                    }
                }
            }

            sr.Close();
            fs.Close();

            return WordCount;
        }
    }
}
