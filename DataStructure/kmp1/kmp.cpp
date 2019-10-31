#include <cstring>
using namespace std;

// ����ƥ��
int violenMatch(char* s, char* p) {
	int sLen = strlen(s);
	int pLen = strlen(p);

	int i = 0;
	int j = 0;
	while (i < sLen && j < pLen) {
		if (s[i] == s[j]) {
			++i;
			++j;
		}
		else {
			i = i - j + 1;
			j = 0;
		}
	}
	if (j == pLen) {
		return i - j;
	}
	else
		return -1;
}

int next[50];// ���������define, �����ó������

// kmpƥ��
int KmpSearch(char* s, char* p) {
	int i = 0;
	int j = 0;
	int sLen = strlen(s);
	int pLen = strlen(p);
	while (i < sLen && j < pLen) {
		// ���j=-1�����ߵ�ǰ�ַ�ƥ��ɹ�����s[i]==p[j])������i++,j++
		if (j == -1 || s[i] == s[j]) {
			++i;
			++j;
		}
		else {
			// ��� j!=-1���ҵ�ǰ�ַ�ƥ��ʧ�ܣ���s[i]!=p[j])������i���䣬j=next[j]
			j = next[j];
		}
	}
	if (j == pLen) {
		return i - j;
	}
	else
		return -1;
}

// ��next����
void GetNext(char* p, int next[]) {
	int pLen = strlen(p);
	next[0] = -1;
	int k = -1;
	int j = 0;
	while (j < pLen - 1) {
		// p[k]��ʾǰ׺��p[j]��ʾ��׺
		if (k == -1 || p[j] == p[k]) {
			++k;
			++j;
			next[j] = k;
		}
		else {
			k = next[k];
		}
	}
}

// �Ż����next������
void GetNextval(char* p, int next[]) {
	int pLen = strlen(p);
	next[0] = -1;
	int k = -1;
	int j = 0;
	while (j < pLen - 1) {
		// p[k]��ʾǰ׺��p[j]��ʾ��׺
		if (k == -1 || p[j] == p[k]) {
			++j;
			++k;
			// ��֮ǰ��next�����󷨣��Ķ�������4 lines
			if (p[j] != p[k])
				next[j] = k;
			else
				//��Ϊ���ܳ���p[j] = p[ next[j]]�����Ե�����ʱ��Ҫ�����ݹ飬k = next[k] = next[next[k]]
				next[j] = next[k];
		}
		else {
			k = next[k];
		}
	}
}