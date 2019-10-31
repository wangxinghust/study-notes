#include "stdafx.h"
using namespace std;

class Solution {
public:
    int Sum_Solution(int n) {
        int ans = n;
        //逻辑与的短路特性 前面为假，后面不计算
        ans && (ans += Sum_Solution(n - 1));
        return ans;
    }
};