# Intel
## Inchon
### Kocharm
오늘 배운 내용
///
class Point
{
public:
    int x;
    int y;
    //Point() {}     // null argument 허용
    Point(int x1 = 0, int y1 = 0)   // default 값 설정
    {
        x = x1; y = y1;
    }
    double Dist(Point p)
    {
        int w = (x - p.x);
        int h = (y - p.y);
        double d = sqrt(w * w + h * h);
        return d;
    }
    int Area(Point p)
    {
        int w = ABS(x - p.x);
        int h = ABS(y - p.y);
        int a = w * h;
        return a;
    }
};
///
