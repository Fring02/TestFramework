namespace SeleniumDemoFramework.Generators
{
    public class EmailGenerator
    {
        public static string Generate()
        {
            //implement methods to generate *randomess* 
            return "random@random.com";
        }
    }

    public class NameGenerator
    {
        public static string Generate()
        {
            //implement methods to generate *randomess* 
            return "FooBar User";
        }
    }

    public static class PasswordGenerator
    {
        //implement methods to generate *randomess* or for unique validation test cases

        private static bool toggle = true;
        public static string Generate()
        {
            var password = "";
            password = toggle ? "Password" : "New Password";

            toggle = !toggle;
            LastGeneratedPassword = password;
            return password;
        }

        public static string LastGeneratedPassword { get; set; }
    }


    public class PhoneGenerator
    {
        public static string Generate()
        {
            //implement methods to generate *randomess* or other
            return "123-867-3509";
        }
    }



    public static class UserGenerator
    {
        public static User LastGeneratedUser;
        public static User Generate()
        {
            var user = new User
            {
                FullName = NameGenerator.Generate(),
                MobileNumber = PhoneGenerator.Generate(),
                EmailAddress = EmailGenerator.Generate(),
                Password = PasswordGenerator.Generate()
            };
            LastGeneratedUser = user;
            return user;
        }
    }

    public class User
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}