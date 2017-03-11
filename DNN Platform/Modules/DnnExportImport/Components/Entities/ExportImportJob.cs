﻿#region Copyright
//
// DotNetNuke® - http://www.dnnsoftware.com
// Copyright (c) 2002-2017
// by DotNetNuke Corporation
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Data;
using Dnn.ExportImport.Components.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Modules;

namespace Dnn.ExportImport.Components.Entities
{
    [Serializable]
    [TableName("ExportImportJobs")]
    [PrimaryKey("JobId")]
    public class ExportImportJob : IHydratable
    {
        public int JobId { get; set; }
        public int PortalId { get; set; }
        public JobType JobType { get; set; }
        public JobStatus JobStatus { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public DateTime? CompletedOnDate { get; set; }
        public string ExportFile { get; set; }
        public string JobObject { get; set; }

        public int KeyID
        {
            get { return JobId; }
            set { JobId = value; }
        }

        public void Fill(IDataReader dr)
        {
            JobId = Null.SetNullInteger(dr["JobId"]);
            PortalId = Null.SetNullInteger(dr["PortalId"]);
            JobType = (JobType)Null.SetNullInteger(dr["JobType"]);
            JobStatus = (JobStatus)Null.SetNullInteger(dr["JobStatus"]);
            CreatedByUserId = Null.SetNullInteger(dr["CreatedByUserID"]);
            CreatedOnDate = Null.SetNullDateTime(dr["CreatedOnDate"]);
            LastModifiedOnDate = Null.SetNullDateTime(dr["LastModifiedOnDate"]);
            CompletedOnDate = Null.SetNullDateTime(dr["CompletedOnDate"]);
            ExportFile = Null.SetNullString(dr["ExportFile"]);
            JobObject = Null.SetNullString(dr["JobObject"]);
        }
    }
}