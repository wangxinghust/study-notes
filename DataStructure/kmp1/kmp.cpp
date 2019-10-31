#include <cstring>
using namespace std;

// 暴力匹配
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

int next[50];// 这里可以用define, 或者用常量替代

// kmp匹配
int KmpSearch(char* s, char* p) {
	int i = 0;
	int j = 0;
	int sLen = strlen(s);
	int pLen = strlen(p);
	while (i < sLen && j < pLen) {
		// 如果j=-1，或者当前字符匹配成功（即s[i]==p[j])，都令i++,j++
		if (j == -1 || s[i] == s[j]) {
			++i;
			++j;
		}
		else {
			// 如果 j!=-1，且当前字符匹配失败（即s[i]!=p[j])，则令i不变，j=next[j]
			j = next[j];
		}
	}
	if (j == pLen) {
		return i - j;
	}
	else
		return -1;
}

// 求next数组
void GetNext(char* p, int next[]) {
	int pLen = strlen(p);
	next[0] = -1;
	int k = -1;
	int j = 0;
	while (j < pLen - 1) {
		// p[k]表示前缀，p[j]表示后缀
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

// 优化后的next数组求法
void GetNextval(char* p, int next[]) {
	int pLen = strlen(p);
	next[0] = -1;
	int k = -1;
	int j = 0;
	while (j < pLen - 1) {
		// p[k]表示前缀，p[j]表示后缀
		if (k == -1 || p[j] == p[k]) {
			++j;
			++k;
			// 较之前的next数组求法，改动在下面4 lines
			if (p[j] != p[k])
				next[j] = k;
			else
				//因为不能出现p[j] = p[ next[j]]，所以当出现时需要继续递归，k = next[k] = next[next[k]]
				next[j] = next[k];
		}
		else {
			k = next[k];
		}
	}
}