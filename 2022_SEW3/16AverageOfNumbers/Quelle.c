#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> 

// Der Benutzer soll 5 Zahlen eingeben und als Ausgabe den Mittelwert dieser 5 Zahlen erhalten.

void main() {
	double numbers[5];
	printf("Geben Sie f\x81nf Zahlen (durch Lehrzeichen getrennt) ein: ");
	scanf("%d %d %d %d %d", &numbers[0], &numbers[1], &numbers[2], &numbers[3], &numbers[4]);
	printf("Der Durchschnitt ist %d\n", (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5);

	double input;
	double sum = 0;
	for (size_t i = 0; i < 5; i++)
	{
		printf("Geben Sie eine Zahlen ein: ");
		scanf("%d", &input);
		sum += input;
	}
	printf("Der Durchschnitt ist %d", sum / 5);
}