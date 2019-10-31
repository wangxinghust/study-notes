#include "stdafx.h"
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> multiply(const vector<int>& A) {
        vector<int> res;
        if(A.empty())
        {
            return res;
        }
        int len=A.size();
        res.push_back(1);
        
        for(int i = 0; i < len-1; i++)
        {
            res.push_back(res.back()*A[i]);
        }
        int tmp=1;
        //size_t返回的是一个与机器相关的unsigned类型，其大小足以保证存储内存中对象的大小 这儿不能用unsigned，可能溢出
        for(int i = len-1; i >=0; i--)
        {
            res[i]=res[i]*tmp;
            tmp*=A[i];
        }
        return res;
    }
};