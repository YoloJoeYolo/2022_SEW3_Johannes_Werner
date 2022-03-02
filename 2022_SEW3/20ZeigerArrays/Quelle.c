#include <stdio.h>
#include <time.h>
#include <stdlib.h>

//void reset(int arr[], int size) {
void reset(int* arr, int size){
	for(int i = 0; i < size; i++)	// int* arr gleichbedeutend mit int arr[]
	{
		arr[i] = 0;
	}
}

int* getRandom(/* call by reference mit einer Variable, wo die Länge des Arrays gesetzt wird*/ int* length) {	// Wir übergeben die Adresse von length --> call by reference
	int i = 0; // Gültigkeitsbereich --> nur Funktion, außerhalb existiert diese Variable nicht
	//int list[10];	// Gültigkeitsbereich von list[] --> nur in Funktion
	static int list[10];	// die Liste so anlegen, dass sie auch außerhalb der Funktion gültig ist --> static 
	srand((unsigned)time(NULL));
	*length = 10;

	for (int i = 0; i < 10; i++)
	{
		list[i] = rand() % 11;	// Zufallszahl 0...10;
	}
	return list;
	// an dieser Stelle wird der Speicherbereich list[10] eigentlich schon wieder freigeben
}

int main() {
	int list[10];
	reset(list, 10);	// alle werte auf 0 setzen

	for (int i = 0; i < 10; i++)
	{
		printf("%d", list[i]);
	}

	int lenght = 8;
	int* list2;		// Adresse des Startbereichs des Arrays
	list2 = getRandom(&lenght);

	printf("\nlist2\n");
	for (int i = 0; i < 20; i++)
	{
		printf("%d\n", list2[i]);
	}
	printf("Länge der list2: %i", lenght);
	
}