Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "алуа")
{
        Console.WriteLine("Ура, это же АЛУА!");
        
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}