#include "stdafx.h"
using namespace std;

//给定一个二叉树和其中的一个结点，请找出中序遍历顺序的下一个结点并且返回。注意，树中的结点不仅包含左右子结点，同时包含指向父结点的指针。
struct TreeLinkNode {
    int val;
    struct TreeLinkNode *left;
    struct TreeLinkNode *right;
    struct TreeLinkNode *next;
    TreeLinkNode(int x) :val(x), left(NULL), right(NULL), next(NULL) {
        
    }
};

class Solution {
public:
    TreeLinkNode* GetNext1(TreeLinkNode* pNode)
    {
        if(pNode==nullptr)
        {
            return nullptr;
        }
        //有右结点
        if(pNode->right)
        {
            TreeLinkNode *tmp=pNode->right;
            //找右子树的中序遍历第一个结点
            while(tmp->left)
            {
                tmp=tmp->left;
            }
            return tmp;
        }
        //没有右结点
        else
        {
            //没有右结点 没有父节点
            if(!pNode->next)
            {
                return nullptr;
            }
            //没有右结点 有父节点
            else
            {
                //当前结点是父节点的左结点
                if(pNode==pNode->next->left)
                {
                    return pNode->next;
                }
                //当前结点是父节点的右结点
                else
                {
                    //父节点没有父节点
                    if(!pNode->next->next)
                    {
                        return nullptr;
                    }
                    //父节点的父节点存在
                    else
                    {
                        //父结点是父节点的父节点的左结点
                        if(pNode->next==pNode->next->next->left)
                        {
                            return pNode->next->next;
                        }
                        //父结点是父结点的父结点的右结点
                        else
                        {
                            return nullptr;
                        }
                        //这一段的解法能通过测试用例，但实际上是错的 应当一直向上追溯，知道找着第一个结点是父结点的左结点为止
                    }
                }
            }
        }
    }

    TreeLinkNode* GetNext(TreeLinkNode* pNode)
    {
        //空结点判定
        if(pNode==nullptr)
        {
            return nullptr;
        }
        //右结点存在
        if(pNode->right)
        {
            pNode=pNode->right;
            while(pNode->left)
            {
                pNode=pNode->left;
            }
            return pNode;
        }
        //右结点不存在
        while(pNode->next)
        {
            //找到第一个父结点的左结点是当前结点的，返回父结点
            TreeLinkNode *pRoot=pNode->next;
            if(pRoot->left==pNode)
            {
                return pRoot;
            }
            //向上追溯
            pNode=pNode->next;
        }
        //如果不存在，返回nullptr
        return nullptr;
    }
};