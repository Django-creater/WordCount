#include <stdio.h>
#include <string.h>
int main (int m, char *n[])
{
    
    int c=0; // 定义统计变量 
    FILE *f;//定义文件 
    if (f=fopen(n[2], "r"))//判断指令 
    {
        printf("请输入正确的指令!\n");
    }
    if (n[1][1]=='c') // 统计字符
    {
        char ch;
        while ((ch = fgetc(f))!=EOF){
        	c++;
		}
        printf("字符数为%d", c);
    }
    else if (n[1][1] == 'w') // 统计单词数量 
    {
        char s[10000];
        while (fscanf(f, "%s", s) != EOF)
        {
            c++;
        }
        printf("单词数为=%d\n", c);
    }
    fclose(f);
    return 0;
}

