#include <iostream>
class AAA
{
private:
	int a1;
protected:
	int a2;
public:
	int a3;
	AAA() { printf("A\n"); }
	//AAA(BBB) { printf("A(B)\n"); }
	~AAA() { printf("~A\n"); }

	void name() { printf("class name = AAA\n"); }
};
class BBB : protected AAA
{
public:
	int b1;
	int b2;
	int b3;
	BBB() { printf("B\n"); a3 = 10; }
	~BBB() { printf("~B\n"); }

	//void Test() { printf("a1=%d  a2=%d  a3=%d\n", a1, a2, a3); }
	void name() { printf("class name = BBB\n"); }
};
class C
{
public:
	C() { printf("_C_\n"); }
	virtual void func1() const = 0 {}
	virtual void func2() = 0 {}
};
class C1 : public C
{
public:
	C1() { printf("_C1_\n"); }
	virtual void func1() const
	{
		printf("func1_in_C1_\n");
	}
	virtual void func2()
	{
		printf("func2_in_C1_\n");
	}
};

void func()
{
	printf("function start...\n");
	//AAA *a = new AAA();
	BBB *b = new BBB();
	b->name();
	//printf("a1=%d  a2=%d  a3=%d\n", b->); 

	AAA* a = (AAA*)b;
	a->name();  //	((AAA*)b)->name();
	printf("a3=%d\n", ((AAA*)b)->a3);
	delete b; 
	//delete a;
	printf("function end.\n");
}

void func1()
{
	printf("function1 start...\n");

	AAA *a = new AAA();
	a->name();

	BBB* b = (BBB*)a;
	b->name();  //	((AAA*)b)->name();
	printf("b1=%d\n", ((BBB*)a)->b1);
	delete a; 

	printf("function1 end.\n");
}
int main()
{
	printf("Program start...\n");
	//C c;
	C1 c1;
	c1.func1();
	//////AAA a;
	////BBB b;
	//////AAA a = b;  // 복사 생성자
	////func();
	//////func1();
	printf("program end.\n");
}
