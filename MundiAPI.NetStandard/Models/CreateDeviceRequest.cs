/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.NetStandard;
using MundiAPI.NetStandard.Utilities;


namespace MundiAPI.NetStandard.Models
{
    public class CreateDeviceRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string platform;

        /// <summary>
        /// Device's platform
        /// </summary>
        [JsonProperty("platform")]
        public string Platform 
        { 
            get 
            {
                return this.platform; 
            } 
            set 
            {
                this.platform = value;
                onPropertyChanged("Platform");
            }
        }
    }
} 