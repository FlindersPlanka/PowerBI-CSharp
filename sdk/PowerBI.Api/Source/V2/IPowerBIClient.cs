// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IPowerBIClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IDatasets.
        /// </summary>
        IDatasets Datasets { get; }

        /// <summary>
        /// Gets the IGateways.
        /// </summary>
        IGateways Gateways { get; }

        /// <summary>
        /// Gets the IImports.
        /// </summary>
        IImports Imports { get; }

        /// <summary>
        /// Gets the IReports.
        /// </summary>
        IReports Reports { get; }

        /// <summary>
        /// Gets the IDashboards.
        /// </summary>
        IDashboards Dashboards { get; }

        /// <summary>
        /// Gets the ITiles.
        /// </summary>
        ITiles Tiles { get; }

        /// <summary>
        /// Gets the IGroups.
        /// </summary>
        IGroups Groups { get; }

    }
}
