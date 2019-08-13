/*첫째 줄에 두 정수 H와 M이 주어진다. (0 ≤ H ≤ 23, 0 ≤ M ≤ 59) 그리고 이것은 현재 상근이가 맞춰놓은 알람 시간 H시 M분을 의미한다.

입력 시간은 24시간 표현을 사용한다. 24시간 표현에서 하루의 시작은 0:0(자정)이고, 끝은 23:59(다음날 자정 1분 전)이다. 시간을 나타낼 때, 불필요한 0은 사용하지 않는다.*/
using System;

public class B2884 {
    public static void main() {
		string s = Console.ReadLine();
		string[] ss = s.Split();
		
		int a = int.Parse(ss[0]);
		int b = int.Parse(ss[1]);
		
		b-=45;
		
		if(b>=60){
			b-=60;
			a+=1;
		}
		else if(b<0){
			b+=60;
			a-=1;
		}
		
		if(a>=24){
			a=0;
		}
		else if(a<0){
			a=23;
		}
		
		Console.WriteLine(a+" "+b);
    }
}