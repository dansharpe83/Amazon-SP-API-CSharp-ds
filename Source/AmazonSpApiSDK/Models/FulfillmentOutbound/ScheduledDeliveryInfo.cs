/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Delivery information for a Scheduled Delivery.
    /// </summary>
    [DataContract]
    public partial class ScheduledDeliveryInfo : IEquatable<ScheduledDeliveryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledDeliveryInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledDeliveryInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledDeliveryInfo" /> class.
        /// </summary>
        /// <param name="DeliveryTimeZone">The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo. (required).</param>
        /// <param name="DeliveryWindows">A list of time ranges that are available for Scheduled Delivery. (required).</param>
        public ScheduledDeliveryInfo(string DeliveryTimeZone = default(string), DeliveryWindowList DeliveryWindows = default(DeliveryWindowList))
        {
            // to ensure "DeliveryTimeZone" is required (not null)
            if (DeliveryTimeZone == null)
            {
                throw new InvalidDataException("DeliveryTimeZone is a required property for ScheduledDeliveryInfo and cannot be null");
            }
            else
            {
                this.DeliveryTimeZone = DeliveryTimeZone;
            }
            // to ensure "DeliveryWindows" is required (not null)
            if (DeliveryWindows == null)
            {
                throw new InvalidDataException("DeliveryWindows is a required property for ScheduledDeliveryInfo and cannot be null");
            }
            else
            {
                this.DeliveryWindows = DeliveryWindows;
            }
        }

        /// <summary>
        /// The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo.
        /// </summary>
        /// <value>The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo.</value>
        [DataMember(Name = "DeliveryTimeZone", EmitDefaultValue = false)]
        public string DeliveryTimeZone { get; set; }

        /// <summary>
        /// A list of time ranges that are available for Scheduled Delivery.
        /// </summary>
        /// <value>A list of time ranges that are available for Scheduled Delivery.</value>
        [DataMember(Name = "DeliveryWindows", EmitDefaultValue = false)]
        public DeliveryWindowList DeliveryWindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledDeliveryInfo {\n");
            sb.Append("  DeliveryTimeZone: ").Append(DeliveryTimeZone).Append("\n");
            sb.Append("  DeliveryWindows: ").Append(DeliveryWindows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledDeliveryInfo);
        }

        /// <summary>
        /// Returns true if ScheduledDeliveryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledDeliveryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledDeliveryInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeliveryTimeZone == input.DeliveryTimeZone ||
                    (this.DeliveryTimeZone != null &&
                    this.DeliveryTimeZone.Equals(input.DeliveryTimeZone))
                ) &&
                (
                    this.DeliveryWindows == input.DeliveryWindows ||
                    (this.DeliveryWindows != null &&
                    this.DeliveryWindows.Equals(input.DeliveryWindows))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeliveryTimeZone != null)
                    hashCode = hashCode * 59 + this.DeliveryTimeZone.GetHashCode();
                if (this.DeliveryWindows != null)
                    hashCode = hashCode * 59 + this.DeliveryWindows.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}