namespace StudentService
{
    public class Student
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }


        public string getData()
        {
            return $"{id} - {age} - {name} - {email} - {phone}";
        }
    }
}
