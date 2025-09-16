#include <iostream>
using namespace std;

int main() {
    char character;
    cout << "Bir karakter giriniz: ";
    cin >> character;

    cout << endl << "Karakter: " << character;
    cout << endl << "Decimal: " << int(character);
    cout << endl << "Hexadecimal: " << hex << int(character);
    cout << endl << "Octadecimal: " << oct << int(character);
    cout << endl << "Adress: " << &character;

    return 0;
}
