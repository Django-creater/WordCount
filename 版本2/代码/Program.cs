using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace WordCount
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string[] cmds = args;
            string theWord = "";
            int ope1 = 0,ope2 = 0,ope3 = 0;
            for(int i =0; i<args.Length;i++)
            Console.WriteLine(args[i]);

            //新建对象读取命令
            CommandRead cmd = new CommandRead();
            cmd.CommandImport(cmds);

            if (cmd.IsRows==true)
            {
                Rows rows = new Rows();
                ope1 = rows.Line(cmd.Path[0]);
                Console.WriteLine("Total Line:{0}", ope1);
                theWord += string.Format("Total Line:{0}\r\n", ope1);
            }
            if (cmd.IsChara==true)
            {
                Character ch = new Character();
                ope2 = ch.TotalWord(cmd.Path[0]);
                Console.WriteLine("Total Character:{0}", ope2);
                theWord += string.Format("Total Character:{0}\r\n", ope2);
            }
            if (cmd.IsWord==true)
            {
                Word word = new Word();
                ope2 = word.TotalWord(cmd.Path[0]);
                Console.WriteLine("Total Word:{0}", ope3);
                theWord += string.Format("Total Word:{0}\r\n", ope3);
            }
            /*
                        theWord += string.Format(args[1]);//存取文件名

                        if (args.Length > 2)//读取参数并赋值
                            Console.WriteLine("error");
                        else
                        {
                            wordRead.ope = args[0];//读取操作符如-w ，传给对象

                            for(ctr = 0; ctr < args.Length; ctr++)
                            {
                                theWord += string.Format("参数{0}为：{1}", ctr + 1, args[ctr]);
                                Console.WriteLine("参数{0} 为：{1}",ctr + 1, args[ctr]);//读取参数
                            }
                        }

                        Operand = wordRead.LoadWord();

                        if(Operand == 1)//当用户选择读取总行数
                        {
                            Rows rows = new Rows();
                            ope1 = rows.Line(args[1]);
                            theWord += string.Format("Total Line:{0}", ope1);
                        }
                        else if(Operand == 2)//当用户选择读取总单词数
                        {
                            Word word = new Word();
                            ope2 = word.TotalWord(args[1]);
                            theWord += string.Format("Total Word:{0}", ope2);
                        }
                        else if(Operand == 3)////当用户选择读取总字符数
                        {
                            Character character = new Character();
                            ope3 = character.TotalWord(args[1]);
                            theWord += string.Format("Total character:{0}", ope3);
                        }
                        else
                        {
                            Console.WriteLine("error!");
                        }
            */
            //将结果写入txt
            WriteFile write = new WriteFile();
            if (cmd.IsAimPath)
            {
                write.Write(cmd.Path[1], theWord);
            }
            if(cmd.IsAimPath == false)
            {
                write.Write(theWord);
            }

        }
    }
}
