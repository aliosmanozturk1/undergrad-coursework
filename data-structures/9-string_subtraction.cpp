#include <iostream>
using namespace std;

int main() {
    char dizi[] = "denemeler";
    char cikar;
    int i = 0;
    cout << "Cikarmak istediginiz karakteri giriniz: ";
    cin >> cikar;

    while(dizi[i] != '\0') {
        if(dizi[i]==cikar)
            for(int j=i;j<10;j++)
                dizi[j]=dizi[j+1];
        else
            i++;
    }
    cout << dizi;
    return 0;
}