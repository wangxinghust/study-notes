#include "stdafx.h"
using namespace std;

//����һ����������ÿ���ڵ����нڵ�ֵ���Լ�����ָ�룬һ��ָ����һ���ڵ㣬��һ������ָ��ָ������һ���ڵ㣩��
//���ؽ��Ϊ���ƺ��������head����ע�⣬���������벻Ҫ���ز����еĽڵ����ã�������������ֱ�ӷ��ؿգ�
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