using System.Data.Common;

namespace ChangeTrackerTest;

public class Person
{
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Name { get; set; }
}

public static class Seeder
{
    public static List<Person> OldPersonList = new List<Person>()
    {
        new Person() {Email = "sandun@gmail.com", PhoneNumber = "0712222222222", Name = "Sandun"},
        new Person() {Email = "c", PhoneNumber = "0713333333", Name = "Kumara"},
        new Person() {Email = "Nimal@gmail.com", PhoneNumber = "0714444444", Name = "Nimal"},
        new Person() {Email = "Chathuranga@gmail.com", PhoneNumber = "44566768994", Name = "Chathuranga"},
        new Person() {Email = "Ann@gmail.com", PhoneNumber = "0717777777", Name = "Ann"},
        new Person() {Email = "David@gmail.com", PhoneNumber = "07199999", Name = "David"},
    };
    
    public static List<Person> NewPersonList = new List<Person>()
    {
        new Person() {Email = "sandun@gmail.com", PhoneNumber = "0712222222222", Name = "Sandun"},
        new Person() {Email = "Kumara@gmail.com", PhoneNumber = "0713333333", Name = "Kumara"},
        new Person() {Email = "Nimal@gmail.com", PhoneNumber = "0714444444", Name = "Nimal"},
        new Person() {Email = "Saman@gmail.com", PhoneNumber = "56677", Name = "Saman"},
    };
}