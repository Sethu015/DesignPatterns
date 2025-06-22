using Prototype;

var user1 = new User();
user1.UserName = "Sethu";
user1.Role = "Admin";
user1.Previlages = new List<Previlages>()
{
    new Previlages() {Key = "UserEdit",Value = "Allow"},
    new Previlages() {Key = "UserDelete", Value = "Allow" }
};

var user2 = user1.DeepCopy();
user2.UserName = "Akshayaa";
user2.Role = "Manager";
user2.Previlages.RemoveAt(1);
user2.Previlages.Add(new Previlages() { Key = "UserDelete", Value = "NotAllow" });

foreach (var item in user1.Previlages)
{
    Console.WriteLine($"Key {item.Key} , Value {item.Value}");
}
Console.WriteLine("---------------------");
foreach (var item in user2.Previlages)
{
    Console.WriteLine($"Key {item.Key} , Value {item.Value}");
}

Console.ReadLine();