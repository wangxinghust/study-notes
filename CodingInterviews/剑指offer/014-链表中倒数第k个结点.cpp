#include "stdafx.h"
#include <vector>
using namespace std;


struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
//输入一个链表，输出该链表中倒数第k个结点。
//使用两个指针，第一个指针先走k-1步，形成k差，类似尺子。然后同时移动两指针，第一个指针pListAhead->next=nullptr时，第二个指针即指向了倒数第k个结点。
//但是要注意代码的鲁棒性
//1.输入的pListHead为空指针，由于代码会试图访问空指针指向的内存，从而造成程序崩溃；
//2.输入的以pListHead为头结点的链表的结点总数少于k，在for循环中判断pListAhead能否走k-1步即可量出
//3.输入的参数k为0，由于k是无符号整数，那么在for循环中，k-1得到的不是-1，而是0xFFFFFFFF，因此会造成运算过长，堆栈溢出
class Solution {
public:
	ListNode* FindKthToTail(ListNode* pListHead, unsigned int k) {
		if (pListHead == nullptr || k == 0)
		{
			return nullptr;
		}
		else
		{
			ListNode* pListAhead = pListHead;
			ListNode* pListRear = pListHead;
			for (unsigned int i = 0; i < k - 1; i++)
			{
				if (pListAhead->next != nullptr)
				{
					pListAhead = pListAhead->next;
				}
				else
				{
					return nullptr;
				}
			}
			while (pListAhead->next != nullptr)
			{
				pListAhead = pListAhead->next;
				pListRear = pListRear->next;
			}
			return pListRear;
		}
	}
};