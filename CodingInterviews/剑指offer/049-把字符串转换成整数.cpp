#include "stdafx.h"
#include <string>
using namespace std;

//解法存疑 如果字符串中间出现了+-符号，并无响应的处理
//仍需考虑溢出 最大正整数0x7FFFFFFF，最小负整数0x80000000
class Solution {
public:
    enum Status {kValid=0,kInvalid};
    int g_nStatus=kValid;
    int StrToInt(string str) {
        g_nStatus=kInvalid;
        int num=0;
        if(str.size()!=0)
        {
            bool minus=false;
            for(size_t i = 0; i < str.size(); i++)
            {
                if(str[i]=='+')
                {
                    continue;
                }
                else if(str[i]=='-')
                {
                    minus=true;
                    continue;
                }
                else if(str[i]>='0'&&str[i]<='9')
                {
                    num=num*10+(str[i]-'0');
                }
                else
                {
                    num=0;
                    break;
                }
            }
            g_nStatus=kValid;
            if(minus)
            {
                num=-num;
            }
        }
        return num;
    }
};