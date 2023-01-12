
using System;
using System.ComponentModel;

namespace CSharp
{
    class Program
    {

        // 메소드 함수
        /*
         * 한정자 반환형식 이름(매개변수목록)
            {

            }
        */
        static void printHello()
        {
            Console.WriteLine("Hello World");
        }
        
        // 덧셈함수
        // 인수의 값을 복사하여 처리 하는 방법
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        // 인수의 값을 참조하여 처리하는 방법
        static void Sub(ref int a, ref int b)
        {
            a = a - b; 
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // out 키워드를 이용하여 외부로 값을 출력할 변수를 할당할 수 있다.
        // Divde 함수 밖에 있는 변수 num1, num2 를 파라미터 result1, resul2 의 인자로 할당하면
        // a , b의 몫과 나머지가 result1, result2 로 전달한 num1, num2에 저장된다.
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        // 함수 오버로딩
        // 함수 이름의 재사용
        // 반환타입이나, 매개변수의 순서는 영향이 미치지 않음
        // 함수의 이름은 같지만 매개변수의 개수에 따라서
        // 함수의 내용을 달리하여 다른 처리를 하고 싶은 경우 사용
        static float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }

        static float Add(float a, float b, float c)
        {
            float result = a + b + c;
            return result;
        }
        
        static double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        // 파라미터의 값을 디폴트로 정해줄 수 있음
        static int Add(int a, int b, int c = 0, float d=1.01f, double e = 3.0)
        {
            int result = a + b + c;
            Console.WriteLine($"{d} {e}");
            return result;
        }

        // 팩토리얼 메서드 구현 예제
        static int Factorial(int n)
        {
            int result = 1;
            for (int i=1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // 팩토리얼 메서드 (재귀함수)
        static int reFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * reFactorial(n - 1);
        }

        static void Main(string[] args)
        {
            // while 반복문
            int count = 5;

            while (count > 0)
            {
                Console.WriteLine("Hello World");
                count--;

            }

            do
            {
                // 조건식에 관계 없이 꼭 한번은 실행한다.
                Console.WriteLine("do while loop");
            } while (false);


            string answer;
            do
            {
                Console.WriteLine("exit ? [y/n]");
                answer = Console.ReadLine();
            } while (answer != "y");


            // for 문
            // for(초기화식; 조건식; 반복식)
            // {
                
            // }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello World");
            }

            int num = 97;
            bool isPrime = true;
            // break, continue 문
            for (int i = 1; i < 1000; i++)
            {
                // 특정 조건을 만족하면 탈출
                if (num % i == 0)
                {
                    //Console.WriteLine("소수가 아닙니다.");
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("소수입니다.");
            }
            else
            {
                Console.WriteLine("소수가 아닙니다.");
            }

            for(int i = 0; i <= 100; i++)
            {
                if((i % 3) != 0)
                {
                    continue;
                }

                Console.WriteLine($"3으로 나누어지는 숫자 발견 : {i}");
            }


            // 값 복사
            int result = Program.Add(4, 5);
           
            Console.WriteLine(result);
            int num1 = 1;
            int num2 = 2;
            // 참조 (ref 키워드를 사용)
            Program.Sub(ref num1, ref num2);
            Console.WriteLine(num1);
            Program.Swap(ref num1, ref num2);
            Console.WriteLine($"{num1}, {num2}");

            int result1, result2;
            
            // out 키워드로 출력될 값을 받을 변수를 지정하여 줄 수 있다.
            Program.Divide(10, 3, out result1, out result2);

            // 함수 오버로딩
            Console.WriteLine(Program.Add(1, 2));               // int 인자 두개를 전달받아 처리하는 Add
            Console.WriteLine(Program.Add(1.1f, 2.1f));         // float 인자 두개 전달받아 처리하는 Add
            Console.WriteLine(Program.Add(1.1f, 1.2f, 1.4f));   // float 인자 세개를 전달받아 처리하는 Add
            Console.WriteLine(Program.Add(1.1, 2.1));           // double 인자 두개를 전달받아 처리하는 Add
            Console.WriteLine(Program.Add(1, 2, 3, 4.1f));      // default로 값이 지정되는 파라미터가 존재
            Console.WriteLine(Program.Add(a: 1, b: 2, c: 3, d: 2.0f, e: 3.0)); // 파라미터를 직접 지정하여 인자를 할당할 수 있다.

            // 구구단 예제
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"[{i} 단]");
                for (int j = 1; j <= 9; j++ )
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("\n");
            }

            // 별찍기 예제
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*"); // WriteLine 메서드는 마지막에 줄바꿈을 하지만 Write 메서드는 줄바꿈을 하지 않음
                }
                Console.WriteLine();
            }

            // 팩토리얼 메서드 호출
            Console.WriteLine(Program.Factorial(5));
            Console.WriteLine(Program.reFactorial(5));
        }
        

    }
}