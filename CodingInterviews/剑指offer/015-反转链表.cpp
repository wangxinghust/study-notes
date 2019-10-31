#include "stdafx.h"
using namespace std;

struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
//输入一个链表，反转链表后，输出新链表的表头。
class Solution {
public:
	ListNode* ReverseList(ListNode* pHead) {
		ListNode* pReverseListHead = nullptr;
		ListNode* pNode = pHead;
		ListNode* pPrev = nullptr;
		ListNode* pNext = nullptr;
		//既用来判断pHead是nullptr的情况，条件成立时跳出循环，返回的
		//pReverseListHead即是nullptr；同时也用来判断pNode是不是越界了，用于终止循环
		while (pNode != nullptr)
		{
			//暂存pNode->next
			pNext = pNode->next;
			if (pNext == nullptr)//pNode指向了最后一个结点
			{
				pReverseListHead = pNode;
			}
			//改变指针指向，往后指变成往前指
			pNode->next = pPrev;

			//对下一次循环做准备，pPrev指向目前结点，目前结点则移至下一结点
			pPrev = pNode;
			pNode = pNext;
		}
		return pReverseListHead;
	}
};