using System;
using System.Globalization;

namespace IZ_ORM.Utility
{
    public static class DateConverter
    {
        /// <summary>
        /// به فرمت 21:00
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToHourMinute(this DateTime time)
        {
            var pc = new PersianCalendar();

            var hour = pc.GetHour(time).ToString("00");
            var minute = pc.GetMinute(time).ToString("00");

            return $"{hour}:{minute}";
        }

        //---------------------------------------------------------------------------

        /// <summary>
        /// به فرمت 1397/02/02
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToShamsi(this DateTime value)
        {
            var pc = new PersianCalendar();

            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00");
        }

        //---------------------------------------------------------------------------

        /// <summary>
        /// به فرمت
        /// 22 اردیبهشت 1397
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetDateName(this DateTime dt)
        {
            var pc = new PersianCalendar();
            var year = pc.GetYear(dt).ToString();
            var month = pc.GetMonth(dt);
            var day = pc.GetDayOfMonth(dt).ToString();

            string[] monthName = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر",
                "آبان", "آذر", "دی", "بهمن", "اسفند" };

            return day + " " + monthName[month - 1] + " " + year;

        }

        //---------------------------------------------------------------------------

        /// <summary>
        /// برگرداندن تاریخ و ساعت فعلی به فرمت زیر
        /// 1397/01/01 11:00:00
        /// </summary>
        /// <returns></returns>
        public static string PersianDatewithTime()
        {
            var dateTime = DateTime.Now;
            var pc = new PersianCalendar();
            var y = pc.GetYear(dateTime).ToString();
            var m = pc.GetMonth(dateTime).ToString();
            var d = pc.GetDayOfMonth(dateTime).ToString();
            var hour = pc.GetHour(dateTime).ToString();
            var minute = pc.GetMinute(dateTime).ToString();
            var second = pc.GetSecond(dateTime).ToString();
            m = m.Length == 1 ? "0" + m : m;
            d = d.Length == 1 ? "0" + d : d;
            hour = hour.Length == 1 ? "0" + hour : hour;
            minute = minute.Length == 1 ? "0" + minute : minute;
            second = second.Length == 1 ? "0" + second : second;
            return $"{y}/{m}/{d}" + " " + $"{hour}:{minute}:{second}";
        }

        //---------------------------------------------------------------------------

        public static string PersianDatewithGivenTime(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            var y = pc.GetYear(dateTime).ToString();
            var m = pc.GetMonth(dateTime).ToString();
            var d = pc.GetDayOfMonth(dateTime).ToString();
            var hour = pc.GetHour(dateTime).ToString();
            var minute = pc.GetMinute(dateTime).ToString();
            //var second = pc.GetSecond(dateTime).ToString();
            m = m.Length == 1 ? "0" + m : m;
            d = d.Length == 1 ? "0" + d : d;
            hour = hour.Length == 1 ? "0" + hour : hour;
            minute = minute.Length == 1 ? "0" + minute : minute;
            //second = second.Length == 1 ? "0" + second : second;
            return $"{y}/{m}/{d}" + " " + $"{hour}:{minute}";
        }

        //--------------------------------------------------------------------------------------------

        public static string PersianDatewithGivenTimeExtension(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            var y = pc.GetYear(dateTime).ToString();
            var m = pc.GetMonth(dateTime).ToString();
            var d = pc.GetDayOfMonth(dateTime).ToString();
            var hour = pc.GetHour(dateTime).ToString();
            var minute = pc.GetMinute(dateTime).ToString();
            //var second = pc.GetSecond(dateTime).ToString();
            m = m.Length == 1 ? "0" + m : m;
            d = d.Length == 1 ? "0" + d : d;
            hour = hour.Length == 1 ? "0" + hour : hour;
            minute = minute.Length == 1 ? "0" + minute : minute;
            //second = second.Length == 1 ? "0" + second : second;
            return $"{hour}:{minute}" + " - " + $"{y}/{m}/{d}";
        }

        //--------------------------------------------------------------------------------------------

        public static string PersianDatewithGivenTimeExtensionNullable(this DateTime? dateTime)
        {
            var pc = new PersianCalendar();
            var y = pc.GetYear((DateTime)dateTime).ToString();
            var m = pc.GetMonth((DateTime)dateTime).ToString();
            var d = pc.GetDayOfMonth((DateTime)dateTime).ToString();
            var hour = pc.GetHour((DateTime)dateTime).ToString();
            var minute = pc.GetMinute((DateTime)dateTime).ToString();
            //var second = pc.GetSecond(dateTime).ToString();
            m = m.Length == 1 ? "0" + m : m;
            d = d.Length == 1 ? "0" + d : d;
            hour = hour.Length == 1 ? "0" + hour : hour;
            minute = minute.Length == 1 ? "0" + minute : minute;
            //second = second.Length == 1 ? "0" + second : second;
            return $"{hour}:{minute}" + " - " + $"{y}/{m}/{d}";
        }

        //--------------------------------------------------------------------------------------------

        public static string PersianDatewithGivenTime(DateTime? expireDate)
        {
            var pc = new PersianCalendar();
            var y = pc.GetYear((DateTime)expireDate).ToString();
            var m = pc.GetMonth((DateTime)expireDate).ToString();
            var d = pc.GetDayOfMonth((DateTime)expireDate).ToString();
            var hour = pc.GetHour((DateTime)expireDate).ToString();
            var minute = pc.GetMinute((DateTime)expireDate).ToString();
            //var second = pc.GetSecond(dateTime).ToString();
            m = m.Length == 1 ? "0" + m : m;
            d = d.Length == 1 ? "0" + d : d;
            hour = hour.Length == 1 ? "0" + hour : hour;
            minute = minute.Length == 1 ? "0" + minute : minute;
            //second = second.Length == 1 ? "0" + second : second;
            return $"{hour}:{minute}" + " " + $"{y}/{m}/{d}";
        }

        //--------------------------------------------------------------------------------------------

        public static DateTime ToMiladi(string persianDate)
        {
            var persianDateArray = persianDate.Split('/');

            int day = Convert.ToInt32(persianDateArray[2]);
            int month = Convert.ToInt32(persianDateArray[1]);
            int year = Convert.ToInt32(persianDateArray[0]);

            var pc = new PersianCalendar();
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        //--------------------------------------------------------------------------------------------

        public static object ShamsiToMiladi(string ShamsiDate, bool isTo, bool returnResultString = true)
        {
            DateTime dt;

            var persianDateArray = ShamsiDate.Split('/');

            int day = Convert.ToInt32(persianDateArray[2]);
            int month = Convert.ToInt32(persianDateArray[1]);
            int year = Convert.ToInt32(persianDateArray[0]);

            if (isTo == true)
            {
                var pc = new PersianCalendar();
                dt = pc.ToDateTime(year, month, day, 23, 59, 59, 0);

                if (returnResultString)
                {
                    return dt.ToString("MM/dd/yyyy HH:mm:ss tt");
                }

                return dt;
            }
            else
            {
                //1 / 30 / 2020 11:59:59 PM
                var pc = new PersianCalendar();
                dt = pc.ToDateTime(year, month, day, 0, 0, 0, 0);

                if (returnResultString)
                {
                    return dt.ToString("MM/dd/yyyy HH:mm:ss tt");
                }

                return dt;
            }
        }

    }
}