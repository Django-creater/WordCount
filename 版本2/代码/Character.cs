using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WordCount
{
    class Character//字符
    {
        public string ope;

        public int TotalWord(string filename)
        {
            Encoding encod = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encod);

            int charcount = 0;
            int nchar;

            while((nchar = sr.Read())!= -1) //sr.Read()是以特定的编码方式读取流而获取一个接一个的字符，而ReadLine()是读取一行
            {
                charcount++; // 统计字符数
            }

            //关闭文件
            sr.Close();
            fs.Close();

            return charcount;
        }
    }
}
