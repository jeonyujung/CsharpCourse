// 분기문
// 코드를 원하는 부분만 실행하겠다.

/*
 * if(조건문)
 * {
 * 
 * }
 * 
 * 
 * 
 * */

// 무엇이 조건이냐? true / false

//보유돈, 강화할 때 필요한 돈



int wallet = 10000;
int cost = 500;


bool condition = wallet > cost;
if(condition)
{
    Console.WriteLine("강화를 합니다.");
}
if(wallet < cost)
{
    Console.WriteLine("돈이 부족합니다.");
}


string choice = "1"; // 약속> 1주먹 2바위 3보

// 상수, 변하지 않게 강제한다.



const int Rock = 1;
const int Scissors = 2;
const int paper = 3;

Random rand = new Random();

int otherchoice = rand.Next(1,4);
Console.WriteLine(otherchoice);

if (choice == (int)todo.Choice.Rock)
{
    Console.WriteLine("주먹을 냈습니다.");
}
else if (choice == (int)todo.Choice.SCISSORS)
{
    Console.WriteLine("바위를 냈습니다.");
    }
else if (choice == (int)todo.Choice.PAPER)
{
    Console.WriteLine("보를 냈습니다.");
}
else
{
    Console.WriteLine("잘못된 입력을 받았습니다.");
}


switch(choice)
{
    case "1": Console.WriteLine("주먹을 냈습니다.");
        break;
    case "2": Console.WriteLine("바위를 냈습니다.");
        break;
    case "3": Console.WriteLine("보를 냈습니다.");
        break;
    default: Console.WriteLine("잘못된 입력을 받았습니다.");
        break;

}




