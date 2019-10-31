#include "stdafx.h"
using namespace std;

//输入一个复杂链表（每个节点中有节点值，以及两个指针，一个指向下一个节点，另一个特殊指针指向任意一个节点），
//返回结果为复制后复杂链表的head。（注意，输出结果中请不要返回参数中的节点引用，否则判题程序会直接返回空）
struct RandomListNode {
	int label;
	struct RandomListNode *next, *random;
	RandomListNode(int x) :
		label(x), next(NULL), random(NULL) {
	}
};

class Solution {
public:
	RandomListNode* Clone(RandomListNode* pHead)
	{
		CloneNodes(pHead);
		ConnectRandomNodes(pHead);
		return ReconnectNodes(pHead);
	}
	void CloneNodes(RandomListNode* pHead)
	{
		RandomListNode *pNode = pHead;
		while (pNode != nullptr)
		{
			RandomListNode* pCloneNode = new RandomListNode(pNode->label);
			pCloneNode->next = pNode->next;
			pNode->next = pCloneNode;
			pNode = pCloneNode->next;
		}
	}
	void ConnectRandomNodes(RandomListNode* pHead)
	{
		RandomListNode *pNode = pHead;
		while (pNode != nullptr)
		{
			RandomListNode* pCloneNode = pNode->next;
			if (pNode->random != nullptr)
			{
				pCloneNode->random = pNode->random->next;
			}
			pNode = pCloneNode->next;
		}
	}
	RandomListNode* ReconnectNodes(RandomListNode* pHead)
	{
		RandomListNode *pNode = pHead;
		RandomListNode *pCloneHead = nullptr;
		RandomListNode *pCloneNode = nullptr;

		if (pNode != nullptr)
		{
			pCloneHead = pCloneNode = pNode->next;
			pNode->next = pCloneNode->next;
			pNode = pNode->next;
		}
		while (pNode != nullptr)
		{
			pCloneNode->next = pNode->next;
			pCloneNode = pCloneNode->next;
			pNode->next = pCloneNode->next;
			pNode = pNode->next;
		}
		return pCloneHead;
	}
};