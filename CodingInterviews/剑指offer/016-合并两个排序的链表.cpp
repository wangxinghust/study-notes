#include "stdafx.h"
using namespace std;

struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
//输入两个单调递增的链表，输出两个链表合成后的链表，当然我们需要合成后的链表满足单调不减规则。
//解法：用两个指针当做游标，取小的做链表头指针，移动较小指针，直到比另一指针大，拆掉链接，指向另一条链，然后在另一条链上移动指针，重复操作
//TODO 不比较pList1->next->val和pList2->val,直接两个游标进行比较应该也是可以的，注意代码鲁棒性即可
class Solution {
public:
	ListNode* Merge(ListNode* pHead1, ListNode* pHead2)
	{
		//建立两个游标指针
		ListNode* pList1 = pHead1;
		ListNode* pList2 = pHead2;
		//建立头指针，并初步判断头指针指向，需要判断各种nullptr情况
		ListNode* pMergeHead = nullptr;
		if (pList1 == nullptr)
		{
			pMergeHead = pList2;
		}
		else if (pList2 == nullptr)
		{
			pMergeHead = pList1;
		}
		else
		{
			if (pList1->val < pList2->val)
			{
				pMergeHead = pList1;
			}
			else
			{
				pMergeHead = pList2;
			}
		}
		//循环移动两游标
		while (pList1 != nullptr && pList2 != nullptr)
		{
			//通过当前值的比较判断需要移动哪个游标
			if (pList1->val < pList2->val)
			{
				//判断是否越界，并比较值
				while (pList1->next != nullptr&&pList1->next->val < pList2->val)
				{
					pList1 = pList1->next;
				}
				//越界，1链走完，直接接上2链，return
				if (pList1->next == nullptr)
				{
					pList1->next = pList2;
					return pMergeHead;
				}
				//拆链，指向另一条链，需要注意tmp临时变量的使用，用于变量交换
				ListNode* tmp = pList1->next;
				pList1->next = pList2;
				pList1 = tmp;
			}
			//操作同上，用else，而不是继续判断，写if的时候多想想else在哪里，是else为空，还是漏判断了
			else
			{
				while (pList2->next != nullptr&&pList2->next->val < pList1->val)
				{
					pList2 = pList2->next;
				}
				if (pList2->next == nullptr)
				{
					pList2->next = pList1;
					return pMergeHead;
				}
				ListNode* tmp = pList2->next;
				pList2->next = pList1;
				pList2 = tmp;
			}
		}
		return pMergeHead;
	}
};