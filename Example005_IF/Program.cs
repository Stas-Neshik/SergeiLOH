    Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("ура это Маша");
}
else
{
    Console.Write ("Привет, ");
    Console.Write (username);
}