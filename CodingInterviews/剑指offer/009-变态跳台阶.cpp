#include "stdafx.h"
#include <math.h>
using namespace std;

class Solution {
public:
	int jumpFloor(int number) {
		return static_cast<int>(pow(2.0, number-1));
	}
};