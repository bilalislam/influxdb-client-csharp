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
    /// Field
    /// </summary>
    [DataContract]
    public partial class Field :  IEquatable<Field>
    {
        /// <summary>
        /// &#x60;type&#x60; describes the field type. &#x60;func&#x60; is a function. &#x60;field&#x60; is a field reference.
        /// </summary>
        /// <value>&#x60;type&#x60; describes the field type. &#x60;func&#x60; is a function. &#x60;field&#x60; is a field reference.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Func for value: func
            /// </summary>
            [EnumMember(Value = "func")]
            Func = 1,

            /// <summary>
            /// Enum Field for value: field
            /// </summary>
            [EnumMember(Value = "field")]
            Field = 2,

            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 3,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 4,

            /// <summary>
            /// Enum Regex for value: regex
            /// </summary>
            [EnumMember(Value = "regex")]
            Regex = 5,

            /// <summary>
            /// Enum Wildcard for value: wildcard
            /// </summary>
            [EnumMember(Value = "wildcard")]
            Wildcard = 6

        }

        /// <summary>
        /// &#x60;type&#x60; describes the field type. &#x60;func&#x60; is a function. &#x60;field&#x60; is a field reference.
        /// </summary>
        /// <value>&#x60;type&#x60; describes the field type. &#x60;func&#x60; is a function. &#x60;field&#x60; is a field reference.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="value">value is the value of the field.  Meaning of the value is implied by the &#x60;type&#x60; key.</param>
        /// <param name="type">&#x60;type&#x60; describes the field type. &#x60;func&#x60; is a function. &#x60;field&#x60; is a field reference..</param>
        /// <param name="alias">Alias overrides the field name in the returned response.  Applies only if type is &#x60;func&#x60;.</param>
        /// <param name="args">Args are the arguments to the function.</param>
        public Field(string value = default(string), TypeEnum? type = default(TypeEnum?), string alias = default(string), List<Field> args = default(List<Field>))
        {
            this.Value = value;
            this.Type = type;
            this.Alias = alias;
            this.Args = args;
        }

        /// <summary>
        /// value is the value of the field.  Meaning of the value is implied by the &#x60;type&#x60; key
        /// </summary>
        /// <value>value is the value of the field.  Meaning of the value is implied by the &#x60;type&#x60; key</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Alias overrides the field name in the returned response.  Applies only if type is &#x60;func&#x60;
        /// </summary>
        /// <value>Alias overrides the field name in the returned response.  Applies only if type is &#x60;func&#x60;</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Args are the arguments to the function
        /// </summary>
        /// <value>Args are the arguments to the function</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<Field> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Field {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="input">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                return hashCode;
            }
        }

    }

}