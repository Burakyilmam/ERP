using DevExpress.XtraTreeList.Nodes;
using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms
{
    public static class General
    {
        public static User activeUser;
        public static Session activeSession;
        public static int FailCount;
        public static IUserService _user;
        public static ISessionService _session;
        public static ITabService _tab;
        public static ICalenderService _calender;
        public static DataContext _context;
        public static string FindIP()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (var item in host.AddressList)
                {
                    if (item.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return item.ToString();
                    }
                }

                return "Ağ kartı bulunmamaktadır";
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }

      // public static List<string> GetGeoLocation()
      // {
      //     HttpClient client = new HttpClient();
      //     string url = $"https://ipinfo.io/{FindIP()}/json";
      //     try
      //     {
      //         string response =  client.GetStringAsync(url);
      //         dynamic json = JsonConvert.DeserializeObject(response);
      //
      //         string city = json.city ?? "Bilinmiyor";
      //         string region = json.region ?? "Bilinmiyor";
      //         string country = json.country ?? "Bilinmiyor";
      //
      //         return $"{city}, {region}, {country}";
      //     }
      //     catch (Exception ex)
      //     {
      //         return "Lokasyon bilgisi alınamadı";
      //     }
      // }

        public static void OpenMenuNode(TreeListNode i)
        {
            if (i == null) return;
            if (i.Tag == null) return;

            if (i.Tag == "User") { FormOpen(new UserForms.frmUsers()); }
            if (i.Tag == "Customer") { FormOpen(new UserForms.frmSessions()); }
        }

        public static Form FormOpen(Form i)
        {
            i.StartPosition = FormStartPosition.CenterScreen;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == i.GetType() && !openForm.IsDisposed)
                {
                    openForm.BringToFront();
                    return openForm;
                }
            }

            i.Show();
            return i;
        }

        public static int GetWeekOfYear(DateTime date)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return culture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}
