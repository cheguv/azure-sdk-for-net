// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The arp table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitArpTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitArpTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitArpTable() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitArpTable
        /// class.
        /// </summary>
        /// <param name="age">Age.</param>
        /// <param name="interfaceProperty">Interface.</param>
        /// <param name="ipAddress">Gets ipAddress.</param>
        /// <param name="macAddress">Gets macAddress.</param>
        public ExpressRouteCircuitArpTable(int? age = default(int?), string interfaceProperty = default(string), string ipAddress = default(string), string macAddress = default(string))
        {
            Age = age;
            InterfaceProperty = interfaceProperty;
            IpAddress = ipAddress;
            MacAddress = macAddress;
        }

        /// <summary>
        /// Gets or sets age.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

        /// <summary>
        /// Gets or sets interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "interface")]
        public string InterfaceProperty { get; set; }

        /// <summary>
        /// Gets ipAddress.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets macAddress.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }

    }
}