#include <cstdio>
#include <cstring>
#include <algorithm>
#include <queue>

using namespace std;

//int minPath(vector<vector<char> > &position,int x,int y,int m,int n) {
//	if (x == m, y == n) {
//		return 0;
//	}
//	if (x >= 0 && x < n && y >= 0 && y < n && (position[x][y] == '.' || position[x][y] == '@')) {
//		return 1 + min(min(minPath(position, x + 1, y, m, n), minPath(position, x - 1, y, m, n)), min(minPath(position, x, y + 1, m, n), minPath(position, x, y - 1, m, n)));
//	}
//	else
//	{
//		return position.size()* position[0].size();
//	}
//}
//
//int main() {
//	int n;
//	cin >> n;
//	vector<vector<char> > position;
//	vector<vector<int> > in;
//	int outM, outN;
//	for (int i = 0; i < n; i++) {
//		
//
//
//
//
//		vector<char> row(n);
//		for (int j = 0; j < n; j++) {
//			cin >> row[j];
//			if (row[j] == '@') {
//				in.push_back(vector<int>{i, j});
//			}
//			else if (row[j] == '*') {
//				outM = i;
//				outN = j;
//			}
//		}
//		position.push_back(row);
//	}
//	int minLen = minPath(position, in[0][0], in[0][1], outM, outN);
//	for (int i = 1; i < in.size(); i++) {
//		minLen = min(minLen, minPath(position, in[i][0], in[i][1], outM, outN));
//	}
//	cout << minLen << endl;
//	return 0;
//}

//10
//.@....##@.
//......#...
//...@..#...
//###.......
//....##..#.
//...####...
//@...##....
//#####.....
//..##*####.
//#.........

// bfs 假设一个超级入口，连接所有接口，用bfs解的时候，可以把入口全部放入队列里

const int maxn = 1e3 + 5;
const int dx[] = { 0,1,0,-1 };
const int dy[] = { -1,0,1,0 };

struct node {
	int x, y;
	node(int _x,int _y):x(_x),y(_y){}
};

int n, m;
int dis[maxn][maxn];
char mp[maxn][maxn];

node a, ed;

int main() {
	memset(mp, 0, sizeof(mp));
	memset(dis, -1, sizeof(dis));
	queue<node> q;
	scanf("%d%d", &n, &m);
	for (int i = 0; i < n; i++) {
		scanf("%s", mp[i]);
	}
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (mp[i][j] == '@') {
				a.x = i;
				a.y = j;
				q.push(a);// 这三行代码没有改变存入队列q里的node的值，也是相当神奇，对全局变量进行更改
				dis[i][j] = 0;
			}
			else if (mp[i][j] == '*') {
				ed.x = i;
				ed.y = j;
			}
		}
	}
	while (!q.empty()) {
		node p = q.front();
		q.pop();
		for (int i = 0; i < 4; i++) {
			int px = p.x + dx[i];
			int py = p.y + dy[i];
			if (px >= 0 && px < n && py >= 0 && py < n && dis[px][py] == -1 && mp[px][py] != '#') {
				node pp(px, py);
				q.push(pp);
				dis[px][py] = dis[p.x][p.y] + 1;
				if (px == ed.x && py == ed.y)
					break;
			}
		}
		if (dis[ed.x][ed.y] != -1) break;// 跳出双层，写两次判断
	}
	printf("%d\n", dis[ed.x][ed.y]);
	return 0;
}