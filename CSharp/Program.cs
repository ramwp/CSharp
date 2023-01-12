
using System;


namespace CSharp
{
    class Program
    {

       enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {

            // 데이터 + 로직
            // 체력 0
            // s : signed (음수를 포함)
            // u : unsigned 부호가 존재하지 않음(음수를 미포함)
            // byte(1바이트 0 ~ 255), short(2바이트-3만 ~ 3만), int(4바이트, -21억~21억), long(8바이트, )
            // sbyte(1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트, 0 ~ 43억), ulong(8바이트)
            int hp;
            short level = 100;
            // 아이템 마다 고유의 식별번호 id가 붙는데 오래되면 새로 생성되는 아이템의 id 값이 매우 커지므로
            // long으로 시작하는 것이 좋다
            long id = 0;
            hp = 100;
            
            // attack 은 byte 타입이므로 0이 최소값이다. 따라서 --를 하면 255가 된다.
            byte attack = 0;
            attack--;
            Console.WriteLine("Hello Number ! {0}", attack);

            // 2진수
            // 0b00 0b01
            // 0b10001111 = 0x 1000 1111

            // 16진수
            // 0x00 0x01 0x02
            // 0x10

            // signed 타입의 경우 MSB를 부호비트로 사용
            // 2의 보수를 사용하여 음수를 표현
            // -128 : 0b 1000 0000
            // -1 을 표현 하려면 ? 
            // => -128인 0b 1000 0000에
            //     127인 0b 0111 1111을 더하면 된다.
            // => -1  은 0b 1111 1111이다
            // 2의 보수를 사용하면 한 숫자에서 그의 반대 부호인 수를 찾는데
            // 용이하다.
            // 2의 보수를 이용하여 52의 음수를 구하는 방법
            // 1. 52의 비트를 반전시킨다. 
            //     0b 0011 0100 => 0b 1100 1011
            // 2. 반전시킨 값에 1을 더한다.
            //     0b 1100 1011 + 1 = 0b 1100 1100
            // = -52

            // 불리언(1바이트), 소수, 문자, 문자열 형식
            
            // bool : 1바이트, (참/거짓)
            // 1비트 보다 1바이트로 타입을 설계하는 것이 접근하기 빠르기 때문에
            bool b;
            b = true; // 1을 넣어도 true
            b = false;

            // 실수 타입
            // float(4바이트), double(8바이트) : double 타입이 정밀도가 높고 다룰 수 있는 수의 크기가 크다.
            // 일반적으로 float 은 7자리 이후부터 정밀도가 떨어지고 오차가 발생한다. 
            // 정수의 연산보다 실수 타입의 연산이 비용이 많이 발생한다.
            // float 타입의 리터럴에는 f를 붙여줘야 한다.
            // f 를 붙이지 않은 실수 리터럴은 기본적으로 double 타입으로 간주한다.
            float f = 3.14f;
            double d = 3.14;

            // 문자 타입
            // 정수형이지만 문자의 표현을 위해 존재하는 타입이다.
            // 숫자를 저장하긴 하지만 보통 'a' 와 같은 문자를 입력하게 된다.
            // 숫자를 입력하게 되면 문자를 표현하기 위한 코드로 인지하게 된다.
            // 딱 하나의 문자만 입력할 수 있다.
            // 할당할 리터럴은 작은 따움표 안에 하나의 문자가 들어가 있는 형태
            // char (2바이트)
            char c = 'A';


            // 문자열 타입
            // string 
            string str = "Hello World";
            Console.WriteLine("{0}", str);


            // 타입 캐스팅
            // 서로 다른 타입의 변수를 할당하거나 연산할 경우
            // 타입이 다르기 때문에 변환해주어야 한다.
            int a = 1000;
            // 4바이트의 크기의 int 타입의 변수를 2바이트 크기인 short 타입으로 변환하였으므로 손실이 발생한다. 
            // 상위 비트에 있는 데이터가 손실된다.
            short abc = (short)a;

            // 작은 타입의 변수를 큰 타입의 변수에 할당하는 것은 문제가 발생하지 않는다.
            short smallerTypeVar = 1000;
            int largeTypeVar = smallerTypeVar;


            // 바구니의 크기가 같긴한데, 부호가 다른 경우
            byte bVar = 255;
            sbyte sbVar = (sbyte)bVar;
            // sbtye는 부호가 존재하기 때문에 최상위 비트(MSB)를 부호비트로 사용하여
            // byte 에서 표현하는 값과 차이가 있다.
            // bVar  => 0xFF = 0b 1111 1111 => 255
            // sbVar => 0xFF = 0b 1111 1111 =>  -1 (MSB를 음수로 사용)

            // 3. 소수
            // float 에서 double 로 변환하거나
            // double 에서 float 으로 변환하면 정확하지 않은 인접한 값으로 변환될 가능성이 있다.
            // 따라서 소수를 비교할 때 일정한 오차를 감안하고 비교를 해야 한다.
            float fVar = 3.1414f;
            double dVar = fVar;

            
            // 연산자
            
            // + - * / %
            // +=, -=, *=, /=, %=
            int wHp = 100;

            wHp = 100 + 1; Console.WriteLine("100 + 1 = {0}", wHp);
            wHp = 100 - 1; Console.WriteLine("100 - 1 = {0}", wHp);
            wHp = 100 * 2; Console.WriteLine("100 * 2 = {0}", wHp);
            wHp = 100 / 2; Console.WriteLine("100 / 2 = {0}", wHp);
            wHp = 100 % 3; Console.WriteLine("100 % 3 = {0}", wHp);


            //  hp++, hp--, ++hp, --hp
            wHp = 1;
            Console.WriteLine("wHp++ : {0}", wHp++);
            Console.WriteLine("wHp   : {0}", wHp);
            Console.WriteLine("++wHp : {0}", ++wHp);
            Console.WriteLine("wHp-- : {0}", wHp--);
            Console.WriteLine("wHp   : {0}", wHp);
            Console.WriteLine("--wHp : {0}", --wHp);


            // 비교 연산
            // < <= > >= == !=
            hp = 100;
            int wLevel = 50;
            
            bool bVar1 = (hp == 100);

            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);


