namespace Lab4
{
    public class Student : Person
    {
        public int Program { get; set; }// 1.Business 2.Computer 3.Science

        public override string ToString()
        {
            return $"Name :{Name}, Phone :{Phone}, Email :{Email}, Program : {Program}";
        }
    }
}