
namespace _09._03._2023.Models
{
    internal class Student : Person
    {
        public byte _point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _point = value;
                }
                else
                {
                    _point = 0;
                }
            }
        }
        public Student(string name, byte age, string surname, byte _point) : base(name, surname, age)
        {

            this.Name = name;
            this.Age = age;
            this.Surname = surname;
            this._point = _point;
        }
    }

}
