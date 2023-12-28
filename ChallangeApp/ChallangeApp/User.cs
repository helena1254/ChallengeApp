namespace ChallangeApp
{
    public class User
    {
        User user1 = new User("Adam", "345695ffgggj");
        User user2 = new User("Anna", "345695ffgggj");
        User user3 = new User("Damian", "345695ffgggj");
        User user4 = new User("Marlena", "345695ffgggj");

        user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
        Console.WriteLine(result);

class User
        {
            private List<int> score = new List<int>();
            private List<int> score = new List<int>();
            public User(string login, string password)
            {
                this.Login = login;
                this.Password = password;


            }
            public string Login { get; private set; }
            public string Password { get; private set; }
            public int Result
            {
                get
                {
                    return this.score.Sum();
                }
            }
            public void AddScore(int number)
            {
                this.score.Add(number);
            }
        }

        internal void AddScore(int v)
        {
            throw new NotImplementedException();
        }
    }
}
