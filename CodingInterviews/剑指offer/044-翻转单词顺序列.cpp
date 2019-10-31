#include "stdafx.h"
#include <string>
using namespace std;

class Solution {
public:
    string ReverseSentence(string str) {
        if(str.empty())
        {
            return str;
        }
        ReverseWord(str,0,str.size()-1);
        int behind=0;
        int ahead=0;
        int i=0;
        while(i<str.size())
        {
            //跳过空格
            while(i<str.size()&&str[i]==' ')
            {
                ++i;
            }
            //记录单词的第一个字符的位置
            ahead=behind=i;
            while(i<str.size()&&str[i]!=' ')
            {
                i++;
                ahead++;
            }
            ReverseWord(str,behind,ahead-1);
        }
        return str;
    }
    void ReverseWord(string &str,int behind,int ahead)
    {
        while(behind<ahead)
        {
            swap(str[behind++],str[ahead--]);
        }
    }
};