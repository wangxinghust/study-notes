#include "stdafx.h"
#include <queue>
using namespace std;

class Solution {
private:
    priority_queue<int,vector<int>,less<int> > p;
    priority_queue<int,vector<int>,greater<int> >q;
public:
    void Insert(int num)
    {
        //p store the lesser
        if(p.empty()||num<=p.top())
        {
            p.push(num);
        }
        //q store the greater
        else
        {
            q.push(num);
        }
        //adjust the two priority_queue,thus q.size()<=p.size()<=q.size()+1
        if(p.size()==q.size()+2)
        {
            q.push(p.top());
            p.pop();
        }
        if(p.size()+1==q.size())
        {
            p.push(q.top());
            q.pop();
        }
    }

    double GetMedian()
    { 
        return p.size()==q.size()?(p.top()+q.top())/2.0:p.top();
    }

};