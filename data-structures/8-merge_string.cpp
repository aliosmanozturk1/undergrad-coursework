#include<iostream>
using namespace std;

void add_string(char array1[], char array2[]);

int main() {
    char array1[20];
    char array2[20];

    cout << "Input string 1: ";
    cin >> array1;
    cout << "Input string 2: ";
    cin >> array2;

    add_string(array1, array2);
    return 0;
}

void add_string(char array1[], char array2[]) {
    int i,j;

    for (i = 0; array1[i] != '\0'; i++);
        for (j = 0; array2[j] != '\0'; j++)
            array1[i+j] = array2[j];

    array1[i+j] = '\0';
    cout << "Sonuc : " << array1;
}