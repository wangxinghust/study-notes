#include "stdafx.h"
#include <vector>
#include <deque>
using namespace std;

class Solution {
public:
    vector<int> maxInWindows(const vector<int>& num, unsigned int size)
    {
		vector<int> res;
		deque<int> s;
		for (unsigned int i = 0; i < num.size(); ++i) {
			//clear the deque until s.back()>num[i]
			while (s.size() && num[s.back()] <= num[i]) s.pop_back();
			//if not in the sliding window,then pop
			while (s.size() && i - s.front() + 1 > size) s.pop_front();
			//press in the current index
			s.push_back(i);
			//when i+1>=size, push the value in vector<int> res
			if (size && i + 1 >= size) res.push_back(num[s.front()]);
		}
		return res;
    }
};