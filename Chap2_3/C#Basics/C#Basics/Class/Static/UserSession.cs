namespace C_Basics.Class.Static
{
    public class UserSession
    {
        public string UserName { get; }

        // static: single value shared by every UserSession
        public static int ActiveUsers = 0;

        public UserSession(string userName)
        {
            UserName = userName;
            ActiveUsers++;
            Console.WriteLine($"{UserName} logged in. ActiveUsers = {ActiveUsers}");
        }

        public void Logout()
        {
            ActiveUsers--;
            if (ActiveUsers < 0) ActiveUsers = 0;
            Console.WriteLine($"{UserName} logged out. ActiveUsers = {ActiveUsers}");
        }
    }

    // Small demo you can call from Main()
    public static class UserSessionDemo
    {
        public static void RunDemo()
        {
            var u1 = new UserSession("Arun");
            var u2 = new UserSession("Priya");

            Console.WriteLine($"Read static directly: ActiveUsers = {UserSession.ActiveUsers}");

            u1.Logout();
            u2.Logout();

            Console.WriteLine($"Final ActiveUsers = {UserSession.ActiveUsers}");
        }
    }
}

/* Static members belong to the class itself, not the object. There’s only one copy, shared across everything.

It clicked.

UserName was an instance member. Each user had their name.
ActiveUsers was a static member. It was shared and didn’t need any object to exist.
So when I wrote UserSession.ActiveUsers, I was accessing the static member directly from the class, not from any specific user.
It was like a global counter that all users could see and update.

*/
