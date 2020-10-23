#include <list>
#include <iostream>

using namespace std;

int main(){
    int N,K;
    cin>>N>>K;
    int A[N],maxTime=0;
    for (int i = 0; i < N; i++)
    {
        cin>>A[i];
        maxTime=maxTime>A[i]?maxTime:A[i];
    }
    int time[maxTime];
    // 数组初始化
    for(int i=0;i<maxTime;i++){
        time[i]=0;
    }
    for (int i = 0; i < N; i++)
    {
        time[A[i]-1]++;
    }
    for(int i=maxTime-1;i>=0;i--){
        time[i]-=K;
    }
    int remain=0;
    for(int i=maxTime-1;i>=0;i--){
        remain+=time[i];
        remain=remain<0?0:remain;
    }
    cout<<N-remain<<endl;
}
