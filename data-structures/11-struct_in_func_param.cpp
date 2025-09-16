#include "iostream"
using namespace std;

struct square {
    double side_length;
};

double area(square any_square) {
    return any_square.side_length * any_square.side_length;
}

int main() {
    square square_1;

    cout << "Input square side length: ";
    cin >> square_1.side_length;
    cout << "Area of the square: " << area(square_1) << endl;

    return 0;
}