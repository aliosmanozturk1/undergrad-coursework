#include <iostream>
using namespace std;

#define BOYUT 10

class Stack{//yigin sınıfı
    int top;
    int YIGIN[BOYUT];
    
    public:
    
        Stack();
        bool Push(int x);
        bool Pop(int& item);
        bool IsEmpty();
       
};
Stack::Stack()
{
    top=-1;
}
bool Stack::Push(int x)
{
    if(top>=(BOYUT-1))
    {
        cout<<"Yigin dolu"<<endl;
        return false;
    }
    else{
        
        YIGIN[++top]=x;
        return true;
    }
}
bool Stack::Pop(int& item){
    if(top<0)
    {
        //cout<<"yigin bos";
        return 0;
    }
        
        item = YIGIN[top--];
        return true;
}

bool Stack::IsEmpty(){
    return (top<0);
}


int main(){
    
    Stack s;
    int r,b=1;
    for(int i=10;i<=30;i+=10) s.Push(i);
    while(s.Pop(r)) b=b*r;
    cout<<b;
    return 0;
}








