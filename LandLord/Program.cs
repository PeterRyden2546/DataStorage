using LandLord.Services;

MenuService menuService = new();

while (true)
{
    Console.Clear();
    await menuService.MainMenu();
    Console.ReadKey();
}


