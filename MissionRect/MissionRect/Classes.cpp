#include "Classes.h"
double Point::Dist(Point p)
{
	int w = x - p.x;
	int h = y - p.y;
	return sqrt(w * w + h * h);
}
void Point::Show(const char* s)
{
	printf("%s(%d,%d)\n", s, x, y);
}
void Point::ShowEx(const char* s)
{
	printf("%s(%d,%d)", s, x, y);
}
Point& Point::operator+(Point p)  // 두점 CurP와 p의 + 연산결과를 (새로운 Point로) 반환
{
	Point* p1 = new Point(x + p.x, y + p.y);
	return *p1;
}

void Rect::Show(const char* s)  // RECT(P1(x1,y1), P2(x2,y2))
{
	printf("%s(", s);
	p1.ShowEx("P1");
	p2.ShowEx("P2");
	printf(")\n");
}

