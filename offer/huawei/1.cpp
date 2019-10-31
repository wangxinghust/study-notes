#include<iostream>
#include<vector>
#include<string>
#include<algorithm>

using namespace std;
int main(int argc, char** argv)
{
	int num;
	cin >> num;

	vector<string> vec_str;
	string str;

	for (int i = 0; i < num; i++)
	{
		cin >> str;
		if (!str.empty())
			vec_str.push_back(str);
	}
	sort(vec_str.begin(), vec_str.end());

	for (auto& s : vec_str)
	{
		while (double(s.size()) / 8.0 > 1.0)
		{
			cout << s.substr(0, 8) << " ";
			s.erase(0, 8);
		}
		if (s.size() != 8)
		{
			string str_(8 - s.size(), '0');
			s = s + str_;
		}
		cout << s << " ";
	}
	return 0;
}
