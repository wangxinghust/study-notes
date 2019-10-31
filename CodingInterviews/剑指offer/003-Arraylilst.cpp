#include "stdafx.h"
#include <vector>
using std::vector;

//��β��ͷ��ӡ����
/*
����һ������������ֵ��β��ͷ��˳�򷵻�һ��ArrayList��
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