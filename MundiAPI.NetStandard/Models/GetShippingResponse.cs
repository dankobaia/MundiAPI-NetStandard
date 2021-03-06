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
    public class GetShippingResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private string description;
        private string recipientName;
        private string recipientPhone;
        private Models.GetAddressResponse address;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName 
        { 
            get 
            {
                return this.recipientName; 
            } 
            set 
            {
                this.recipientName = value;
                onPropertyChanged("RecipientName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("recipient_phone")]
        public string RecipientPhone 
        { 
            get 
            {
                return this.recipientPhone; 
            } 
            set 
            {
                this.recipientPhone = value;
                onPropertyChanged("RecipientPhone");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("address")]
        public Models.GetAddressResponse Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }
    }
} 