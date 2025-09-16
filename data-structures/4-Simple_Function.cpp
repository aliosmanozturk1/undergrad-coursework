#include <iostream>
using namespace std;

void print();

int main() {
    int number;
    print();

    cout << "Input a number: ";
    cin >> number;
    cout << number;

    return 0;
}

void print() {
    cout << "Data Structures" << endl;
}