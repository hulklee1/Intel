# Intel
## Inchon
### Kocharm
오늘 배운 내용
```cpp
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
```


## 오늘 배운 내용  -  2024-03-22  

```c
void seg(int sel, uint8_t c)
{	
	PORTB |= 0X0F;
	PORTB &= ~(1 << (3-sel));
	PORTA = c;		// 숫자 데이터 출력
	_delay_ms(10);	// 0.01 초 간격으로 전환
}

void FND_4(char *inf) // segment Image 배열
{
	for(int i = 0;i < 4;i++)
	{		
		seg(i, *(inf+i));
	}
}

void Trans(int num)  // 정수를 입력받아서 16진수 문자열로 변환 : 65535 ==> 0xFFFF
{	
	int n4 = num / 0x10000;
	num %
}
```
