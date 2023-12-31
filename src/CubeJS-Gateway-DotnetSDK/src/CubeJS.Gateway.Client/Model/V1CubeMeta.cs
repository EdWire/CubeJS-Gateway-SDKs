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
    /// V1CubeMeta
    /// </summary>
    [DataContract(Name = "V1CubeMeta")]
    public partial class V1CubeMeta : IEquatable<V1CubeMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CubeMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1CubeMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CubeMeta" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="title">title.</param>
        /// <param name="measures">measures (required).</param>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="segments">segments (required).</param>
        /// <param name="joins">joins.</param>
        public V1CubeMeta(string name = default(string), string title = default(string), List<V1CubeMetaMeasure> measures = default(List<V1CubeMetaMeasure>), List<V1CubeMetaDimension> dimensions = default(List<V1CubeMetaDimension>), List<V1CubeMetaSegment> segments = default(List<V1CubeMetaSegment>), List<V1CubeMetaJoin> joins = default(List<V1CubeMetaJoin>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for V1CubeMeta and cannot be null");
            }
            this.Name = name;
            // to ensure "measures" is required (not null)
            if (measures == null)
            {
                throw new ArgumentNullException("measures is a required property for V1CubeMeta and cannot be null");
            }
            this.Measures = measures;
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new ArgumentNullException("dimensions is a required property for V1CubeMeta and cannot be null");
            }
            this.Dimensions = dimensions;
            // to ensure "segments" is required (not null)
            if (segments == null)
            {
                throw new ArgumentNullException("segments is a required property for V1CubeMeta and cannot be null");
            }
            this.Segments = segments;
            this.Title = title;
            this.Joins = joins;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Measures
        /// </summary>
        [DataMember(Name = "measures", IsRequired = true, EmitDefaultValue = true)]
        public List<V1CubeMetaMeasure> Measures { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", IsRequired = true, EmitDefaultValue = true)]
        public List<V1CubeMetaDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name = "segments", IsRequired = true, EmitDefaultValue = true)]
        public List<V1CubeMetaSegment> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Joins
        /// </summary>
        [DataMember(Name = "joins", EmitDefaultValue = false)]
        public List<V1CubeMetaJoin> Joins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1CubeMeta {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Joins: ").Append(Joins).Append("\n");
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
            return this.Equals(input as V1CubeMeta);
        }

        /// <summary>
        /// Returns true if V1CubeMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of V1CubeMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1CubeMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Measures == input.Measures ||
                    this.Measures != null &&
                    input.Measures != null &&
                    this.Measures.SequenceEqual(input.Measures)
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && 
                (
                    this.Joins == input.Joins ||
                    this.Joins != null &&
                    input.Joins != null &&
                    this.Joins.SequenceEqual(input.Joins)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
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
                if (this.Joins != null)
                {
                    hashCode = (hashCode * 59) + this.Joins.GetHashCode();
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
