#include <iostream>

#define   SQUARE(x)   ((x)*(x))         // 매크로 함수 예제
#define   ABS(x)    (((x)<0)?-(x):(x))  // 모든 인수에 반드시 괄호
// 전역변수/데이터 타잎 선언

//typedef struct Point
//{
//    int x;
//    int y;
//} Point2D;
//double Dist(Point2D p1, Point2D p2);

class Point
{
private:
    int x;
    int y;
    //Point() {}     // null argument 허용
public:
    Point(int x1 = 0, int y1 = 0)   // default 값 설정
    {
        x = x1; y = y1;
    }
    double Dist(Point p);  // function Prototype
    double Dist(int x1, int y1);
    double Dist(Point p1, Point p2);
    int Area(Point p);
};

int main()
{
    printf("안녕하세요. C++ 의 세계에 오신것을 열렬히 환영합니다!\n\n");

    printf("5의 제곱 : %d\n", SQUARE(5));
    printf("1.2의 제곱 : %f\n", SQUARE(1.2));
    int x = 7;
    printf("%d의 제곱 : %d\n", x+1, SQUARE(x+1));
    printf("-5의 절대값 : %d\n", ABS(-5));
    printf("9의 절대값 : %d\n", SQUARE(ABS(9)));

    Point p1(10,10), p2(20,30), p3;
//    p1.x = 10; p1.y = 10;
//    p2.x = 20; p2.y = 30;

    double d = p1.Dist(p2);
    double e = p1.Dist(20, 30);
    double d1 = p1.Dist(p2);
    double e1 = p3.Dist(p1, p2);
    printf("두점 p1(%d,%d), p2(%d,%d)의 거리는 %.2f(%.2f), 면적은 %d 입니다.\r\n",
        p1.x, p1.y, p2.x, p2.y, d, e, p2.Area(p1));
    printf("두점 p1(%d,%d), p2(%d,%d)의 거리는 %.2f(%.2f), 면적은 %d 입니다.\r\n",
        p1.x, p1.y, p2.x, p2.y, d, e, p2.Area(p1));
    printf("null argument P3는 p(%d,%d)로 설정되었습니다.", p3.x, p3.y);

    //std::cout << "안녕하세요. C++ 의 세계에 오신것을 환영합니다!\n";
}
    double Point::Dist(Point p)
    {
        int w = (x - p.x);
        int h = (y - p.y);
        double d = sqrt(w * w + h * h);
        return d;
    }
    double Point::Dist(int x1, int y1)
    {
        int w = (x - x1);
        int h = (y - y1);
        double d = sqrt(w * w + h * h);
        return d;
    }
    double Point::Dist(Point p1, Point p2)
    {
        int w = (p1.x - p2.x);
        int h = (p1.y - p2.y);
        double d = sqrt(w * w + h * h);
        return d;
    }
    int Point::Area(Point p)
    {
        int w = ABS(x - p.x);
        int h = ABS(y - p.y);
        int a = w * h;
        return a;
    }



double Dist(Point p1, Point p2) // 두 점간의 거리
{
    int w = ABS(p1.x - p2.x);
    int h = ABS(p1.y - p2.y);
    int w1 = w * w;
    int h1 = h * h;
    double d = sqrt(w1 + h1);
    return d;
}

