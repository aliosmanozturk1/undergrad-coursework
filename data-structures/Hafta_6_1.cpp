#include <iostream>
using namespace std; 
  
#define BOYUT 10 
  
class Stack 
{ 
    int top; 
    int YIGIN[BOYUT];
public: 
         
    Stack(); 
    bool Push(int x); 
    int Pop(); 
    bool IsEmpty();
    int StackTop();
	void WriteAll();
	void DisplayStack();
    void DeleteAll();
    
};

Stack::Stack()  
{ 
  top = -1; 
} 
  
bool Stack::Push(int x) 
{ 
    if (top >= (BOYUT-1)) 
    { 
        cout << "Yigin Dolu"; 
        return false; 
    } 
    else
    { 
        YIGIN[++top] = x; 
        cout<<x <<" degeri Yigina eklendi\n"; 
        return true; 
    } 
} 
  
int Stack::Pop() 
{ 
    if (top < 0) 
    { 
        cout << "Yigin Bos"; 
        return 0; 
    } 
    else
    { 
        int x = YIGIN[top--]; 
        return x; 
    } 
} 
  
bool Stack::IsEmpty() 
{ 
    return (top < 0); 
} 

int Stack::StackTop()
{
  if(top == -1)
  {
    cout<<"\n yigin bos";
    return -1;
  }
  else
    return (YIGIN[top]);
}
  
void Stack::WriteAll() 
{
   if(top>=0) {
      cout<<"Yigindaki elemanlar:";
      for(int i=top; i>=0; i--)
         cout<<YIGIN[i]<<" ";
         cout<<endl;
   } else
      cout<<"Yigin bos"<<endl;
}

void Stack::DeleteAll() 
{
   top=-1;
}

void Stack::DisplayStack() {
	cout << "top -->";
	for (int i = top; i >= 0; i--) 
		cout << "\t| " << YIGIN[i] << " | " << endl;
	cout << "\t------" << endl;
}

int main() 
{ 
    Stack s;
    s.WriteAll(); 
    s.Push(10); 
    s.Push(20); 
    s.Push(30); 
    s.WriteAll();
    cout<<s.Pop() << " Yigindan cikarildi\n"; 
    cout<<"Yiginin en üstünde "<<s.StackTop()<<" var"<<endl;
    s.WriteAll();
    //s.DeleteAll();
    //s.WriteAll();
    
    cout<<"bir tamsayi giriniz:";
    int sayi;
    cin>>sayi;
    s.Push(sayi);
    
    s.DisplayStack();
    return 0; 
}