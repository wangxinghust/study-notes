#include <vector>
#include <iostream>

using namespace std;

int main(){
    string num;
    getline(cin,num);
    for(int i=num.size()-1;i>0;i--){
        if(num[i]=='2'){
            num[i-1]+=1;
            num[i]='T';
        }
        if(num[i]=='3'){
            num[i-1]+=1;
            num[i]='0';
        }
    }
    if(num[0]=='2'){
        num[0]='T';
        cout<<'1'+num<<endl;
    }else if(num[0]=='3'){
        num[0]='0';
        cout<<'1'+num<<endl;
    }
    else{
        cout<<num<<endl;
    }
}