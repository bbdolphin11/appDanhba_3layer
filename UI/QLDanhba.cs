
using AppDanhBa.BLL;
using AppDanhBa.Models;

class Program
{
    static void Main()
    {
        ContactBLL bll = new ContactBLL();
        List<Contact> contacts = bll.GetContacts();

        foreach (var c in contacts)
        {
            Console.WriteLine($"{c.Id} - {c.Name} - {c.Phone} - {c.Email}");
        }
    }
}
