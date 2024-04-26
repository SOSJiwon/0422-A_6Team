using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRpgGame
{
    public class ChoiceLink  /////버튼 연결 함수 
    {
        Map map = new Map();
  
        //map(n)Choice를 Map번호에 맞춰 실행시켜주는 함수
        public void choice(int mapNumber, bool isCan, int playerChoice)
        {
            switch (mapNumber)
            {
                case 0:
                    map0Choice(isCan, playerChoice); 
                    break;

                case 1:
                    map1Choice(isCan, playerChoice);
                    break;

                case 2:
                    map2Choice(isCan, playerChoice);
                    break;
                case 12:
                    map12Choice(isCan, playerChoice);
                    break;

                case 3:
                    map3Choice(isCan, playerChoice);
                    break;
                case 13:
                    map13Choice(isCan, playerChoice);
                    break;
                case 23:
                    map23Choice(isCan, playerChoice);
                    break;

                case 4:
                    map4Choice(isCan, playerChoice);
                    break;
                case 14:
                    map14Choice(isCan, playerChoice);
                    break;

                case 5:
                    map5Choice(isCan, playerChoice);
                    break;
                case 15:
                    map15Choice(isCan, playerChoice);
                    break;
                case 25:
                    map25Choice(isCan, playerChoice);
                    break;

            }
       
        }


        //맵마다 링크 연결
        void map0Choice(bool isCan, int playerChoice)
        {
                        
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 0:
                        //마을
                        MainGame.mapNum = 0;
                        break;

                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 1;
                        break;

                    case 2:
                        //인벤토리
                        MainGame.mapNum = 2;
                        break;

                    case 3:
                        //상점
                        MainGame.mapNum = 3;
                        break;

                    case 4:
                        //여관
                        MainGame.mapNum = 4;
                        break;

                    case 5:
                        //던전
                        MainGame.mapNum = 5;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map1Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1 :
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map2Choice( bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1 :
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    case  2 :
                        //플레이어 인포
                        MainGame.mapNum = 12;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map12Choice(bool isCan, int playerChoice)
        {
            
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 0:
                        //플레이어 인포
                        MainGame.mapNum = 2;
                        break;

                    case 1:
                        MainGame.instructionNum = 1;
                        break;

                    case 2:
                        MainGame.instructionNum = 1;
                        break;

                    case 3:
                        MainGame.instructionNum = 1;
                        break;

                    case 4:
                        MainGame.instructionNum = 1;
                        break;

                    case 5:
                        MainGame.instructionNum = 1;
                        break;

                    case 6:
                        MainGame.instructionNum = 1;
                        break;

                    case 7:
                        MainGame.instructionNum = 1;
                        break;

                    case 8:
                        MainGame.instructionNum = 1;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }

        void map3Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    case 2:
                        //플레이어 인포
                        MainGame.mapNum = 13;
                        break;

                    case 3:
                        //플레이어 인포
                        MainGame.mapNum = 23;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map13Choice(bool isCan, int playerChoice)
        {
            
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 0:
                        //플레이어 인포
                        MainGame.mapNum = 3;
                        break;

                    case 1:
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        
                        break;

                    case 6:
                        
                        break;

                    case 7:
                        
                        break;

                    case 8:
                        
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map23Choice(bool isCan, int playerChoice)
        {
            
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 0:
                        //플레이어 인포
                        MainGame.mapNum = 3;
                        break;

                    case 1:
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }

        void map4Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    case 2:
                        //플레이어 인포
                        MainGame.mapNum = 14;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map14Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }

        void map5Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    case 2:
                        //플레이어 인포
                        MainGame.mapNum = 15;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map15Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 25;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }
        void map25Choice(bool isCan, int playerChoice)
        {
            if (isCan)
            {
                MainGame.instructionNum = 0;
                switch (playerChoice)
                {
                    case 1:
                        //플레이어 인포
                        MainGame.mapNum = 0;
                        break;

                    default:
                        MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
                        break;
                }
            }
            else
            {
                MainGame.instructionNum = 1; // 지시 : 올바른 값 입력
            }
        }

    }
}
