#include <iostream>
#include "cmath"
using namespace std;

struct kutahya {
    int a;
};

int alan (struct kutahya r){
    r.a = 2;
    return 0;
}

int main()
{
    struct kutahya k1;

    cout << "a değerini giriniz: ";
    cin >> k1.a;
    cout << "Kutahyanın alani: " << alan(k1) << endl;
}
