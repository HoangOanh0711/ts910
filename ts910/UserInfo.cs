using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ts910
{
    public class UserInfo
    {
        private string hoten,email,sdt,diachi,ava;

        public string Hoten { get { return hoten; } set {  hoten = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Sdt { get { return sdt; } set { email = value; } }
        public string DiaChi { get {  return diachi; } set {  diachi = value; } }
        public string Ava { get { return ava; } set { ava = value; } }

        public UserInfo(string hoten, string email, string sdt, string diachi, string ava) {
            this.hoten = hoten;
            this.email = email;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ava = ava;
        }
    }
}
