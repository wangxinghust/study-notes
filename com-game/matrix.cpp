#include <math.h>
#include <iostream>

using namespace std;

int main(){
    int num;
    cin>>num;

    int sq=sqrt(num);
    int remain=num-sq*sq;

    int x=sq-1,y=-x;
    if(remain>1){
        x++;
        remain-=1;
    }else{
        x+=remain;
        cout<<x<<" "<<y;
        return 0;
    }
    
    if(remain>2*(sq-1)){
        remain-=2*(sq-1);
        y+=2*(sq-1);
    }else{
        y+=remain;
        cout<<x<<" "<<y;
        return 0;
    }

    if(remain>2*(sq-1)){
        remain-=2*(sq-1);
        x-=2*(sq-1);
    }else{
        x-=remain;
        cout<<x<<" "<<y;
        return 0;
    }

    if(remain>2*(sq-1)){
        remain-=2*(sq-1);
        y-=2*(sq-1);
    }else{
        y-=remain;
        cout<<x<<" "<<y;
        return 0;
    }

    x+=remain;
    cout<<x<<" "<<y;
}