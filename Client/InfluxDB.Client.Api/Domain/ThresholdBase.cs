/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// ThresholdBase
    /// </summary>
    [DataContract]
    public partial class ThresholdBase :  IEquatable<ThresholdBase>
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public CheckStatusLevel? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdBase" /> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="allValues">If true, only alert if all values meet threshold..</param>
        public ThresholdBase(CheckStatusLevel? level = default(CheckStatusLevel?), bool? allValues = default(bool?))
        {
            this.Level = level;
            this.AllValues = allValues;
        }


        /// <summary>
        /// If true, only alert if all values meet threshold.
        /// </summary>
        /// <value>If true, only alert if all values meet threshold.</value>
        [DataMember(Name="allValues", EmitDefaultValue=false)]
        public bool? AllValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThresholdBase {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  AllValues: ").Append(AllValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ThresholdBase);
        }

        /// <summary>
        /// Returns true if ThresholdBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ThresholdBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThresholdBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.AllValues == input.AllValues ||
                    (this.AllValues != null &&
                    this.AllValues.Equals(input.AllValues))
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
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.AllValues != null)
                    hashCode = hashCode * 59 + this.AllValues.GetHashCode();
                return hashCode;
            }
        }

    }

}