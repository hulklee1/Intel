#include <iostream>
#include "haksang.h"
int main()
{
	haksang p1("JamesLee", 17, "전자공학", 3);
	p1.Show();
	p1.SetSub("국어", 90);	p1.Show();  // 
	p1.SetSub("영어", 90);	p1.Show();  // 
	p1.SetSub("수학", 90);	p1.Show();  // 
	p1.SetSub("미술", 90);	p1.Show();  // 
}
