using AppDanhBa.DAL;
using AppDanhBa.Models;

namespace AppDanhBa.BLL
{
    public class ContactBLL
    {
        private ContactDAL dal = new ContactDAL();

        public List<Contact> GetContacts()
        {
            // Có thể thêm logic kiểm tra dữ liệu ở đây
            return dal.GetAllContacts();
        }
    }
}
