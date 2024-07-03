using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakIsletmeleri.Lib
{
    public static class AppVariables
    {
        public static Workplace? currentUser;

        public static bool isLoggedIn = false;

        public static string[] cities = new string[]
        {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
            "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
            "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne",
            "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
            "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu",
            "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu",
            "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon",
            "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt",
            "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova",
            "Karabük", "Kilis", "Osmaniye", "Düzce"
        };

        public static string[] propertyType = new string[]
        {
            "Daire",
            "Müstakil Ev",
            "Villa",
            "Yazlık",
            "Ofis",
            "Dükkan",
            "Depo",
            "Arsa",
            "Tarla",
            "Çiftlik Evi",
            "İşyeri",
            "Fabrika",
            "Plaza Katı",
            "Rezidans",
            "Apartman",
            "Konut",
            "Ticari Alan",
            "Mağaza",
            "Avm",
            "Bağ Evi"
        };

        public static string[] HeatingTypes = new string[]
        {
            "Doğalgaz",
            "Kömür",
            "Elektrik",
            "Klima",
            "Güneş Enerjisi",
            "Diğer"
        };
    }
}
