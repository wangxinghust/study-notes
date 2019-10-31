#include "stdafx.h"
#include <algorithm>
#include <vector>
using namespace std;

class Solution {
public:
    bool IsContinuous( vector<int> numbers ) {
        if(numbers.empty())
        {
            return false;
        }
        sort(numbers.begin(),numbers.end());
        int pokerNumber=0;
        for(size_t i = 0; i < numbers.size()&&numbers[i]==0; i++)
        {
            ++pokerNumber;
        }
        int gapNumber=0;
        for(size_t i = pokerNumber+1; i < numbers.size(); i++)
        {
            if(numbers[i]<=numbers[pokerNumber])
            {
                return false;
            }
            gapNumber+=numbers[i]-numbers[i-1]-1;
        }
        return (gapNumber<=pokerNumber)?true:false;
    }
};