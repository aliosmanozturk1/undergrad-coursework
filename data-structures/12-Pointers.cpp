#include <iostream>
using namespace std;

int main() {
    int a = 10;
    int *p;
    p = &a;

    cout << a << "'nun adresi: " << p << "'dir." << endl;
    cout << *p << "'nun adresi: " << &a << "'dir." << endl;

    return 0;
}

