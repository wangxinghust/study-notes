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
//����һ����������������е�����k����㡣
//ʹ������ָ�룬��һ��ָ������k-1�����γ�k����Ƴ��ӡ�Ȼ��ͬʱ�ƶ���ָ�룬��һ��ָ��pListAhead->next=nullptrʱ���ڶ���ָ�뼴ָ���˵�����k����㡣
//����Ҫע������³����
//1.�����pListHeadΪ��ָ�룬���ڴ������ͼ���ʿ�ָ��ָ����ڴ棬�Ӷ���ɳ��������
//2.�������pListHeadΪͷ��������Ľ����������k����forѭ�����ж�pListAhead�ܷ���k-1����������
//3.����Ĳ���kΪ0������k���޷�����������ô��forѭ���У�k-1�õ��Ĳ���-1������0xFFFFFFFF����˻���������������ջ���
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