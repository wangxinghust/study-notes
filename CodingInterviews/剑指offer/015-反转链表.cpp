#include "stdafx.h"
using namespace std;

struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
//����һ��������ת��������������ı�ͷ��
class Solution {
public:
	ListNode* ReverseList(ListNode* pHead) {
		ListNode* pReverseListHead = nullptr;
		ListNode* pNode = pHead;
		ListNode* pPrev = nullptr;
		ListNode* pNext = nullptr;
		//�������ж�pHead��nullptr���������������ʱ����ѭ�������ص�
		//pReverseListHead����nullptr��ͬʱҲ�����ж�pNode�ǲ���Խ���ˣ�������ֹѭ��
		while (pNode != nullptr)
		{
			//�ݴ�pNode->next
			pNext = pNode->next;
			if (pNext == nullptr)//pNodeָ�������һ�����
			{
				pReverseListHead = pNode;
			}
			//�ı�ָ��ָ������ָ�����ǰָ
			pNode->next = pPrev;

			//����һ��ѭ����׼����pPrevָ��Ŀǰ��㣬Ŀǰ�����������һ���
			pPrev = pNode;
			pNode = pNext;
		}
		return pReverseListHead;
	}
};