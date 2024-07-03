using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakIsletmeleri.Lib
{
    public static class Lib
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Telefon numarasının sadece rakamlardan oluşup oluşmadığı
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            // 10 haneli olup olmadığı
            return phoneNumber.Length == 10;
        }

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // İsmin sadece harflerden oluşup oluşmadığını
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                    return false;
            }

            // 10 haneli olup olmadığını
            return name.Length >= 2;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static void TextBox_KeyPressNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void TextBox_KeyPressCharOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