            // &&(and) ||(or) !(not)
            // b = 살아있거나, 고렙 유저이거나, 둘 중 하나인가요?
            bool isAliveHighLevel = isAlive || isHighLevel;

            // c = 죽은 유저인가요?
            bool isDeadUser = !isAlive;


            // 비트 연산자
            // << >> &(and) |(or) ^(xor) ~(not)
            // <<= >>= &= |= ^= ~=

            int wId = 123;
            uint uNum = 8;
            int wKey = 401;

            // xor 을 두번하면 원래 숫자로 되돌아온다. (암호학에서 사용)
            int en_id = wId ^ wKey;
            int de_id= a ^ wKey;

            // id 를 네트워크상에서 그냥 보내면 해킹 위험이 있다
            // 따라서 key 를 이용하여 위와 예시 처럼 암호화를 하여 보내고 
            // 중간에 암호화된 정보를 가로채어도 key 값을 모르면 정보를 복원할 수 없다
            // 받는 쪽에서 다시 key 를 이용하여 값을 복원한다.


            // 연산자 우선순위
            // 1. ++, --
            // 2. * / %
            // 3. + -
            // 4. << >>
            // 5. < >
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. |
            // ..


            // 동적 타입 : 가독성과 잘못된 데이터의 입력의 위험으로 인해 권장하지는 않는다.
            var num = 3;
            var num2 = "Hello world";

            // 조건문
            hp = 10;
            bool isDead = (hp <= 0);

            if (isDead)
            {
                Console.WriteLine("You are dead!");
            }
            else
            {
                Console.WriteLine("You are alive!");
            }


            // if ~ else if  ~ else 문으로 가위바위보 게임
            int choice = 0;

            if (choice == 0)
            {
                Console.WriteLine("가위");
            }
            else if (choice == 1) 
            {
                Console.WriteLine("바위");

            }
            else if (choice == 2)
            {
                Console.WriteLine("보");
            }
            else
            {
                Console.WriteLine("치트키");
            }


            // switch ~ case
            // switch case 문으로 표현할 수 있는 것은 if  ~ else 문으로 표현할 수 있다.
            // 하지만 그 반대는 성립하지 않는다.
            // if 문이 switch 문 보다 빠를 수 있다.
            // if 문이 응용 범위가 넓을 수 있다. switch 문은 복잡한 조건을 사용하기 어렵다.

            switch (choice)
            {
                case 1:
                    Console.WriteLine("가위입니다.");
                    break;
                case 2:
                    Console.WriteLine("바위입니다.");
                    break;
                case 3:
                    Console.WriteLine("보입니다.");
                    break;
                default:
                    Console.WriteLine("다 실패했습니다.");
                    break;
            }

            // 삼항연산자
            int number = 25;
            bool isPair = ((number % 2) == 0 ? true : false);

            // if 문을 사용하는 경우
            if ((number % 2) == 0)
            {
                isPair = true;
            }
            else
            {
                isPair = false;
            }



            // 가위바위보 게임
            Random rand = new Random();
            int comChoice = rand.Next(0, 3); // 0 ~ 2 사이의 랜덤값
            int userChoice = Convert.ToInt32(Console.ReadLine()); // 한 줄 입력받아서 32비트 크기의 Integer 타입으로 변환
            string userChoiceString = "";
            string comChoiceString = "";


            // 상수형
            const int SCISSORS = 0;
            const int ROCK = 1;
            const int PAPER = 2;

            // 유저 
            switch (userChoice)
            {
                case SCISSORS:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    userChoiceString = "가위";
                    break;
                case ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    userChoiceString = "바위";
                    break;
                case PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    userChoiceString = "보";
                    break;
            }


            // 컴퓨터 랜덤
            switch (comChoice)
            {
                // enum 타입이기 때문에 타입 캐스팅을 해주어야 한다.
                case (int)Choice.Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    comChoiceString = "가위";
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    comChoiceString = "바위";
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    comChoiceString = "보";
                    break;
            }

            // 승리 무승부 패배 (유저 관점에서)
            if (userChoice == SCISSORS)
            {
                if (comChoice == SCISSORS)
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 무승부입니다.", userChoiceString, comChoiceString);
                } 
                else if (comChoice == ROCK)
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 패배입니다.", userChoiceString, comChoiceString);
                }
                else
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 승리입니다.", userChoiceString, comChoiceString);
                }

            } 
            else if (userChoice == ROCK)
            {
                if (comChoice == SCISSORS)
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 승리입니다.", userChoiceString, comChoiceString);
                }
                else if (comChoice == ROCK)
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 무승부입니다.", userChoiceString, comChoiceString);

                }
                else
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 패배입니다.", userChoiceString, comChoiceString);

                }
            }
            else
            {
                if (comChoice == SCISSORS)
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 패배입니다.", userChoiceString, comChoiceString);

                }
                else if (comChoice == ROCK)
                {

                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 승리입니다.", userChoiceString, comChoiceString);

                }
                else
                {
                    Console.WriteLine("유저 : {0}, 컴퓨터 : {1} => 무승부입니다.", userChoiceString, comChoiceString);

                }
            }
            

        }
    }
}