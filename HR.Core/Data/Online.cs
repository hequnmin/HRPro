using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PetaPoco;

namespace HR.Core.Data
{
    /// <summary>
    /// 在线登记信息
    /// </summary>
    [TableName("online")]
    [PrimaryKey("onlineid", AutoIncrement = true)]
    public class Online
    {
        [Column(Name = "onlineid")]
        public int OnlineID { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonIgnore]
        [Column(Name = "machineno")]
        public string MachineNO { get; set; }

        /// <summary>
        /// 物理地址
        /// </summary>
        [JsonIgnore]
        [Column(Name = "macaddress")]
        public string MacAddress { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonIgnore]
        [Column(Name = "applicationname")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [JsonIgnore]
        [Column(Name = "applicationversion")]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// 登录用户名
        /// </summary>
        [JsonIgnore]
        [Column(Name = "userno")]
        public string UserNO { get; set; }

        [JsonIgnore]
        [ResultColumn(Name = "username")]
        public string UserName { get; set; }

        /// <summary>
        /// 正在运行程序名
        /// </summary>
        [JsonIgnore]
        [Column(Name = "programno")]
        public string ProgramNO { get; set; }

        /// <summary>
        /// 正在运行程序版本
        /// </summary>
        [JsonIgnore]
        [Column(Name = "programversion")]
        public string ProgramVersion { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [JsonIgnore]
        [Column(Name = "lastlogin")]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        [ResultColumn(Name = "certified")]
        public DateTime? Certified { get; set; }

        [ResultColumn(Name = "allowupload")]
        public bool AllowUpload { get; set; }

        [Column(Name = "machinetypeid")]
        public int? MachineTypeID { get; set; }

        [ResultColumn(Name = "machinetypeno")]
        public string MachineTypeNO { get; set; }

        [ResultColumn(Name = "allowmonitor")]
        public bool AllowMonitor { get; set; }

    }
}
