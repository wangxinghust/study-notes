#include "stdafx.h"
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> FindNumbersWithSum(vector<int> array,int sum) {
        vector<int> res;
        if(array.size()<2)
        {
            return res;
        }
        int ahead=array.size()-1;
        int behind=0;
        while(ahead>behind)
        {
            if(array[ahead]+array[behind]==sum)
            {
                res.push_back(array[behind]);
                res.push_back(array[ahead]);
                return res;
            }
            else if(array[ahead]+array[behind]>sum)
            {
                ahead--;
            }
            else
            {
                behind++;
            }
        }
        return res;
    }
};