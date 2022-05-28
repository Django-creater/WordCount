using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace WordCount
{
    class Rows //行数
    {
        public string ope;

        public int Line(string filename)
        {
            Encoding encod = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encod);

            string line;
            int CountLine = 0;//记录行数

            //当前行不为空
            while((line = sr.ReadLine()) != null)
            {
                CountLine++;
            }

            //应该先关闭文件再return
            sr.Close();
            fs.Close();

            return CountLine;//注意函数是有返回值的
        }
    }
}
