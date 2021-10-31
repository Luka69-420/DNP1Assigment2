using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace WebApplicationAssigment.Data
{
    public class AdultDataList
    {
        private IList<Adult> Adults { get; set; }
        private IList<User> Users { get; set; }
        
        private IList<Family> Families { get; set; }

        private const string AdultsFile = "adults.json";
        private const string UsersFile = "users.json";
        private const string FamilieFile = "families.json";

        public AdultDataList()
        {
            Adults = File.Exists(AdultsFile) ? ReadData<Adult>() : new List<Adult>();
            Users = File.Exists(UsersFile) ? ReadData<User>() : new List<User>();
            Families = File.Exists(FamilieFile) ? ReadData<Family>() : new List<Family>();
        }
        
        public static IList<T> ReadData<T>()
        {
            using var jsonReader = File.OpenText(AdultsFile);
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }

        public static IList<T> ReadFamiliesData<T>()
        {
            using var jsonREader = File.OpenText(FamilieFile);
            return JsonSerializer.Deserialize<IList<T>>(jsonREader.ReadToEnd());
        }

        public static IList<T> ReadUserData<T>()
        {
            using var jsonReader = File.OpenText(UsersFile);
            return JsonSerializer.Deserialize<IList<T>>(jsonReader.ReadToEnd());
        }

        public void SaveChanges(Adult adult)
        {
            using var jsonReader = File.OpenText(AdultsFile);
            Adults = JsonSerializer.Deserialize<List<Adult>>(jsonReader.ReadToEnd());
            
            Adults?.Add(adult);

            var jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using var outputFile = new StreamWriter(AdultsFile, false);
            outputFile.Write(jsonAdults);
        }
        
        public void SaveFamilieChanges(Family family)
        {
            using var jsonReader = File.OpenText(FamilieFile);
            Families = JsonSerializer.Deserialize<List<Family>>(jsonReader.ReadToEnd());
            
            Families?.Add(family);

            var jsonAdults = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using var outputFile = new StreamWriter(FamilieFile, false);
            outputFile.Write(jsonAdults);
        }
        
        public void SaveUser(User user)
        {
            using var jsonReader = File.OpenText(UsersFile);
            Users = JsonSerializer.Deserialize<List<User>>(jsonReader.ReadToEnd());
            
            Users?.Add(user);

            var jsonUsers = JsonSerializer.Serialize(Users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using var outputFile = new StreamWriter(UsersFile, false);
            outputFile.Write(jsonUsers);
        }

        public User Login(User user)
        {
            using var jsonReader = File.OpenText(UsersFile);
            Users = JsonSerializer.Deserialize<List<User>>(jsonReader.ReadToEnd());
            
            foreach(var item in Users)
            {
                if (item.Username.Equals(user.Username) && item.Password.Equals(user.Password))
                {
                    return user;
                }
                else
                {
                    Console.WriteLine("No such user exists...");
                }
            }
            return null;
        }

        
        public IList<Adult> GetAdults()
        {
            IList<Adult> allAdults =  new List<Adult>(Adults);
            allAdults =  ReadData<Adult>();
            return allAdults;
        }

        public Adult AddAdult(Adult adult)
        {
            Adults.Add(adult);
            ReadData<Adult>();
            return adult;
        }

        public void RemoveAdult(int adultId)
        {
            Adults.RemoveAt(adultId);
            ReadData<Adult>();
        }

        
        public IList<Family> GetFamilies()
        {
            IList<Family> allFamilies =  new List<Family>(Families);
            allFamilies =  ReadFamiliesData<Family>();
            return allFamilies;
        }

        public Family AddFamily(Family family)
        {
            Families.Add(family);
            ReadFamiliesData<Family>();
            return family;
        }

        public void RemoveFamily(int HouseNo)
        {
            Families.RemoveAt(HouseNo);
            ReadFamiliesData<Family>();
        }


        public IList<User> GetUsers()
        {
            IList<User> users = new List<User>(Users);
            users = ReadUserData<User>();
            return users;
        }

        public User AddUser(User user)
        {
            Users.Add(user);
            ReadUserData<User>();
            return user;
        }


        public void RemoveUser(int userId)
        {
         Users.RemoveAt(userId);
         ReadUserData<User>();
        }
    }
}