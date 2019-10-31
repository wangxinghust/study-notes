#include "stdafx.h"
#include <vector>
using std::vector;

//从尾到头打印链表
/*
输入一个链表，按链表值从尾到头的顺序返回一个ArrayList。
*/
struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};

class Solution {
public:
	vector<int> printListFromTailToHead(ListNode* head) {
		vector<int> arrayList;
		if (head != NULL)
		{
			if (head->next != NULL)
			{
				arrayList = printListFromTailToHead(head->next);
			}
			arrayList.push_back(head->val);
		}
		
		return arrayList;
	}
};