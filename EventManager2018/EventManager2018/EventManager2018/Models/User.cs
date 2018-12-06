namespace EventManager2018.Models
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Blocked { get; set; }

        //Navigation Properties
        public Person Person { get; set; }

    }
}
