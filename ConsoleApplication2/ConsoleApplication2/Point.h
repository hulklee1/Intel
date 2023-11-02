#pragma once
#include <iostream>
#define MIN(x,y)  (((x)>(y))?(y):(x))    
#define MAX(x,y)  (((x)<(y))?(y):(x))    
class Point
{
private:    // default ���� ������ (�ܺ� ���� �Ұ�)
public:     //     "      (�ܺ� ���� ����)
    int x, y, z;   // ��� ���� ����. ��ü(�� �ڽ�)�� ��ǥ
    // ������ ����. �Լ��� Ư��(default, Overload ��)
    Point(int x = 0, int y = 0) : x(x), y(y)  // initializer
    {
        z = 0;//x = x1; y = y1;
    }
    void SetP(int x1 = 0, int y1 = 0) { x = x1; y = y1; }
    double Dist(Point p)  // ����Լ� : �� ������ �Ÿ� ���. Double ������ return
    {
        int w = x - p.x;
        int h = y - p.y;
        return sqrt(w * w + h * h);
    }
    double Dist(Point p1, Point p2)  // ����Լ� : �� ��(�ڽ��� ������)�� �Ÿ� ���. Double ������ return
    {
        int w = p1.x - p2.x;
        int h = p1.y - p2.y;
        return sqrt(w * w + h * h);
    }
};

class Rect
{
    Point p11, p22;  // Ŭ���� ������� ����
    //Point LL, LR, UL, UR;
public:
    Rect(Point p1, Point p2)
    {
        //int xl = MIN(p1.x, p2.x);
        //int xr = MAX(p1.x, p2.x);
        //int yl = MIN(p1.y, p2.y);
        //int yu = MAX(p1.y, p2.y);
        //LL = Point(xl, yl);
        //LR = Point(xr, yl);
        //UL = Point(xl, yu);
        //UR = Point(xr, yu);
        p11 = p1; p22 = p2;
    }
    Point LL() { return Point(MIN(p11.x, p22.x), MIN(p11.y, p22.y)); }
    Point LR() { return Point(MAX(p11.x, p22.x), MIN(p11.y, p22.y)); }
    Point UL() { return Point(MIN(p11.x, p22.x), MAX(p11.y, p22.y)); }
    Point UR() { return Point(MAX(p11.x, p22.x), MAX(p11.y, p22.y)); }
};

