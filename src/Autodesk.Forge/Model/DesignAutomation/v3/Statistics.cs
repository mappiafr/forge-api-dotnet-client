/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model.DesignAutomation.v3
{
    /// <summary>
    /// Statistics
    /// </summary>
    [DataContract]
    [Obsolete("Please use NuGet package Autodesk.Forge.DesignAutomation instead")]
    public partial class Statistics :  IEquatable<Statistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics" /> class.
        /// </summary>
        /// <param name="TimeQueued">TimeQueued.</param>
        /// <param name="TimeDownloadStarted">TimeDownloadStarted.</param>
        /// <param name="TimeInstructionsStarted">TimeInstructionsStarted.</param>
        /// <param name="TimeInstructionsEnded">TimeInstructionsEnded.</param>
        /// <param name="TimeUploadEnded">TimeUploadEnded.</param>
        public Statistics(DateTime? TimeQueued = null, DateTime? TimeDownloadStarted = null, DateTime? TimeInstructionsStarted = null, DateTime? TimeInstructionsEnded = null, DateTime? TimeUploadEnded = null)
        {
            this.TimeQueued = TimeQueued;
            this.TimeDownloadStarted = TimeDownloadStarted;
            this.TimeInstructionsStarted = TimeInstructionsStarted;
            this.TimeInstructionsEnded = TimeInstructionsEnded;
            this.TimeUploadEnded = TimeUploadEnded;
        }
        
        /// <summary>
        /// Gets or Sets TimeQueued
        /// </summary>
        [DataMember(Name="timeQueued", EmitDefaultValue=false)]
        public DateTime? TimeQueued { get; set; }
        /// <summary>
        /// Gets or Sets TimeDownloadStarted
        /// </summary>
        [DataMember(Name="timeDownloadStarted", EmitDefaultValue=false)]
        public DateTime? TimeDownloadStarted { get; set; }
        /// <summary>
        /// Gets or Sets TimeInstructionsStarted
        /// </summary>
        [DataMember(Name="timeInstructionsStarted", EmitDefaultValue=false)]
        public DateTime? TimeInstructionsStarted { get; set; }
        /// <summary>
        /// Gets or Sets TimeInstructionsEnded
        /// </summary>
        [DataMember(Name="timeInstructionsEnded", EmitDefaultValue=false)]
        public DateTime? TimeInstructionsEnded { get; set; }
        /// <summary>
        /// Gets or Sets TimeUploadEnded
        /// </summary>
        [DataMember(Name="timeUploadEnded", EmitDefaultValue=false)]
        public DateTime? TimeUploadEnded { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistics {\n");
            sb.Append("  TimeQueued: ").Append(TimeQueued).Append("\n");
            sb.Append("  TimeDownloadStarted: ").Append(TimeDownloadStarted).Append("\n");
            sb.Append("  TimeInstructionsStarted: ").Append(TimeInstructionsStarted).Append("\n");
            sb.Append("  TimeInstructionsEnded: ").Append(TimeInstructionsEnded).Append("\n");
            sb.Append("  TimeUploadEnded: ").Append(TimeUploadEnded).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Statistics);
        }

        /// <summary>
        /// Returns true if Statistics instances are equal
        /// </summary>
        /// <param name="other">Instance of Statistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TimeQueued == other.TimeQueued ||
                    this.TimeQueued != null &&
                    this.TimeQueued.Equals(other.TimeQueued)
                ) && 
                (
                    this.TimeDownloadStarted == other.TimeDownloadStarted ||
                    this.TimeDownloadStarted != null &&
                    this.TimeDownloadStarted.Equals(other.TimeDownloadStarted)
                ) && 
                (
                    this.TimeInstructionsStarted == other.TimeInstructionsStarted ||
                    this.TimeInstructionsStarted != null &&
                    this.TimeInstructionsStarted.Equals(other.TimeInstructionsStarted)
                ) && 
                (
                    this.TimeInstructionsEnded == other.TimeInstructionsEnded ||
                    this.TimeInstructionsEnded != null &&
                    this.TimeInstructionsEnded.Equals(other.TimeInstructionsEnded)
                ) && 
                (
                    this.TimeUploadEnded == other.TimeUploadEnded ||
                    this.TimeUploadEnded != null &&
                    this.TimeUploadEnded.Equals(other.TimeUploadEnded)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TimeQueued != null)
                    hash = hash * 59 + this.TimeQueued.GetHashCode();
                if (this.TimeDownloadStarted != null)
                    hash = hash * 59 + this.TimeDownloadStarted.GetHashCode();
                if (this.TimeInstructionsStarted != null)
                    hash = hash * 59 + this.TimeInstructionsStarted.GetHashCode();
                if (this.TimeInstructionsEnded != null)
                    hash = hash * 59 + this.TimeInstructionsEnded.GetHashCode();
                if (this.TimeUploadEnded != null)
                    hash = hash * 59 + this.TimeUploadEnded.GetHashCode();
                return hash;
            }
        }
    }

}

