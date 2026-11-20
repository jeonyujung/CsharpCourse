// 반복문
// 반복표현식을 줄일 수 있는 방법이 있을까?
// 프로그래머 반복을 진짜 싫어한다.

// for 반복문

// while반복문

// int a = 1;

// int score = 0;

// score = score + a;
// 9x9단

for (int a = 0 ; a < 10; a++)
{
    Console.WriteLine(a);
}

//for반복문은 , 100번 반복할거야 반복횟수 눈에 보일때만 쓰면 효율적이다.
// while반복문
// 무한반복문
//게임을 종료할 조건
//while 반복문은 언제 끝이 날지 모를때 쓰면 좋다.


int grade = 0;
bool gameFinish = grade >= 10;
while(true)
{

    grade++;
    Console.WriteLine($"현재 등급 : (grade)");

    if (gameFinish)
    {
        break;
    }
}