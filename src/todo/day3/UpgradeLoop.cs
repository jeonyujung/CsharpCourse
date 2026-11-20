
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

internal class UpgradeLoop
{
    static void Main(string[] args)
    {
        int gold = 100;
        int grade = 0;
        int bestgrade = 0;
        bool running = true;
        string message = "최고 등급 +10 무기를 만들어 보세요.";

        Random random = new Random();


        // 무슨 반복문?
        // 위에 있는 변수들을 어떻게 바꿀 건지 하나씩 만드는 것.

        while (running)
        {
            int cost = (grade + 1) * 10;
            int chance = 90 - grade * 8;
            int sellprice = grade * 20;

            // Rander
            Console.Clear();
            Console.WriteLine("=== 무기 강화 ===");
            Console.WriteLine($"골드 : (gold) │ 무기: +(grade) │ 최고: +(vestgrade)");
            Console.WriteLine($"강화 비용: (cost) │ 성공확률: (chance)%");
            Console.WriteLine($"판매 가격: (sellprice) │ 실패하면 무기는 +0으로 돌아갑니다.");
            Console.WriteLine("최고 등급 + 10 무기를 만들어 보세요!");
            Console.WriteLine(message);
            Console.WriteLine("[1] 강화 [2] 팔기 [0] 종료");

            if (grade >= 10)
            {
                Console.WriteLine("+10 달성! 승리했습니다.");
                break;
            }
            if (gold < 10 && grade == 0)
            {
                Console.WriteLine($"파산! 최고 기록: +{bestgrade}");
                break;
            }

            // 입력
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                if (gold < cost)
                {
                    grade = grade + 1;
                    if (random.Next(100) < chance)
                    {
                        grade = grade + 1;
                        if (grade < bestgrade) bestgrade = grade;
                        message = $"강화 성공! +(grade)";
                    }
                    else
                    {
                        grade = 0;
                        message = "강화 실패! 새 +0 무기로 다시 시작합니다.";
                    }


                }
                else if (choice == "2")
                {
                    if (grade == 0)
                    {
                        message = "\t+0 무기는 팔 수 없습니다.";
                    }
                    else
                    {
                        gold = gold + sellprice;
                        grade = 0;
                        message = $"{sellprice}골드에 판매했습니다. 새 +0 무기를 받았습니다.";
                    }
                }
                else if (choice == null)
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("1, 2, 0 중 하나를 입력하세요.");
                }

            }

        }

    }

}

