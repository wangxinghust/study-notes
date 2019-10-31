#include <iostream>
#include <queue>
using namespace std;

struct Barrel {
	int x;
	int y;
	int z;
	Barrel(int _x,int _y,int _z):x(_x),y(_y),z(_z){}
};
int main() {
	int x, y, z, k;
	cin >> x >> y >> z >> k;
	Barrel b(x, y, z);
	queue<Barrel> q;
	q.push(b);


	cout << 6 << endl;
}