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
    public class CreateCaptureChargeRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string code;
        private int? amount;

        /// <summary>
        /// Code for the charge. Sending this field will update the code send on the charge and order creation.
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// The amount that will be captured
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }
    }
} 