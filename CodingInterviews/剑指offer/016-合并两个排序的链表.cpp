#include "stdafx.h"
using namespace std;

struct ListNode {
	int val;
	struct ListNode *next;
	ListNode(int x) :
		val(x), next(NULL) {
	}
};
//���������������������������������ϳɺ��������Ȼ������Ҫ�ϳɺ���������㵥����������
//�ⷨ��������ָ�뵱���α꣬ȡС��������ͷָ�룬�ƶ���Сָ�룬ֱ������һָ��󣬲�����ӣ�ָ����һ������Ȼ������һ�������ƶ�ָ�룬�ظ�����
//TODO ���Ƚ�pList1->next->val��pList2->val,ֱ�������α���бȽ�Ӧ��Ҳ�ǿ��Եģ�ע�����³���Լ���
class Solution {
public:
	ListNode* Merge(ListNode* pHead1, ListNode* pHead2)
	{
		//���������α�ָ��
		ListNode* pList1 = pHead1;
		ListNode* pList2 = pHead2;
		//����ͷָ�룬�������ж�ͷָ��ָ����Ҫ�жϸ���nullptr���
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
		//ѭ���ƶ����α�
		while (pList1 != nullptr && pList2 != nullptr)
		{
			//ͨ����ǰֵ�ıȽ��ж���Ҫ�ƶ��ĸ��α�
			if (pList1->val < pList2->val)
			{
				//�ж��Ƿ�Խ�磬���Ƚ�ֵ
				while (pList1->next != nullptr&&pList1->next->val < pList2->val)
				{
					pList1 = pList1->next;
				}
				//Խ�磬1�����ֱ꣬�ӽ���2����return
				if (pList1->next == nullptr)
				{
					pList1->next = pList2;
					return pMergeHead;
				}
				//������ָ����һ��������Ҫע��tmp��ʱ������ʹ�ã����ڱ�������
				ListNode* tmp = pList1->next;
				pList1->next = pList2;
				pList1 = tmp;
			}
			//����ͬ�ϣ���else�������Ǽ����жϣ�дif��ʱ�������else�������elseΪ�գ�����©�ж���
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