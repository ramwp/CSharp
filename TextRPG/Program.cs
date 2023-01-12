
using System;
using System.Xml;

namespace CSharp
{
    enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Magician = 3
    };

    struct PlayerInfo
    {
        // 앞에 접근 지시자를 생략하면 기본적으로 private
        public int hp;
        public int attack;
        public PlayerType type;
    }

    enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    struct Monster
    {
        public int hp;
        public int attack;
        public MonsterType type;
    }

    class Program
    {

        static PlayerType SelectPlayerType()
        {
            PlayerType result = PlayerType.None;
            while(result == PlayerType.None)
            {
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");
                string sel = Console.ReadLine();
                
                switch (sel)
                {
                    case "1":
                        result = PlayerType.Knight;
                        break;
                    case "2":
                        result = PlayerType.Archer;
                        break;
                    case "3":
                        result = PlayerType.Magician;
                        break;
                    default:
                        result = PlayerType.None;
                        break;
                }
 
            }
            Console.WriteLine($"직업 선택 완료: {result}\n");
            return result;

        }

        static void CreatePlayer(PlayerType playerT, out PlayerType type, out int hp, out int attack)
        {
            type = playerT;
            switch(playerT)
            {
                case PlayerType.Knight:
                    hp = 100;
                    attack = 10;
                    break;
                case PlayerType.Archer:
                    hp = 75;
                    attack = 7;
                    break;
                case PlayerType.Magician:
                    hp = 50;
                    attack = 15;
                    break;
                default: // out 키워드가 붙은 변수는 마지막에 반드시 값이 할당되어 있어야 한다 따라서 대입되지 않는 경우는 없어야 한다.
                    type = PlayerType.None;
                    hp = -1;
                    attack = -1;
                    Console.WriteLine($"{playerT}잘못된 값이 함수에 입력됨.");
                    break;
            }
        }

        static void CreatePlayer(PlayerType playerT, out PlayerInfo player)
        {
            player.type = playerT;

            switch (playerT)
            {
                case PlayerType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case PlayerType.Archer:
                    player.hp = 75;
                    player.attack = 7;
                    break;
                case PlayerType.Magician:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = -1;
                    player.attack = -1;
                    Console.WriteLine($"CreatePlayer 구조체 버전 : {playerT}, {player}");
                    break;
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random randSelect = new Random();
            int randMonsterNumber = randSelect.Next(1, 4); // 1 ~ 3 중 랜덤하게 출력

            switch (randMonsterNumber)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine($"{MonsterType.Slime}이 생성되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    monster.type = MonsterType.Slime;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine($"{MonsterType.Orc}이 생성되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    monster.type = MonsterType.Slime;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine($"{MonsterType.Skeleton}이 생성되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    monster.type = MonsterType.Slime;
                    break;
                default:
                    monster.hp = -2;
                    monster.attack = -2;
                    monster.type = MonsterType.None;
                    Console.WriteLine("몬스터를 결정한 랜덤 변수의 값의 범위에 벗어남.");
                    break;
            }
        }
        static void Fight(ref PlayerInfo player, ref Monster monster)
        {
            while(true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if (monster.hp <= 0 )
                {
                    Console.WriteLine("승리했습니다.");
                    Console.WriteLine($"유저 남은 체력 : {player.hp}");
                    break;
                }

                // 몬스터가 플레이어를 공격
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다.");
                    Console.WriteLine($"몬스터 남은 체력 : {monster.hp}");
                    break;
                }
            }
        }
        static void EnterField(ref PlayerInfo player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다.");

                // 몬스터 생성
                Monster monster;

                // 랜덤으로 세가지 몬스터 중 하나를 생성
                CreateRandomMonster(out monster);

                // [1] 전투 모드로 진입
                // [2] 일정 확률로 마을로 도망
                Console.WriteLine("[1] 전투 모드로 돌입.");
                Console.WriteLine("[2] 일정 확률로 마을로 도망.");

                string sel = Console.ReadLine();
                if (sel == "1")
                {
                    Fight(ref player, ref monster);
                } 
                else if (sel == "2")
                {
                    // 33%
                    Random randSelect = new Random();
                    int randPercent = randSelect.Next(0, 101);
                    if (randPercent <= 33)
                    {
                        Console.WriteLine("33% 확률로 도망치는데 성공");
                        break;
                    }
                    else
                    {
                        // 도망치는데 실패하면 싸움
                        Fight(ref player, ref monster);
                    }
                }

                
            }
        }

        static void EnterGame(ref PlayerInfo player)
        {

            while (true)
            {
                Console.WriteLine("마을에 접속했습니다.");
                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기");

                string sel = Console.ReadLine();
                
                if (sel == "1")
                {
                    // 필드 진입 
                    EnterField(ref player);
                    break;
                }
                else if (sel == "2")
                {
                    // 로비로 돌아가기
                    break;
                }

                
            }
        }

        static void Main(string[] args)
        {
            // 직업 선택
            PlayerType playerType1 = SelectPlayerType();
            PlayerType playerType2 = SelectPlayerType();

            // 캐릭터 생성.
            PlayerInfo player1;
            PlayerInfo player2;

            // CreatePlayer() : 선택한 직업에 따라서 체력과 공격력 할당
            // 기사(100/10), 궁수(75/7) 법사(50/15)
            CreatePlayer(playerType1, out player1.type, out player1.hp, out player1.attack);
            CreatePlayer(playerType2, out player2);
            Console.WriteLine($"유저1 정보 => 직업: {player1.type}, 체력: {player1.hp}, 공격력: {player1.attack}");
            Console.WriteLine($"유저2 정보 => 직업: {player2.type}, 체력: {player2.hp}, 공격력: {player2.attack}");

            // 필드로 가서 몬스터랑 싸운다.
            EnterGame(ref player1);

        }

    }
}