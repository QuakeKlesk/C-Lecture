Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, этоже МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}