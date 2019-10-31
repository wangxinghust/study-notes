#include <vector>
#include <iostream>
using namespace std;


char oneDigitalEmotion(int num)
{
	bool hasDivide = false;
	int tmp = num;
	while (tmp != 0)
	{
		int remainder = tmp % 10;
		if (remainder == 0 || num % remainder == 0)
		{
			hasDivide = true;
		}
		else if (!hasDivide)
		{
			return 'S';
		}
		else
		{
			return 'H';
		}
		tmp /= 10;
	}
	return 'G';
}
vector<char> digitalEmotion(int size, vector<int> numbers)
{
	vector<char> ans;
	if (size <= 0)
	{
		return ans;
	}

	for (int i = 0; i < size; ++i)
	{
		char ch = oneDigitalEmotion(numbers[i]);
		ans.push_back(ch);
	}
	return ans;
}
int main()
{
	int size;
	cin >> size;
	vector<int> numbers;
	for (int i = 0; i < size; ++i)
	{
		int num;
		cin >> num;
		numbers.push_back(num);
	}
	vector<char> ans;
	ans = digitalEmotion(size, numbers);
	for (int i = 0; i < size; ++i)
	{
		cout << ans[i] << endl;
	}
	return 0;
}