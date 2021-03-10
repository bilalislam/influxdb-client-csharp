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
    /// The description of a particular axis for a visualization.
    /// </summary>
    [DataContract]
    public partial class Axis :  IEquatable<Axis>
    {
        /// <summary>
        /// Base represents the radix for formatting axis values.
        /// </summary>
        /// <value>Base represents the radix for formatting axis values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BaseEnum
        {
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 3

        }

        /// <summary>
        /// Base represents the radix for formatting axis values.
        /// </summary>
        /// <value>Base represents the radix for formatting axis values.</value>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public BaseEnum? Base { get; set; }
        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public AxisScale? Scale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Axis" /> class.
        /// </summary>
        /// <param name="bounds">The extents of an axis in the form [lower, upper]. Clients determine whether bounds are to be inclusive or exclusive of their limits.</param>
        /// <param name="label">Label is a description of this Axis.</param>
        /// <param name="prefix">Prefix represents a label prefix for formatting axis values..</param>
        /// <param name="suffix">Suffix represents a label suffix for formatting axis values..</param>
        /// <param name="_base">Base represents the radix for formatting axis values..</param>
        /// <param name="scale">scale.</param>
        public Axis(List<string> bounds = default(List<string>), string label = default(string), string prefix = default(string), string suffix = default(string), BaseEnum? _base = default(BaseEnum?), AxisScale? scale = default(AxisScale?))
        {
            this.Bounds = bounds;
            this.Label = label;
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.Base = _base;
            this.Scale = scale;
        }

        /// <summary>
        /// The extents of an axis in the form [lower, upper]. Clients determine whether bounds are to be inclusive or exclusive of their limits
        /// </summary>
        /// <value>The extents of an axis in the form [lower, upper]. Clients determine whether bounds are to be inclusive or exclusive of their limits</value>
        [DataMember(Name="bounds", EmitDefaultValue=false)]
        public List<string> Bounds { get; set; }

        /// <summary>
        /// Label is a description of this Axis
        /// </summary>
        /// <value>Label is a description of this Axis</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Prefix represents a label prefix for formatting axis values.
        /// </summary>
        /// <value>Prefix represents a label prefix for formatting axis values.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Suffix represents a label suffix for formatting axis values.
        /// </summary>
        /// <value>Suffix represents a label suffix for formatting axis values.</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Axis {\n");
            sb.Append("  Bounds: ").Append(Bounds).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
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
            return this.Equals(input as Axis);
        }

        /// <summary>
        /// Returns true if Axis instances are equal
        /// </summary>
        /// <param name="input">Instance of Axis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Axis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bounds == input.Bounds ||
                    this.Bounds != null &&
                    this.Bounds.SequenceEqual(input.Bounds)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.Scale == input.Scale ||
                    (this.Scale != null &&
                    this.Scale.Equals(input.Scale))
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
                if (this.Bounds != null)
                    hashCode = hashCode * 59 + this.Bounds.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Base != null)
                    hashCode = hashCode * 59 + this.Base.GetHashCode();
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                return hashCode;
            }
        }

    }

}