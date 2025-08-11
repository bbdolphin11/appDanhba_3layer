
using AppDanhBa.Models;

namespace AppDanhBa.DAL
{
    public class ContactDAL
    {
        public List<Contact> GetAllContacts()
        {
            // Tạm thời giả lập dữ liệu, chưa kết nối SQL
            return new List<Contact>
            {
                new Contact { Id = 1, Name = "Nguyen Van A", Phone = "0123456789", Email = "a@email.com" },
                new Contact { Id = 2, Name = "Tran Thi B", Phone = "0987654321", Email = "b@email.com" }
            };
        }
    }
}
