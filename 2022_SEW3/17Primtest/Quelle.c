#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> 

// Der Benutzer soll eine Zahl eingeben und sie sollen überprüfen, ob es sich um eine Primzahl handelt.
// kleinste Primzahl: 2

int main() {
	// ein Rückgabewert von 0 signalisiert --> Alles in Ordung
	// Rückgabewert ungleich 0, bedeutet einen Fehlercode

	/*
	Versuch wird nicht verfolgt
	int input;
	printf("Geben Sie Zahlen um sie zu prüfen ob sie eine Primzahl ist : ");
	scanf("%i", &input);
	int prims[1000];
	prims[0] = 2;
	int nrOfPrims = 1;
	for (int i = 3; i < input; i+=2)
	{
		for (int j = 0; j < nrOfPrims; j++)
		{
			if (i % nrOfPrims[j] == 0)
			{
				prims[nrOfPrims] = i;
				nrOfPrims++;
			}
		}
	}
	for (int i = 0; i < nrOfPrims; i++)
	{
		if (input == prims[i])
		{
			printf("Die Zahl %i ist eine Primzahl", input);
			break;
		}
	}
	*/
	int input;
	printf("Geben Sie Zahlen um sie zu pr%cfen ob sie eine Primzahl ist: ", 129);
	scanf("%i", &input);
	if (input % 2 != 0)
	{
		for (int i = 3; i < input; i+=2)
		{
			if (input % i == 0) {
				printf("Die Zahl %i ist keine Primzahl", input);
				return 0;
			}
		}
	}
	printf("Die Zahl %i ist eine Primzahl", input);

	return 0;
}