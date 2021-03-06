// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1beta1DaemonSetUpdateStrategy
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetUpdateStrategy
        /// class.
        /// </summary>
        public V1beta1DaemonSetUpdateStrategy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetUpdateStrategy
        /// class.
        /// </summary>
        /// <param name="rollingUpdate">Rolling update config params. Present
        /// only if type = "RollingUpdate".</param>
        /// <param name="type">Type of daemon set update. Can be
        /// "RollingUpdate" or "OnDelete". Default is OnDelete.</param>
        public V1beta1DaemonSetUpdateStrategy(V1beta1RollingUpdateDaemonSet rollingUpdate = default(V1beta1RollingUpdateDaemonSet), string type = default(string))
        {
            RollingUpdate = rollingUpdate;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rolling update config params. Present only if type =
        /// "RollingUpdate".
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public V1beta1RollingUpdateDaemonSet RollingUpdate { get; set; }

        /// <summary>
        /// Gets or sets type of daemon set update. Can be "RollingUpdate" or
        /// "OnDelete". Default is OnDelete.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
