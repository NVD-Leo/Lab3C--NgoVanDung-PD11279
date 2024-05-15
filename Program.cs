namespace Lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai1");
            string path = "data.txt";
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
                {
                    Console.WriteLine("username: myUsername");
                    Console.WriteLine("password: myPassword");
                    string line;
                }
            }
           using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8)) 
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            // bai2
            Console.WriteLine("-----------------------");
            Console.WriteLine("Bai2:");
            string username = "myusername";
            string password = "mypassword";
            DateTime time = DateTime.Now;


            using (StringWriter stringWriter = new StringWriter())
            {
                stringWriter.WriteLine($"Username: {username}");
                stringWriter.WriteLine($"Password: {password}");
                stringWriter.WriteLine($"Time: {time}");

                using (StringReader stringReader = new StringReader(stringWriter.ToString()))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            //bai3
            Console.WriteLine("-----------------------");
            Console.WriteLine("Bai3:");
            string dataFolderPath = "data";
            Directory.CreateDirectory(dataFolderPath);

            string dataFilePath = Path.Combine(dataFolderPath, "data.txt");
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                writer.WriteLine("Msvv: 123456");
                writer.WriteLine("Họ và tên: Nguyễn Văn A");
            }
            string data2FolderPath = "data2";
            Directory.CreateDirectory(data2FolderPath);
            DirectoryInfo dataDirectory = new DirectoryInfo(dataFolderPath);
            foreach (FileInfo file in dataDirectory.GetFiles())
            {
                string destinationFilePath = Path.Combine(data2FolderPath, file.Name);
                file.CopyTo(destinationFilePath, true);
            }

            Console.WriteLine("Sao chép hoàn tất!");
        }
    }



}
    

