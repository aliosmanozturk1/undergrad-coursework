#include <stdio.h>

int main() {
    int not;
    printf("Lütfen notu giriniz: ");
    scanf("%d", &not);

    switch (not / 10) {
        case 10:
        case 9:
            printf("A\n");
            break;
        case 8:
            printf("B\n");
            break;
        case 7:
            printf("C\n");
            break;
        case 6:
            printf("D\n");
            break;
        case 5:
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            printf("NOT: F\n");
            break;
        default:
            printf("Notu tekrar giriniz!\n");
    }

    return 0;
} 