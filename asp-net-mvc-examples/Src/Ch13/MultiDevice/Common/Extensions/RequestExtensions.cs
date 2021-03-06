using System;
using System.Web;
using WURFL;

namespace MultiView2.Common.Extensions
{
    public static class HttpRequestBaseExtensions
    {
        public static Boolean IsDesktop(this HttpRequestBase request)
        {
            return true;
        }
        public static Boolean IsLegacy(this HttpRequestBase request)
        {
            return IsLegacyInternal(request.UserAgent);
        }
        public static Boolean IsSmartphone(this HttpRequestBase request)
        {
            return IsSmartPhoneInternal(request.UserAgent);
        }
        public static Boolean IsTablet(this HttpRequestBase request)
        {
            return IsTabletInternal(request.UserAgent);
        }

        #region Internals
        private static Boolean IsSmartPhoneInternal(String userAgent)
        {
            var device = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            return device.IsWireless() && !device.IsTablet() &&
                    device.IsTouch() &&
                    device.Width() > 240 &&
                    (device.HasOs("android", new Version(2, 1)) ||
                    device.HasOs("iphone os", new Version(3, 2)) ||
                    device.HasOs("windows phone os", new Version(7, 1)) ||
                    device.HasOs("rim os", new Version(6, 0)));
        }
        private static Boolean IsTabletInternal(String userAgent)
        {
            var device = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            return device.IsTablet();
        }
        private static Boolean IsLegacyInternal(String userAgent)
        {
            var device = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            return device.IsWireless();
        }
        #endregion
    }
}