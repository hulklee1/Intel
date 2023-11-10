#include <iostream>
#include "Point.h"
int main()
{
	Point p1(10,10), p2, p3;
	p1.viewP("P1"); p2.viewP(); p3.viewP();
	Point p4 = p3, p5(p2);

	p2.SetP(Point(20, 30)).viewP("P2");
	p3.SetP(40, 70).viewP("P3");
	printf("두 점으로 정의되는 사각형의 넓이는 %f 입니다\r\n", p2 * p3);
	//printf("Point Move Test........\n\n");
	//p1.MoveP(1, 1).viewP("P1_1_1");
	//p1.MoveP(1, 1).viewP("P1_1_1");
	//p1.MoveP(1, 1).viewP("P1_1_1");
	//p1.MoveP(1, 1).viewP("P1_1_1");
	//printf("Point print Test..P1(%d,%d).\n\n",p1.X(), p1.Y());
	//p1.X() = 10; p1.Y() = 10;
	//printf("Point Ref. Access Test..."); p1.viewP("P1");

	Point p6 = p1 + p2;
	printf("Point [Operator+] Test..."); p6.viewP("_P6");
	printf("Point [Operator++] 후행연산 Test..."); p6++.viewP("_P6");
	printf("Point [Operator++] 선행연산 Test..."); (++p6).viewP("_P6");

	////Point3D pp0, pp1(10, 20, 30);
	////double d3 = pp0.Dist3D(pp1);
	////double d2 = pp0.Dist(Point(10, 20));
	////printf("pp0(0,0,0) 과 pp1(10,20,30)의 거리는 %f\n", d3);
	////printf("pp0(0,0,0) 과  p1(10,20)의 거리는 %f\n", d2);
	//p1.viewP("P1"); p2.viewP("P2"); p3.viewP("P3");
}
