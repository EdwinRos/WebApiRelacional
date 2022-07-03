namespace WebApiRealcional.Data
{
    public class UserEmail
    {
        public string name { get; set; }

        public string middleName { get; set; }

        public string generateEmail()
        {

            return name == null || middleName == null ? "Datos vacios ":$"{name.ToLower()}{middleName.ToLower()}@mail.com";
        }
    }
}
