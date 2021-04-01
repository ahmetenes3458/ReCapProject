using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";
        internal static string CarListed = "Araçlar Listelendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string BrandNameInvalid = "Marka İsmi Geçersiz";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColordAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string BrandListed = "Markalar Listelendi";
        internal static string ColorListed = "Renkler Listelendi";
        internal static string CustomerListed = "Müşteriler Listelendi";
        internal static string UserListed= "Kullanıcılar Listelendi";
        internal static string RentalListed = "Kiralanan Araç Bilgisi Listelendi";
        internal static string CarImageLimitExceeded="Araç Resim Limitic doldu";
        public static string ImageAdded="Resim Eklendş";
        internal static string ImageDeleted="Resim Silindi";
        internal static string CarImagesListed="Resimler Listelendi";
        internal static string CarCheckImageLimited="";
        public static string AuthorizationDenied="Yetkiniz Yok";
    }
}
