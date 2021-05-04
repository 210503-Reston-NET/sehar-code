using System;
namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            menu.start();
        }
    }
}
