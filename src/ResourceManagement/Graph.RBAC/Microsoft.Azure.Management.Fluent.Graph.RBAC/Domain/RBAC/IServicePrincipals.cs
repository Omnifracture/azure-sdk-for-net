// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Fluent.Graph.RBAC
{

    using Microsoft.Azure.Management.Fluent.Resource.Core.CollectionActions;
    using Microsoft.Rest;
    using System.Threading;
    using Microsoft.Azure.Management.Fluent.Graph.RBAC.ServicePrincipal.Definition;
    using System.Threading.Tasks;
    /// <summary>
    /// Entry point to service principal management API.
    /// </summary>
    public interface IServicePrincipals  :
        ISupportsCreating<Microsoft.Azure.Management.Fluent.Graph.RBAC.ServicePrincipal.Definition.IBlank>,
        ISupportsListing<Microsoft.Azure.Management.Fluent.Graph.RBAC.IServicePrincipal>
    {
        /// <summary>
        /// Gets the information about a service principal.
        /// </summary>
        /// <param name="objectId">objectId the unique object id</param>
        /// <returns>an immutable representation of the resource</returns>
        Microsoft.Azure.Management.Fluent.Graph.RBAC.IServicePrincipal GetByObjectId(string objectId);

        /// <summary>
        /// Gets the information about a service principal.
        /// </summary>
        /// <param name="appId">appId the application id (or the client id)</param>
        /// <returns>an immutable representation of the resource</returns>
        Microsoft.Azure.Management.Fluent.Graph.RBAC.IServicePrincipal GetByAppId(string appId);

        /// <summary>
        /// Gets the information about a service principal.
        /// </summary>
        /// <param name="spn">spn the service principal name</param>
        /// <returns>an immutable representation of the resource</returns>
        Microsoft.Azure.Management.Fluent.Graph.RBAC.IServicePrincipal GetByServicePrincipalName(string spn);

        /// <summary>
        /// Gets the information about a service principal.
        /// </summary>
        /// <param name="spn">spn      the service principal name</param>
        /// <param name="cancellationToken">cancellationToken the cancellation token</param>
        /// <returns>the Observable to the request</returns>
        Task<Microsoft.Azure.Management.Fluent.Graph.RBAC.IServicePrincipal> GetByServicePrincipalNameAsync(string spn, CancellationToken cancellationToken = default(CancellationToken));

    }
}