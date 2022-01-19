#define nrOfElements 5	// Präprozessorkonstante
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> 

// Der Benutzer soll 5 Zahlen eingeben und als Ausgabe den Mittelwert dieser 5 Zahlen erhalten.

void main() {
	int input1 = 0, input2 = 0, input3 = 0, input4 = 0, input5 = 0;

	printf("Geben Sie f\x81nf Zahlen (durch Lehrzeichen getrennt) ein: ");
	scanf("%i%i%i%i%i", &input1, &input2, &input3, &input4, &input5);
	printf("Der Durchschnitt ist %f\n", (input1 + input2 + input3 + input4 + input5) / 5.0);
	
	// 2. Lösung
	int sum = 0;
	for (size_t i = 0; i < 5; i++)
	{
		int input = 0;
		printf("Geben Sie eine Zahlen ein: ");
		scanf("%i", &input);
		sum += input;
	}
	printf("Der Durchschnitt ist %f\n", sum / 5.0);

	// 3. Lösung
	int inputs[nrOfElements];
	for (int i = 0; i < nrOfElements; i++)
	{
		printf("Geben Sie eine Zahlen ein: ");
		scanf("%i", &inputs[i]);
	}
	sum = 0;
	for (int i = 0; i < nrOfElements; i++)
	{
		sum += inputs[i];
	}
	printf("Der Durchschnitt ist %f", sum / (double)nrOfElements);
}