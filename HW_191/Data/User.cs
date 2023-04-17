namespace HW_191.Data
{
    public class User
    {
        public User(string _Id, string _Surname, string _FirstName, string _Patronymic, string _PhoneNumber, 
            string _Adress, string _Description)
        {
            Id = _Id;
            Surname = _Surname;
            FirstName = _FirstName;
            Patronymic = _Patronymic;
            PhoneNumber = _PhoneNumber;
            Adress = _Adress;
            Description = _Description;
        }
        public string Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {Surname} {FirstName} {Patronymic}";
        }
    }
}
