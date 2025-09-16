#include <iostream>
using namespace std;

int func(int[],int);

int main() {
    int result;
    int array[5]= {3,4,7,1,9};

    result = func(array,5);
    cout << result;

    return 0;
}


int func(int array[],int len) {
    int sum=0;

    for(int i=0; i<len; i++) {
        sum += array[i];
    }
    return sum;
}
