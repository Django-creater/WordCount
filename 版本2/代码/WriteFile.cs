using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WriteFile
    {
        public void Write(string theword)
        {
            FileStream fs = new FileStream("outputfile.txt", FileMode.Create);
            //获得字节数
            byte[] data = System.Text.Encoding.Default.GetBytes(theword);

            //写入
            fs.Write(data, 0, data.Length);
            //清空缓存区，关闭流
            fs.Flush();
            fs.Close();
        }

        public void Write(string path,string theword)
        {
            bool isInFile = false;
            String rootPath = Directory.GetCurrentDirectory();
            DirectoryInfo root = new DirectoryInfo(rootPath);
            foreach(FileInfo f in root.GetFiles())
            {
                if(path == f.Name)
                {
                    isInFile = true;
                }
            }
            if (isInFile != false)
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                //获得字节数
                byte[] data = System.Text.Encoding.Default.GetBytes(theword);

                //写入
                fs.Write(data, 0, data.Length);
                //清空缓存区，关闭流
                fs.Flush();
                fs.Close();
            }
            else
            {
                Console.WriteLine("Path Error!");
            }
        }
    }
}
