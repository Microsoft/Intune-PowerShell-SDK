// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.searchResult&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.searchResult&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SearchResultObject", DefaultParameterSetName = @"microsoft.graph.searchResult")]
    [ODataType("microsoft.graph.searchResult")]
    public class New_SearchResultObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;onClickTelemetryUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.searchResult&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.searchResult", HelpMessage = @"The &quot;onClickTelemetryUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onClickTelemetryUrl { get; set; }
    }
}