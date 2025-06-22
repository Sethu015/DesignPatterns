using System.Text.Json;

namespace Prototype
{
    public class User
    {
        public string UserName { get; set; }
        public string Role {  get; set; }
        public List<Previlages> Previlages { get; set; }

        public User DeepCopy()
        {
            return new User
            {
                UserName = this.UserName,
                Role = this.Role,
                Previlages = new List<Previlages>(this.Previlages.ConvertAll(x => x.Clone()))
            };

            //Alternate using Serialize and Deserialize

            //var serializedObj = JsonSerializer.Serialize(this);
            //return JsonSerializer.Deserialize<User>(serializedObj);
        }
    }
}
