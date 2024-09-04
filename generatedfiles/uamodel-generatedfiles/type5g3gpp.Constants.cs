/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using types3gpp;

namespace type5g3gpp
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the CommmodeltypeType DataType.
        /// </summary>
        public const uint CommmodeltypeType = 15001;

        /// <summary>
        /// The identifier for the Energysavingloadthresholdt DataType.
        /// </summary>
        public const uint Energysavingloadthresholdt = 15003;

        /// <summary>
        /// The identifier for the Energysavingtimedurationt DataType.
        /// </summary>
        public const uint Energysavingtimedurationt = 15004;

        /// <summary>
        /// The identifier for the Physcellid DataType.
        /// </summary>
        public const uint Physcellid = 15005;

        /// <summary>
        /// The identifier for the Utc24timeofdayt DataType.
        /// </summary>
        public const uint Utc24timeofdayt = 15006;

        /// <summary>
        /// The identifier for the DayofweektType DataType.
        /// </summary>
        public const uint DayofweektType = 15007;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SnssaiType ObjectType.
        /// </summary>
        public const uint SnssaiType = 15020;

        /// <summary>
        /// The identifier for the SupportedfuncType ObjectType.
        /// </summary>
        public const uint SupportedfuncType = 15017;

        /// <summary>
        /// The identifier for the CommmodelType ObjectType.
        /// </summary>
        public const uint CommmodelType = 15023;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the SnssaiType_Sd Variable.
        /// </summary>
        public const uint SnssaiType_Sd = 15021;

        /// <summary>
        /// The identifier for the SnssaiType_Sst Variable.
        /// </summary>
        public const uint SnssaiType_Sst = 15022;

        /// <summary>
        /// The identifier for the CommmodeltypeType_EnumStrings Variable.
        /// </summary>
        public const uint CommmodeltypeType_EnumStrings = 15002;

        /// <summary>
        /// The identifier for the SupportedfuncType_Function Variable.
        /// </summary>
        public const uint SupportedfuncType_Function = 15018;

        /// <summary>
        /// The identifier for the SupportedfuncType_Policy Variable.
        /// </summary>
        public const uint SupportedfuncType_Policy = 15019;

        /// <summary>
        /// The identifier for the CommmodelType_Groupid Variable.
        /// </summary>
        public const uint CommmodelType_Groupid = 15024;

        /// <summary>
        /// The identifier for the CommmodelType_Commmodeltype Variable.
        /// </summary>
        public const uint CommmodelType_Commmodeltype = 15025;

        /// <summary>
        /// The identifier for the CommmodelType_Targetnfservicelist Variable.
        /// </summary>
        public const uint CommmodelType_Targetnfservicelist = 15026;

        /// <summary>
        /// The identifier for the CommmodelType_Commmodelconfiguration Variable.
        /// </summary>
        public const uint CommmodelType_Commmodelconfiguration = 15027;

        /// <summary>
        /// The identifier for the DayofweektType_EnumValues Variable.
        /// </summary>
        public const uint DayofweektType_EnumValues = 15008;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_BinarySchema = 15009;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_BinarySchema_NamespaceUri = 15011;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_BinarySchema_Deprecated = 15012;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_XmlSchema = 15013;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_XmlSchema_NamespaceUri = 15015;

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint _3gpp-5g-common-yang-types_XmlSchema_Deprecated = 15016;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the CommmodeltypeType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CommmodeltypeType = new ExpandedNodeId(type5g3gpp.DataTypes.CommmodeltypeType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the Energysavingloadthresholdt DataType.
        /// </summary>
        public static readonly ExpandedNodeId Energysavingloadthresholdt = new ExpandedNodeId(type5g3gpp.DataTypes.Energysavingloadthresholdt, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the Energysavingtimedurationt DataType.
        /// </summary>
        public static readonly ExpandedNodeId Energysavingtimedurationt = new ExpandedNodeId(type5g3gpp.DataTypes.Energysavingtimedurationt, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the Physcellid DataType.
        /// </summary>
        public static readonly ExpandedNodeId Physcellid = new ExpandedNodeId(type5g3gpp.DataTypes.Physcellid, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the Utc24timeofdayt DataType.
        /// </summary>
        public static readonly ExpandedNodeId Utc24timeofdayt = new ExpandedNodeId(type5g3gpp.DataTypes.Utc24timeofdayt, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the DayofweektType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DayofweektType = new ExpandedNodeId(type5g3gpp.DataTypes.DayofweektType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the SnssaiType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SnssaiType = new ExpandedNodeId(type5g3gpp.ObjectTypes.SnssaiType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the SupportedfuncType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SupportedfuncType = new ExpandedNodeId(type5g3gpp.ObjectTypes.SupportedfuncType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodelType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CommmodelType = new ExpandedNodeId(type5g3gpp.ObjectTypes.CommmodelType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the SnssaiType_Sd Variable.
        /// </summary>
        public static readonly ExpandedNodeId SnssaiType_Sd = new ExpandedNodeId(type5g3gpp.Variables.SnssaiType_Sd, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the SnssaiType_Sst Variable.
        /// </summary>
        public static readonly ExpandedNodeId SnssaiType_Sst = new ExpandedNodeId(type5g3gpp.Variables.SnssaiType_Sst, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodeltypeType_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommmodeltypeType_EnumStrings = new ExpandedNodeId(type5g3gpp.Variables.CommmodeltypeType_EnumStrings, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the SupportedfuncType_Function Variable.
        /// </summary>
        public static readonly ExpandedNodeId SupportedfuncType_Function = new ExpandedNodeId(type5g3gpp.Variables.SupportedfuncType_Function, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the SupportedfuncType_Policy Variable.
        /// </summary>
        public static readonly ExpandedNodeId SupportedfuncType_Policy = new ExpandedNodeId(type5g3gpp.Variables.SupportedfuncType_Policy, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodelType_Groupid Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommmodelType_Groupid = new ExpandedNodeId(type5g3gpp.Variables.CommmodelType_Groupid, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodelType_Commmodeltype Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommmodelType_Commmodeltype = new ExpandedNodeId(type5g3gpp.Variables.CommmodelType_Commmodeltype, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodelType_Targetnfservicelist Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommmodelType_Targetnfservicelist = new ExpandedNodeId(type5g3gpp.Variables.CommmodelType_Targetnfservicelist, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the CommmodelType_Commmodelconfiguration Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommmodelType_Commmodelconfiguration = new ExpandedNodeId(type5g3gpp.Variables.CommmodelType_Commmodelconfiguration, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the DayofweektType_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DayofweektType_EnumValues = new ExpandedNodeId(type5g3gpp.Variables.DayofweektType_EnumValues, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_BinarySchema = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_BinarySchema, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_BinarySchema_NamespaceUri = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_BinarySchema_NamespaceUri, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_BinarySchema_Deprecated = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_BinarySchema_Deprecated, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_XmlSchema = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_XmlSchema, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_XmlSchema_NamespaceUri = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_XmlSchema_NamespaceUri, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);

        /// <summary>
        /// The identifier for the _3gpp-5g-common-yang-types_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId _3gpp-5g-common-yang-types_XmlSchema_Deprecated = new ExpandedNodeId(type5g3gpp.Variables._3gpp-5g-common-yang-types_XmlSchema_Deprecated, type5g3gpp.Namespaces._3gpp-5g-common-yang-types);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the _3gpp-5g-common-yang-types_BinarySchema component.
        /// </summary>
        public const string _3gpp-5g-common-yang-types_BinarySchema = "type5g3gpp";

        /// <summary>
        /// The BrowseName for the _3gpp-5g-common-yang-types_XmlSchema component.
        /// </summary>
        public const string _3gpp-5g-common-yang-types_XmlSchema = "type5g3gpp";

        /// <summary>
        /// The BrowseName for the Commmodelconfiguration component.
        /// </summary>
        public const string Commmodelconfiguration = "Commmodelconfiguration";

        /// <summary>
        /// The BrowseName for the Commmodeltype component.
        /// </summary>
        public const string Commmodeltype = "Commmodeltype";

        /// <summary>
        /// The BrowseName for the CommmodelType component.
        /// </summary>
        public const string CommmodelType = "CommmodelType";

        /// <summary>
        /// The BrowseName for the CommmodeltypeType component.
        /// </summary>
        public const string CommmodeltypeType = "CommmodeltypeType";

        /// <summary>
        /// The BrowseName for the DayofweektType component.
        /// </summary>
        public const string DayofweektType = "DayofweektType";

        /// <summary>
        /// The BrowseName for the Energysavingloadthresholdt component.
        /// </summary>
        public const string Energysavingloadthresholdt = "Energysavingloadthresholdt";

        /// <summary>
        /// The BrowseName for the Energysavingtimedurationt component.
        /// </summary>
        public const string Energysavingtimedurationt = "Energysavingtimedurationt";

        /// <summary>
        /// The BrowseName for the Function component.
        /// </summary>
        public const string Function = "Function";

        /// <summary>
        /// The BrowseName for the Groupid component.
        /// </summary>
        public const string Groupid = "Groupid";

        /// <summary>
        /// The BrowseName for the Physcellid component.
        /// </summary>
        public const string Physcellid = "Physcellid";

        /// <summary>
        /// The BrowseName for the Policy component.
        /// </summary>
        public const string Policy = "Policy";

        /// <summary>
        /// The BrowseName for the Sd component.
        /// </summary>
        public const string Sd = "Sd";

        /// <summary>
        /// The BrowseName for the SnssaiType component.
        /// </summary>
        public const string SnssaiType = "SnssaiType";

        /// <summary>
        /// The BrowseName for the Sst component.
        /// </summary>
        public const string Sst = "Sst";

        /// <summary>
        /// The BrowseName for the SupportedfuncType component.
        /// </summary>
        public const string SupportedfuncType = "SupportedfuncType";

        /// <summary>
        /// The BrowseName for the Targetnfservicelist component.
        /// </summary>
        public const string Targetnfservicelist = "Targetnfservicelist";

        /// <summary>
        /// The BrowseName for the Utc24timeofdayt component.
        /// </summary>
        public const string Utc24timeofdayt = "Utc24timeofdayt";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the _3gpp-5g-common-yang-types namespace (.NET code namespace is 'type5g3gpp').
        /// </summary>
        public const string _3gpp-5g-common-yang-types = "urn:3gpp:sa5:_3gpp-5g-common-yang-types";

        /// <summary>
        /// The URI for the _3gpp-common-yang-types namespace (.NET code namespace is 'types3gpp').
        /// </summary>
        public const string _3gpp-common-yang-types = "http://opcfoundation.org/UA/default/";
    }
    #endregion
}