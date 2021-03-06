﻿using System;
using System.Collections.Generic;

namespace XCLCMS.Data.BLL
{
    /// <summary>
    /// 系统日志记录
    /// </summary>
    public partial class SysLog
    {
        private readonly XCLCMS.Data.DAL.SysLog dal = new XCLCMS.Data.DAL.SysLog();

        public SysLog()
        { }

        #region BasicMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.SysLog> GetModelList(string strWhere)
        {
            return dal.GetModelList(strWhere);
        }

        #endregion BasicMethod

        #region ExtensionMethod

        /// <summary>
        /// 分页数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.SysLog> GetPageList(XCLNetTools.Entity.PagerInfo pageInfo, string strWhere, string fieldName, string fieldKey, string fieldOrder)
        {
            return dal.GetPageList(pageInfo, strWhere, fieldName, fieldKey, fieldOrder);
        }

        /// <summary>
        /// 删除指定时间范围内的记录
        /// </summary>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="merchantID">商户号</param>
        public bool ClearListByDateTime(DateTime? startTime, DateTime? endTime, long merchantID)
        {
            return dal.ClearListByDateTime(startTime, endTime,merchantID);
        }

        #endregion ExtensionMethod
    }
}