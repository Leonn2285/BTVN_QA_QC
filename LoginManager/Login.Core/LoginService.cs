using System;

namespace Login.Core
{
    public class LoginService
    {
        public LoginService(Database database)
        {
            this.database = database;
        }
        private Database database;
        public bool CheckUser(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                throw new ArgumentException("The Username don't allow null or empty");
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                throw new ArgumentException("The Pass don't allow null or empty");
            }

            string passActual = database.GetPass(user);
            return pass == passActual;
        }

        public void towers(int n, char from, char to, char aux)
        {
            //Nếu chỉ còn 1 đĩa thì chuyển trực tiếp giữa hai cọc
            if (n == 1)
                Console.WriteLine("Di chuyển đĩa 1 từ {0} tới {1}", from, to);
            else
            {
                //Gọi hàm đệ quy di chuyển n-1 đĩa tới cọc phụ
                towers(n - 1, from, aux, to);
                Console.WriteLine("Di chuyển đĩa {0} từ {1} tới {2}", n, from, to);
                //Gọi hàm đệ quy di chuyển n-1 đĩa từ cọc phụ về cọc ban đầu
                towers(n - 1, aux, to, from);
            }
        }

    }
}
