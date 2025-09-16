#include <iostream>
using namespace std;

struct mesafe {
    int metre;
    float cm;
};

struct oda {
    mesafe en;
    mesafe boy;
};

int main() {
    oda salon;

    salon.en.metre = 6;
    salon.en.cm = 20;
    salon.boy.metre = 5;
    salon.boy.cm = 27;

    float u = salon.en.metre + salon.en.cm/100;
    float g = salon.boy.metre + salon.boy.cm/100;
    cout << "Salon Alanı: " << u * g << " m2 "<<endl;
    return 0;
}
