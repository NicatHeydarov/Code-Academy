
namespace _09._03._2023.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person(string name,string Surname,byte Age)
        {
            this.Name = name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public string ShowInfo(string name,int age) 
        {
        return $"{name},{Surname} ,{Age}";
        }

    }
}
