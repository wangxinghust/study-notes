#include "stdafx.h"
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
    ListNode* EntryNodeOfLoop(ListNode* pHead)
    {
        if(pHead==nullptr)
        {
            return nullptr;
        }
        ListNode *fast=pHead;
        ListNode *slow=pHead;
        do
        {
            fast=fast->next;
            if(fast==nullptr)
            {
                return nullptr;
            }
            fast=fast->next;
            if(fast==nullptr)
            {
                return nullptr;
            }
            slow=slow->next;
            if(slow==nullptr)
            {
                return nullptr;
            }
        }
        while(fast!=slow);
        fast=pHead;
        while(fast!=slow)
        {
            fast=fast->next;
            slow=slow->next;
        }
        return fast;
    }
};