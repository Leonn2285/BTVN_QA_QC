namespace Login.Test
{
    using Login.Core;

    public class DatabaseStub : Database
    {

        public override string GetPass(string user)
        {
            if (user == "abc")
            {
                return "abc";
            }
            return "";
        }
    }
}