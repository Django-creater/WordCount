#include <stdio.h>
#include <string.h>
int main (int m, char *n[])
{
    
    int c=0; // ����ͳ�Ʊ��� 
    FILE *f;//�����ļ� 
    if (f=fopen(n[2], "r"))//�ж�ָ�� 
    {
        printf("��������ȷ��ָ��!\n");
    }
    if (n[1][1]=='c') // ͳ���ַ�
    {
        char ch;
        while ((ch = fgetc(f))!=EOF){
        	c++;
		}
        printf("�ַ���Ϊ%d", c);
    }
    else if (n[1][1] == 'w') // ͳ�Ƶ������� 
    {
        char s[10000];
        while (fscanf(f, "%s", s) != EOF)
        {
            c++;
        }
        printf("������Ϊ=%d\n", c);
    }
    fclose(f);
    return 0;
}

