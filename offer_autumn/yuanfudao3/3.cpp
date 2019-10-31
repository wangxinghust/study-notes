#include <iostream>
#include <vector>
#include <sstream>
#include <unordered_set>
using namespace std;

struct Ban {
	int techId;
	string banName;
	unordered_set<int> stu;
	double rate;// ³öÇÚÂÊ
	Ban(int _t, string _b) :techId(_t), banName(_b) {}
};

struct Record {
	bool cmd = true;
	int id;
	int time;
	Record(bool _c, int _i, int _t) :cmd(_c), id(_i), time(_t) {}
};

int main() {
	int N, M;
	cin >> N >> M;
	vector<Ban*> vBan;
	for (int i = 0; i < M; i++) {
		string line;
		getline(cin, line);
		stringstream ss(line);
		int num;
		int techId;
		string banName;
		vector<int> stu(num);
		ss >> num >> techId >> banName;
		Ban* b = new Ban(techId, banName);
		for (int j = 0; j < num; j++) {
			int stuId;
			ss >> stuId;
			b->stu.insert(stuId);
		}
		vBan.push_back(b);
	}
	vector<Record*> vRecord;
	for (int i = 0; i < N; i++) {
		bool cmd;
		int id, time;
		cin >> cmd >> id >> time;
		vRecord.push_back(new Record(cmd, id, time));
	}


	return 0;
}

// 0