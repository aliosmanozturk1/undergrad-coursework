#include <iostream>
using namespace std;

int main() {
    char character;
    cout << "Input a char: ";
    cin >> character;

    cout << endl << "Current Char: " << character;
    cout << endl << "Next Char: " << ++character;

    return 0;
}
