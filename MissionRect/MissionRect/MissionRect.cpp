#include <iostream>
#include "Classes.h"

int main()
{
	Rect r1;
	Rect r2(10, 20, 30, 40);
	Rect r3(Point(100, 200), Point(300, 400));
	r1.Show("R1");
	r2.Show("R2");
	r3.Show("R3");
}
