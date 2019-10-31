#include "stdafx.h"
#include <list>
using namespace std;

class Solution {
public:
    int LastRemaining_Solution(int n, int m)
    {
        if(n<1||m<1)
        {
            return -1;
        }
        unsigned int i=0;
        list<int> numbers;
        for(i=0;i<n;++i)
        {
            numbers.push_back(i);
        }
        list<int>::iterator current=numbers.begin();
        while(numbers.size()>1)
        {
            for(int i=1;i<m;++i)
            {
                current++;
                if(current==numbers.end())
                {
                    current=numbers.begin();
                }
            }
            list<int>::iterator next=++current;
            if(next==numbers.end())
            {
                next=numbers.begin();
            }
            --current;
            numbers.erase(current);
            current=next;
        }
        return *current;
    }

    //解法二 利用规律求解
    int LastRemaining_Solution2(int n, int m)
    {
        if(n<1||m<1)
        {
            return -1;
        }
        int last=0;
        for(size_t i = 2; i <= n; i++)
        {
            last=(last+m)%i;
        }
        return last;
    }
};