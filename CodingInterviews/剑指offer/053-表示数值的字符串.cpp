#include "stdafx.h"
using namespace std;

class Solution {
public:
    bool isNumeric(char* string)
    {
        bool hasPoint=false;
        if(*string=='\0')
        {
            return false;
        }
        if(*string=='+'||*string=='-')
        {
            string++;
        }
        while(*string!='\0')
        {
            if(*string<='9'&&*string>='0')
            {
                string++;
            }
            else if(*string=='e'||*string=='E')
            {
                return isInteger(++string);
            }
            else if(*string=='.')
            {
                if(hasPoint)
                {
                    return false;
                }
                else
                {
                    hasPoint=true;
                    string++;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    bool isInteger(char* string)
    {
		if (*string == '\0')
		{
			return false;
		}
        if(*string=='+'||*string=='-')
        {
            string++;
        }
        while(*string!='\0')
        {
            if(*string>'9'||*string<'0')
            {
                return false;
            }
            string++;
        }
        return true;
    }
};