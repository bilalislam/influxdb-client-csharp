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
    /// Flux query to be analyzed.
    /// </summary>
    [DataContract]
    public partial class LanguageRequest :  IEquatable<LanguageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LanguageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageRequest" /> class.
        /// </summary>
        /// <param name="query">Flux query script to be analyzed (required).</param>
        public LanguageRequest(string query = default(string))
        {
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for LanguageRequest and cannot be null");
            }
            else
            {
                this.Query = query;
            }
        }

        /// <summary>
        /// Flux query script to be analyzed
        /// </summary>
        /// <value>Flux query script to be analyzed</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as LanguageRequest);
        }

        /// <summary>
        /// Returns true if LanguageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
        }

    }

}