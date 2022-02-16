#include <stdio.h>

// call by value
void swap(int x, int y) {	// x und y sind parameter
	int temp = x;
	x = y;
	y = temp;
}

// call by reference
void swap2(int* p1, int* p2) {	// parameter p1 und p2 sind Speicheradressen
	int temp = *p1;	// mit * Operator auf Wert zugreifen, der sich unter der Speicheradresse p1 befindet
	*p1 = *p2;
	*p2 = temp;
}

int main() {
	int a = 12345;
	int b = 10000;
	int c = 5;

	long adressA = &a;
	printf("%d\n", adressA);
	long adressB = &b;
	printf("%d\n", adressB);
	int* adressC = &c;
	printf("%d\n", adressC);

	printf("c=%d\n", c);
	printf("c=%d\n", *adressC);
	*adressC = 10;
	printf("c=%d\n", c);
	printf("c=%d\n", *adressC);

	swap(a, b);
	printf("a=%d\n", a);	// a ist ein argument
	printf("b=%d\n", b);

	swap2(&a, &b);
	printf("a=%d\n", a);	
	printf("b=%d\n", b);

	return 0;
}