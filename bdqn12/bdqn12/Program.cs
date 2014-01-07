using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace bdqn12
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *1.生成文件流(bin文件)
             *2.生成字节流对象
             *3.序列化
             *4.关闭流
             */
            //FileStream fs = new FileStream("../../Users.bin",FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //Users myUser = new Users("老郑","qaz123");
            //bf.Serialize(fs, myUser);
            //fs.Close();

            /**
             * 1.创建文件流
             * 2.创建字节流
             * 3.反序列化
             * 4.关闭流
             */

            //FileStream fs = new FileStream("../../Users.bin",FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //Users myUser = bf.Deserialize(fs) as Users;
            //fs.Close();
            //Console.WriteLine(myUser.UserName);

            //Users myUser = new Users("老郑","qaz123");
            //Users myUser2 = new Users("老李","123456");
            //List<Users> data = new List<Users>();
            //data.Add(myUser);
            //data.Add(myUser2);

            //FileStream fs = new FileStream("../../data.bin",FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs,data);
            //fs.Close();


            //FileStream fs = new FileStream("../../data.bin",FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //List<Users> data = bf.Deserialize(fs) as List<Users>;
            //fs.Close();

            //foreach (Users item in data)
            //{
            //    Console.WriteLine(item.UserName);
            //}

            //Users myUser = new Users("老郑","qaz123");
            //Users myUser2 = new Users("老李","123456");

            //UsersData ud = new UsersData();

            //ud.ManyUsers.Add(myUser);
            //ud.ManyUsers.Add(myUser2);

            //FileStream fs = new FileStream("../../uData.bin",FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs,ud);
            //fs.Close();

            //FileStream fs = new FileStream("../../uData.bin",FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //UsersData ud = bf.Deserialize(fs) as UsersData;
            //fs.Close();

            //Console.WriteLine(ud.ManyUsers.Count);

            //ud.ManyUsers.Add(new Users("老周", "qwerty"));

            //FileStream fs2 = new FileStream("../../uData.bin",FileMode.Create);
            //BinaryFormatter bf2 = new BinaryFormatter();
            //bf2.Serialize(fs2,ud);
            //fs2.Close();


            ShopService ss = new ShopService();

            if (File.Exists("../../customer.bin"))
            {
                ss.load();
            }
            else
            {
                ss.Init();
                ss.save();
            }
            


        }
    }
}
