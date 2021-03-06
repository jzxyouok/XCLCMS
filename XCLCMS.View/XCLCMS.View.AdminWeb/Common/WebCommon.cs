﻿using System.Web;

namespace XCLCMS.View.AdminWeb.Common
{
    /// <summary>
    /// 站点公共信息
    /// </summary>
    public class WebCommon
    {
        #region 路径相关

        /// <summary>
        /// 上一步的URL
        /// </summary>
        public static string RefferUrl
        {
            get
            {
                string url = null == HttpContext.Current.Request.UrlReferrer ? string.Empty : HttpContext.Current.Request.UrlReferrer.AbsoluteUri;
                if (string.IsNullOrEmpty(url))
                {
                    url = XCLNetTools.StringHander.Common.RootUri;
                }
                return url;
            }
        }

        #endregion 路径相关
    }
}