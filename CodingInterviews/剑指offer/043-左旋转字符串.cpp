#include "stdafx.h"
#include <string>
using namespace std;

class Solution {
public:
    string LeftRotateString(string str, int n) {
        int length=str.size();
        if(length==0||n<=0)
        {
            return str;
        }
        n%=length;
        //空间换时间
        str+=str;
        return str.substr(n,length);
    }
};