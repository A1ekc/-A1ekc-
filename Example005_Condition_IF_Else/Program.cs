Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "misha")//ToLower -приводит буквы в нижний регистр
{
    Console.WriteLine("Yes, this is MISHAA");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}