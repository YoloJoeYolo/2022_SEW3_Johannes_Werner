#include <stdio.h>
#include <stdlib.h> 
#include <time.h>

void mischen(int* array) {
	srand(time(NULL));
	for (int i = 0; i < 20; i++)
	{
		int r = rand() % 7;
		int temp = array[0];
		array[0] = array[r];
		array[r] = temp;
	}
}

void main() {
	int var[] = { 1, 2, 3, 4, 5, 6, 7 };
	printf("[ %i, %i, %i, %i, %i, %i, %i]\n", var[0], var[1], var[2], var[3], var[4], var[5], var[6]);
	mischen(var);
	printf("[ %i, %i, %i, %i, %i, %i, %i]", var[0], var[1], var[2], var[3], var[4], var[5], var[6]);
}
