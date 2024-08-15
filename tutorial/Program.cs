using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    enum MenuOption//tutorial quản lý menu với enum
    {
        ShowList = 1,
        SortByAge = 2,
        Exit = 3
    }
    static void Main(string[] args)
    {
        int choice;
        bool check = false;
        bool isValid = false;
        Function function = new Function();
        do
        {
            Console.WriteLine("menu");
            Console.WriteLine("1 show list sinh vien");
            Console.WriteLine("2 sap xep sinh vien theo tuoi");
            Console.WriteLine("3 exit");
            do//thực thi rồi mới check điều kiện nên sử dụng do while thay vì while
            {
                Console.WriteLine("nhap chuc nang muon dung: ");
                string tmpChoice = Console.ReadLine();
                isValid = int.TryParse(tmpChoice, out choice);
                if (choice <= 0 || choice > Enum.GetValues(typeof(MenuOption)).Length || !isValid)
                {
                    Console.WriteLine("khong hop le!");
                }
            } while (choice <= 0 || choice > Enum.GetValues(typeof(MenuOption)).Length || !isValid);//thỏa điều kiện thì tiếp tục lặp không thỏa thì phá vòng lặp
            MenuOption menuChoice = (MenuOption)choice;//ép kiểu int thành enum
            switch (menuChoice)
            {
                case MenuOption.ShowList:
                    function.showList();
                    break;
                case MenuOption.SortByAge:
                    function.showByAge();
                    break;
                case MenuOption.Exit:
                    Console.WriteLine("ket thuc");
                    Environment.Exit(0);
                    break;
            }
        } while (choice <= Enum.GetValues(typeof(MenuOption)).Length && choice > 0);
    }
}
