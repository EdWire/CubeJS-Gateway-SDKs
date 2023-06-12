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
using System.Reflection;

namespace CubeJS.Gateway.Client.Model
{
    /// <summary>
    /// V1LoadRequestQueryFilterItem
    /// </summary>
    [JsonConverter(typeof(V1LoadRequestQueryFilterItemJsonConverter))]
    [DataContract(Name = "V1LoadRequestQueryFilterItem")]
    public partial class V1LoadRequestQueryFilterItem : AbstractOpenAPISchema, IEquatable<V1LoadRequestQueryFilterItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadRequestQueryFilterItem" /> class
        /// with the <see cref="V1LoadRequestQueryFilterBase" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of V1LoadRequestQueryFilterBase.</param>
        public V1LoadRequestQueryFilterItem(V1LoadRequestQueryFilterBase actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadRequestQueryFilterItem" /> class
        /// with the <see cref="V1LoadRequestQueryFilterLogicalOr" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of V1LoadRequestQueryFilterLogicalOr.</param>
        public V1LoadRequestQueryFilterItem(V1LoadRequestQueryFilterLogicalOr actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadRequestQueryFilterItem" /> class
        /// with the <see cref="V1LoadRequestQueryFilterLogicalAnd" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of V1LoadRequestQueryFilterLogicalAnd.</param>
        public V1LoadRequestQueryFilterItem(V1LoadRequestQueryFilterLogicalAnd actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(V1LoadRequestQueryFilterBase))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(V1LoadRequestQueryFilterLogicalAnd))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(V1LoadRequestQueryFilterLogicalOr))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: V1LoadRequestQueryFilterBase, V1LoadRequestQueryFilterLogicalAnd, V1LoadRequestQueryFilterLogicalOr");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `V1LoadRequestQueryFilterBase`. If the actual instance is not `V1LoadRequestQueryFilterBase`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of V1LoadRequestQueryFilterBase</returns>
        public V1LoadRequestQueryFilterBase GetV1LoadRequestQueryFilterBase()
        {
            return (V1LoadRequestQueryFilterBase)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `V1LoadRequestQueryFilterLogicalOr`. If the actual instance is not `V1LoadRequestQueryFilterLogicalOr`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of V1LoadRequestQueryFilterLogicalOr</returns>
        public V1LoadRequestQueryFilterLogicalOr GetV1LoadRequestQueryFilterLogicalOr()
        {
            return (V1LoadRequestQueryFilterLogicalOr)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `V1LoadRequestQueryFilterLogicalAnd`. If the actual instance is not `V1LoadRequestQueryFilterLogicalAnd`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of V1LoadRequestQueryFilterLogicalAnd</returns>
        public V1LoadRequestQueryFilterLogicalAnd GetV1LoadRequestQueryFilterLogicalAnd()
        {
            return (V1LoadRequestQueryFilterLogicalAnd)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1LoadRequestQueryFilterItem {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, V1LoadRequestQueryFilterItem.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of V1LoadRequestQueryFilterItem
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of V1LoadRequestQueryFilterItem</returns>
        public static V1LoadRequestQueryFilterItem FromJson(string jsonString)
        {
            V1LoadRequestQueryFilterItem newV1LoadRequestQueryFilterItem = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newV1LoadRequestQueryFilterItem;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(V1LoadRequestQueryFilterBase).GetProperty("AdditionalProperties") == null)
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterBase>(jsonString, V1LoadRequestQueryFilterItem.SerializerSettings));
                }
                else
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterBase>(jsonString, V1LoadRequestQueryFilterItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("V1LoadRequestQueryFilterBase");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into V1LoadRequestQueryFilterBase: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(V1LoadRequestQueryFilterLogicalAnd).GetProperty("AdditionalProperties") == null)
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterLogicalAnd>(jsonString, V1LoadRequestQueryFilterItem.SerializerSettings));
                }
                else
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterLogicalAnd>(jsonString, V1LoadRequestQueryFilterItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("V1LoadRequestQueryFilterLogicalAnd");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into V1LoadRequestQueryFilterLogicalAnd: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(V1LoadRequestQueryFilterLogicalOr).GetProperty("AdditionalProperties") == null)
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterLogicalOr>(jsonString, V1LoadRequestQueryFilterItem.SerializerSettings));
                }
                else
                {
                    newV1LoadRequestQueryFilterItem = new V1LoadRequestQueryFilterItem(JsonConvert.DeserializeObject<V1LoadRequestQueryFilterLogicalOr>(jsonString, V1LoadRequestQueryFilterItem.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("V1LoadRequestQueryFilterLogicalOr");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into V1LoadRequestQueryFilterLogicalOr: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newV1LoadRequestQueryFilterItem;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as V1LoadRequestQueryFilterItem);
        }

        /// <summary>
        /// Returns true if V1LoadRequestQueryFilterItem instances are equal
        /// </summary>
        /// <param name="input">Instance of V1LoadRequestQueryFilterItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1LoadRequestQueryFilterItem input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for V1LoadRequestQueryFilterItem
    /// </summary>
    public class V1LoadRequestQueryFilterItemJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(V1LoadRequestQueryFilterItem).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return V1LoadRequestQueryFilterItem.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
