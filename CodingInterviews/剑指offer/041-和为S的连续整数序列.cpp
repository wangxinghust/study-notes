#include "stdafx.h"
#include <vector>
using namespace std;

//小明很喜欢数学,有一天他在做数学作业时,要求计算出9~16的和,他马上就写出了正确答案是100。但是他并不满足于此,他在想究竟有多少种连续的正数序列的和为100(至少包括两个数)。没多久,他就得到另一组连续正数和为100的序列:18,19,20,21,22。现在把问题交给你,你能不能也很快的找出所有和为S的连续正数序列? Good Luck!
class Solution {
public:
    vector<vector<int> > FindContinuousSequence(int sum) {
        vector<vector<int> > res;        
        if(sum<3)
        {
            return res;
        }
        int small=1;
        int big=2;
        int middle=(1+sum)/2;
        int curSum=small+big;
        while(small<middle)
        {
            if(curSum==sum)
            {
                res.push_back(ContinuousSequence(small,big));
            }
            while(curSum>sum&&small<middle)
            {
                curSum-=small;
                ++small;
                if(curSum==sum)
                {
                    res.push_back(ContinuousSequence(small,big));
                }
            }
            ++big;
            curSum+=big;
        }
        return res;
    }
    vector<int> ContinuousSequence(int small,int big)
    {
        vector<int> res;
        while(small<=big)
        {
            res.push_back(small);
            ++small;
        }
        return res;
    }
};