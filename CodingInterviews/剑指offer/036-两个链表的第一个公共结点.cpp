#include "stdafx.h"
using namespace std;

//输入两个链表，找出它们的第一个公共结点。
struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
class Solution {
public:
	ListNode* FindFirstCommonNode(ListNode* pHead1, ListNode* pHead2) {
		int length1 = GetListLength(pHead1);
		int length2 = GetListLength(pHead2);
		int lengthDif = length1 - length2;
		ListNode *pFirstSame;

		ListNode *pLong = pHead1;
		ListNode *pShort = pHead2;
		if (length2 > length1)
		{
			pLong = pHead2;
			pShort = pHead1;
			lengthDif = -lengthDif;
		}
		for (size_t i = 0; i < lengthDif; i++)
		{
			pLong = pLong->next;
		}
		while ((pLong != nullptr) && (pShort != nullptr) && (pLong != pShort))
		{
			pLong = pLong->next;
			pShort = pShort->next;
		}
		pFirstSame = pLong;
		return pFirstSame;
	}
	int GetListLength(ListNode* pHead)
	{
		if (pHead == nullptr)
		{
			return 0;
		}
		int length = 0;
		ListNode *pNode = pHead;
		while (pNode != nullptr)
		{
			++length;
			pNode = pNode->next;
		}
		return length;
	}
};