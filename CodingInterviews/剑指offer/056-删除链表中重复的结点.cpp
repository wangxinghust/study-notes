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

class Solution {
public:
    //解法存疑 内存超限
    ListNode* deleteDuplication1(ListNode* pHead)
    {
        //声明pNode用作遍历
        ListNode *pNode=pHead;
        //声明value数组保存链表val值
        vector<int> value;
        //声明isDuplication数组标记是否需要删除
        vector<bool> isDuplication;
        //遍历，保存val值用于标记，同时初始化isDuplication
        while(pNode!=nullptr)
        {
            value.push_back(pNode->val);
            isDuplication.push_back(false);
        }
        //遍历value数组，如果前后相同，则对应isDuplication数组值置true
        for(size_t i = 0; i < value.size()-1; i++)
        {
            if(value[i]==value[i+1])
            {
                isDuplication[i]=true;
                isDuplication[i+1]=true;
            }
        }
        int j=0;
        //将pNode用作返回链表的头结点
        pNode=pHead;
        //遍历isDuplication数组，改变头结点
        while(isDuplication[j])
        {
            pNode=pNode->next;
            j++;
        }
        //接着遍历isDuplication数组，如果下一位重复，则删除下一结点
        for(; j < isDuplication.size()-1; j++)
        {
            int numberOfDuplication=0;
            while(j<isDuplication.size()&&isDuplication[j+1])
            {
                j++;
                numberOfDuplication++;
            }
            for(; numberOfDuplication > 0; numberOfDuplication--)
            {
                pNode->next=pNode->next->next;
            }
            pNode=pNode->next;
        }
        return pNode;
    }

    ListNode* deleteDuplication(ListNode* pHead)
    {
        if(pHead==nullptr)
        {
            return nullptr;
        }
        if(pHead!=nullptr&&pHead->next==nullptr)
        {
            return pHead;
        }
        ListNode *current;
        if(pHead->next->val==pHead->val)
        {
            current=pHead->next->next;
            while(current!=nullptr&&current->val==pHead->val)
            {
                current=current->next;
            }
            return deleteDuplication(current);
        }
        else
        {
            current=pHead->next;
            pHead->next=deleteDuplication(current);
            return pHead;
        }
    }
};