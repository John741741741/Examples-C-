Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ира")
{
    Console.WriteLine("Привет, мурлыка :)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}