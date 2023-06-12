/*
 * Cube.js
 *
 * Cube.js Swagger Schema
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CubeJS.Gateway.Client.Client.OpenAPIDateConverter;

namespace CubeJS.Gateway.Client.Model
{
    /// <summary>
    /// V1LoadResultAnnotation
    /// </summary>
    [DataContract(Name = "V1LoadResultAnnotation")]
    public partial class V1LoadResultAnnotation : IEquatable<V1LoadResultAnnotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadResultAnnotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1LoadResultAnnotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadResultAnnotation" /> class.
        /// </summary>
        /// <param name="measures">measures (required).</param>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="segments">segments (required).</param>
        /// <param name="timeDimensions">timeDimensions (required).</param>
        public V1LoadResultAnnotation(Object measures = default(Object), Object dimensions = default(Object), Object segments = default(Object), Object timeDimensions = default(Object))
        {
            // to ensure "measures" is required (not null)
            if (measures == null)
            {
                throw new ArgumentNullException("measures is a required property for V1LoadResultAnnotation and cannot be null");
            }
            this.Measures = measures;
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new ArgumentNullException("dimensions is a required property for V1LoadResultAnnotation and cannot be null");
            }
            this.Dimensions = dimensions;
            // to ensure "segments" is required (not null)
            if (segments == null)
            {
                throw new ArgumentNullException("segments is a required property for V1LoadResultAnnotation and cannot be null");
            }
            this.Segments = segments;
            // to ensure "timeDimensions" is required (not null)
            if (timeDimensions == null)
            {
                throw new ArgumentNullException("timeDimensions is a required property for V1LoadResultAnnotation and cannot be null");
            }
            this.TimeDimensions = timeDimensions;
        }

        /// <summary>
        /// Gets or Sets Measures
        /// </summary>
        [DataMember(Name = "measures", IsRequired = true, EmitDefaultValue = true)]
        public Object Measures { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", IsRequired = true, EmitDefaultValue = true)]
        public Object Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name = "segments", IsRequired = true, EmitDefaultValue = true)]
        public Object Segments { get; set; }

        /// <summary>
        /// Gets or Sets TimeDimensions
        /// </summary>
        [DataMember(Name = "timeDimensions", IsRequired = true, EmitDefaultValue = true)]
        public Object TimeDimensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1LoadResultAnnotation {\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  TimeDimensions: ").Append(TimeDimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as V1LoadResultAnnotation);
        }

        /// <summary>
        /// Returns true if V1LoadResultAnnotation instances are equal
        /// </summary>
        /// <param name="input">Instance of V1LoadResultAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1LoadResultAnnotation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Measures == input.Measures ||
                    (this.Measures != null &&
                    this.Measures.Equals(input.Measures))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) && 
                (
                    this.Segments == input.Segments ||
                    (this.Segments != null &&
                    this.Segments.Equals(input.Segments))
                ) && 
                (
                    this.TimeDimensions == input.TimeDimensions ||
                    (this.TimeDimensions != null &&
                    this.TimeDimensions.Equals(input.TimeDimensions))
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
                if (this.Measures != null)
                {
                    hashCode = (hashCode * 59) + this.Measures.GetHashCode();
                }
                if (this.Dimensions != null)
                {
                    hashCode = (hashCode * 59) + this.Dimensions.GetHashCode();
                }
                if (this.Segments != null)
                {
                    hashCode = (hashCode * 59) + this.Segments.GetHashCode();
                }
                if (this.TimeDimensions != null)
                {
                    hashCode = (hashCode * 59) + this.TimeDimensions.GetHashCode();
                }
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
