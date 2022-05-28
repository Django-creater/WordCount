using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class CommandRead
    {
        bool isRows = false;
        bool isChara = false;
        bool isWord = false;
        bool isAimPath = false;
        string[] path = new string[4];
        string[] commands;

        public bool IsRows
        {
            get { return isRows; }
        }
        public bool IsChara
        {
            get { return isChara; }
        }
        public bool IsWord
        {
            get { return isWord; }
        }
        public bool IsAimPath
        {
            get { return isAimPath; }
        }

        public string[] Path
        {
            get { return path; }
        }



        public void CommandImport(string[] args)
        {
            commands = args;
            if(commands == null)
            {
                Console.WriteLine("请输入指令");
            }
            else
            {
                int Pas = 0;

                for (int i = 0; i < commands.Length; i++)
                {
                    if (commands[i] == "-l" || commands[i] == "-L")//行数
                    {
                        isRows = true;
                    }
                    else if (commands[i] == "-w" || commands[i] == "-W")//单词
                    {
                        isWord = true;
                    }
                    else if (commands[i] == "-c" || commands[i] == "-C")//字符
                    {
                        isChara = true;
                    }
                    else if (commands[i] == "-o" || commands[i] == "-O")//输出
                    {
                        if (i + 2 == commands.Length)
                            isAimPath = true;
                    }
                    else
                    {
                        path[Pas] = commands[i];
                        Pas++;
                    }
                }

               

            }
        }



    }
}
