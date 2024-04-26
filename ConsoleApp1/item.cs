using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestRpgGame
{
    internal class Item
    {
        public static List<Item> items = new List<Item>(); // 리스트 선언


        public Item(string name, String desc, bool isHave, bool isTake, int adstat, int dpstat, int price, int idx)
        {
            Name = name; // 아이템 이름
            Desc = desc; // 아이템 설명
            IsHave = isHave; // 변동되는 변수 : 가지고 있는가?
            IsTake = isTake;
            ADStat = adstat;
            DPStat = dpstat;
            Price = price;
            IDX = idx; // 공개 X 아이템 인덱스
        }
        public String Name { get; }
        public String Desc { get; }
        public bool IsHave { get; set; }
        public bool IsTake { get; set; }
        public int ADStat { get; }
        public int DPStat { get; }
        public int Price { get; }
        public int IDX { get; set; }

        string[] itemname = { "아이템 1", "아이템 2", "아이템 3", "아이템 4", "아이템 5", "아이템 6", "아이템 7", "아이템 8" };
        string[] itemdesc = { "아이템 1 설명", "아이템 2 설명", "아이템 3 설명", "아이템 4 설명",
                "아이템 5 설명", "아이템 6 설명", "아이템 7 설명", "아이템 8 설명" };

        bool[] itemishave = { false, false, true, false, false, false, false, true };
        bool[] itemistake = { false, false, true, false, false, false, false, false };

        int[] itemadstat = { 10, 10, 10, 10, 10, 10, 10, 10 };
        int[] itemdpstat = { 10, 10, 10, 10, 10, 10, 10, 10 };

        int[] itemprice = { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
        int[] itemidx = { 1, 2, 3, 4, 5, 6, 7, 8 };



        public static void ItemHaveInTrue(int choice) // 아이템을 구매 할 경우 True로 바꿔주는 함수
        {
            foreach (Item item in items)
            {
                Console.WriteLine(choice);
                Console.WriteLine(item.IDX);
                if (choice == item.IDX)
                {
                    Console.WriteLine(item.IsHave);
                    switch (item.IsHave)
                    {
                        case false:
                            item.IsHave = true;
                            break;
                        case true:
                            item.IsHave = false;
                            break;
                    }
                    Console.WriteLine(item.IsHave);
                    Console.ReadLine();
                }
            }
        }
        public static void ItemTakeInTrue(int choice) // 아이템을 착용 할 경우 True로 바꿔주는 함수
        {
            foreach (Item item in items)
            {
                if (choice == item.IDX)
                {
                    switch (item.IsTake)
                    {
                        case false:
                            item.IsTake = true;
                            break;
                        case true:
                            item.IsTake = false;
                            break;
                    }
                }
            }
        }
        public int AllItemInShopScript(int mapNum) // 상점 아이템 스크립트 제작
        {
            if (mapNum == 23) // 아이템 판매 페이지
            {
                AllItemInHaveScript(mapNum);
                return 0;
            }
            
            if (mapNum == 13) // 아이템 구매 페이지
            {
                
                int count = 1;
                foreach (Item item in items)
                {
                    if (item.IsHave == false)
                    {
                        item.IDX = count;
                        Console.WriteLine(" " + count + ". " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + "\t | " + item.Price + item.IDX);
                        count++;
                    }
                    else item.IDX = 0;
                }
                return count-1;
            }
            else  // 상점 페이지
            {
                int count = 1;
                foreach (Item item in items)
                {
                    item.IDX = count;
                    if (item.IsHave == true)
                        Console.WriteLine(" - " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + "\t | " + "구매완료" + item.IDX);
                    else
                        Console.WriteLine(" - " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + "\t | " + item.Price + item.IDX);
                    count++;
                }
                return 0;
            }


        }
        public void AllItemInShopList()
        {
            for (int i = 0; i < itemname.Length; i++)
            {
                items.Add(new Item(itemname[i], itemdesc[i], itemishave[i], itemistake[i], itemadstat[i], itemdpstat[i], itemprice[i], itemidx[i]));
            }
        } // 초기설정 : 모든 아이템 상점 리스트에 집어넣기
        public int AllItemInHaveScript(int mapNum) //  소유한 아이템 스크립트 제작
        {
            if (mapNum == 2) // 인벤토리 페이지
            {
                int count = 1;
                foreach (Item item in items) 
                {
                    item.IDX = count;
                    // 가지고 있는 아이템만 생성
                    if (item.IsHave == true) { Console.WriteLine(" - " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + item.IDX + item.IsHave); }
                        else { Console.WriteLine(" 테스트 텍스트 보유하고있지않음 "+ item.Name + item.IDX); }
                    count++;
                }
                return 0;
            }
            else if (mapNum == 12) // 인벤토리 장착 페이지
            {
                int count = 1;
                foreach (Item item in items) 
                {
                    if (item.IsHave == true) // 가지고 있는 아이템만 나오도록
                    {
                        item.IDX = count;
                        if (item.IsTake == true) // 아이템을 착용하고 있다면 E 표시
                            Console.WriteLine(count + ". " + " [E] " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + item.IDX);
                        else
                            Console.WriteLine(count + ". " + "     " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + item.IDX);
                        count++;
                    }
                    else { Console.WriteLine(" 테스트 텍스트 보유하고있지않음 " + item.Name + item.IDX); }
                }
                return count - 1;
            }
            else // 상점 판매 페이지
            {
                int count = 1;
                foreach (Item item in items) 
                {
                    item.IDX = count;
                    if (item.IsHave == true) // 가지고 있는 아이템만 나오도록
                    {
                        Console.WriteLine(count + ". " + item.Name + "\t | 공격력 +" + item.ADStat + "  | 방어력 +" + item.DPStat + "  | " + item.Desc + "  | " + item.Price +" G" + item.IDX + item.IsHave);
                        count++;
                    }
                    else item.IDX = 0;
                }
                return count - 1;
            }
        }
    }
}
