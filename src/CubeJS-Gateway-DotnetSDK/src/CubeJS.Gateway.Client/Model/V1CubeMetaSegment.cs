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
    /// V1CubeMetaSegment
    /// </summary>
    [DataContract(Name = "V1CubeMetaSegment")]
    public partial class V1CubeMetaSegment : IEquatable<V1CubeMetaSegment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CubeMetaSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1CubeMetaSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CubeMetaSegment" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="shortTitle">shortTitle (required).</param>
        public V1CubeMetaSegment(string name = default(string), string title = default(string), string shortTitle = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for V1CubeMetaSegment and cannot be null");
            }
            this.Name = name;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for V1CubeMetaSegment and cannot be null");
            }
            this.Title = title;
            // to ensure "shortTitle" is required (not null)
            if (shortTitle == null)
            {
                throw new ArgumentNullException("shortTitle is a required property for V1CubeMetaSegment and cannot be null");
            }
            this.ShortTitle = shortTitle;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ShortTitle
        /// </summary>
        [DataMember(Name = "shortTitle", IsRequired = true, EmitDefaultValue = true)]
        public string ShortTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1CubeMetaSegment {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ShortTitle: ").Append(ShortTitle).Append("\n");
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
            return this.Equals(input as V1CubeMetaSegment);
        }

        /// <summary>
        /// Returns true if V1CubeMetaSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of V1CubeMetaSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1CubeMetaSegment input)
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
                    this.ShortTitle == input.ShortTitle ||
                    (this.ShortTitle != null &&
                    this.ShortTitle.Equals(input.ShortTitle))
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
                if (this.ShortTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ShortTitle.GetHashCode();
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