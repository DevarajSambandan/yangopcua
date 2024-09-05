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

namespace simex
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
        /// The identifier for the Ipv4Address DataType.
        /// </summary>
        public const uint Ipv4Address = 15014;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the UpdateSoftware Method.
        /// </summary>
        public const uint UpdateSoftware = 15016;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Bag Object.
        /// </summary>
        public const uint Bag = 15002;

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping Object.
        /// </summary>
        public const uint ExampleContainerType_MyGrouping = 15007;

        /// <summary>
        /// The identifier for the ExampleContainer Object.
        /// </summary>
        public const uint ExampleContainer = 15010;

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping Object.
        /// </summary>
        public const uint ExampleContainer_MyGrouping = 15011;
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
        /// The identifier for the BagType ObjectType.
        /// </summary>
        public const uint BagType = 15001;

        /// <summary>
        /// The identifier for the MyGroupingType ObjectType.
        /// </summary>
        public const uint MyGroupingType = 15003;

        /// <summary>
        /// The identifier for the ExampleContainerType ObjectType.
        /// </summary>
        public const uint ExampleContainerType = 15006;
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
        /// The identifier for the MyGroupingType_Name Variable.
        /// </summary>
        public const uint MyGroupingType_Name = 15004;

        /// <summary>
        /// The identifier for the MyGroupingType_Value Variable.
        /// </summary>
        public const uint MyGroupingType_Value = 15005;

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping_Name Variable.
        /// </summary>
        public const uint ExampleContainerType_MyGrouping_Name = 15008;

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping_Value Variable.
        /// </summary>
        public const uint ExampleContainerType_MyGrouping_Value = 15009;

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping_Name Variable.
        /// </summary>
        public const uint ExampleContainer_MyGrouping_Name = 15012;

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping_Value Variable.
        /// </summary>
        public const uint ExampleContainer_MyGrouping_Value = 15013;

        /// <summary>
        /// The identifier for the ListOfPorts Variable.
        /// </summary>
        public const uint ListOfPorts = 15015;

        /// <summary>
        /// The identifier for the UpdateSoftware_InputArguments Variable.
        /// </summary>
        public const uint UpdateSoftware_InputArguments = 15017;

        /// <summary>
        /// The identifier for the UpdateSoftware_OutputArguments Variable.
        /// </summary>
        public const uint UpdateSoftware_OutputArguments = 15018;

        /// <summary>
        /// The identifier for the simple-example_BinarySchema Variable.
        /// </summary>
        public const uint simple-example_BinarySchema = 15019;

        /// <summary>
        /// The identifier for the simple-example_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint simple-example_BinarySchema_NamespaceUri = 15021;

        /// <summary>
        /// The identifier for the simple-example_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint simple-example_BinarySchema_Deprecated = 15022;

        /// <summary>
        /// The identifier for the simple-example_XmlSchema Variable.
        /// </summary>
        public const uint simple-example_XmlSchema = 15023;

        /// <summary>
        /// The identifier for the simple-example_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint simple-example_XmlSchema_NamespaceUri = 15025;

        /// <summary>
        /// The identifier for the simple-example_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint simple-example_XmlSchema_Deprecated = 15026;
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
        /// The identifier for the Ipv4Address DataType.
        /// </summary>
        public static readonly ExpandedNodeId Ipv4Address = new ExpandedNodeId(simex.DataTypes.Ipv4Address, simex.Namespaces.simple-example);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the UpdateSoftware Method.
        /// </summary>
        public static readonly ExpandedNodeId UpdateSoftware = new ExpandedNodeId(simex.Methods.UpdateSoftware, simex.Namespaces.simple-example);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Bag Object.
        /// </summary>
        public static readonly ExpandedNodeId Bag = new ExpandedNodeId(simex.Objects.Bag, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping Object.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainerType_MyGrouping = new ExpandedNodeId(simex.Objects.ExampleContainerType_MyGrouping, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainer Object.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainer = new ExpandedNodeId(simex.Objects.ExampleContainer, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping Object.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainer_MyGrouping = new ExpandedNodeId(simex.Objects.ExampleContainer_MyGrouping, simex.Namespaces.simple-example);
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
        /// The identifier for the BagType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BagType = new ExpandedNodeId(simex.ObjectTypes.BagType, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the MyGroupingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MyGroupingType = new ExpandedNodeId(simex.ObjectTypes.MyGroupingType, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainerType = new ExpandedNodeId(simex.ObjectTypes.ExampleContainerType, simex.Namespaces.simple-example);
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
        /// The identifier for the MyGroupingType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyGroupingType_Name = new ExpandedNodeId(simex.Variables.MyGroupingType_Name, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the MyGroupingType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyGroupingType_Value = new ExpandedNodeId(simex.Variables.MyGroupingType_Value, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainerType_MyGrouping_Name = new ExpandedNodeId(simex.Variables.ExampleContainerType_MyGrouping_Name, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainerType_MyGrouping_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainerType_MyGrouping_Value = new ExpandedNodeId(simex.Variables.ExampleContainerType_MyGrouping_Value, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainer_MyGrouping_Name = new ExpandedNodeId(simex.Variables.ExampleContainer_MyGrouping_Name, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ExampleContainer_MyGrouping_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleContainer_MyGrouping_Value = new ExpandedNodeId(simex.Variables.ExampleContainer_MyGrouping_Value, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the ListOfPorts Variable.
        /// </summary>
        public static readonly ExpandedNodeId ListOfPorts = new ExpandedNodeId(simex.Variables.ListOfPorts, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the UpdateSoftware_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UpdateSoftware_InputArguments = new ExpandedNodeId(simex.Variables.UpdateSoftware_InputArguments, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the UpdateSoftware_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UpdateSoftware_OutputArguments = new ExpandedNodeId(simex.Variables.UpdateSoftware_OutputArguments, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_BinarySchema = new ExpandedNodeId(simex.Variables.simple-example_BinarySchema, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_BinarySchema_NamespaceUri = new ExpandedNodeId(simex.Variables.simple-example_BinarySchema_NamespaceUri, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_BinarySchema_Deprecated = new ExpandedNodeId(simex.Variables.simple-example_BinarySchema_Deprecated, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_XmlSchema = new ExpandedNodeId(simex.Variables.simple-example_XmlSchema, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_XmlSchema_NamespaceUri = new ExpandedNodeId(simex.Variables.simple-example_XmlSchema_NamespaceUri, simex.Namespaces.simple-example);

        /// <summary>
        /// The identifier for the simple-example_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId simple-example_XmlSchema_Deprecated = new ExpandedNodeId(simex.Variables.simple-example_XmlSchema_Deprecated, simex.Namespaces.simple-example);
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
        /// The BrowseName for the Bag component.
        /// </summary>
        public const string Bag = "Bag";

        /// <summary>
        /// The BrowseName for the BagType component.
        /// </summary>
        public const string BagType = "BagType";

        /// <summary>
        /// The BrowseName for the ExampleContainer component.
        /// </summary>
        public const string ExampleContainer = "ExampleContainer";

        /// <summary>
        /// The BrowseName for the ExampleContainerType component.
        /// </summary>
        public const string ExampleContainerType = "ExampleContainerType";

        /// <summary>
        /// The BrowseName for the Ipv4Address component.
        /// </summary>
        public const string Ipv4Address = "Ipv4Address";

        /// <summary>
        /// The BrowseName for the ListOfPorts component.
        /// </summary>
        public const string ListOfPorts = "ListOfPorts";

        /// <summary>
        /// The BrowseName for the MyGrouping component.
        /// </summary>
        public const string MyGrouping = "MyGrouping";

        /// <summary>
        /// The BrowseName for the MyGroupingType component.
        /// </summary>
        public const string MyGroupingType = "MyGroupingType";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the simple-example_BinarySchema component.
        /// </summary>
        public const string simple-example_BinarySchema = "simex";

        /// <summary>
        /// The BrowseName for the simple-example_XmlSchema component.
        /// </summary>
        public const string simple-example_XmlSchema = "simex";

        /// <summary>
        /// The BrowseName for the UpdateSoftware component.
        /// </summary>
        public const string UpdateSoftware = "UpdateSoftware";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";
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
        /// The URI for the simple-example namespace (.NET code namespace is 'simex').
        /// </summary>
        public const string simple-example = "http://example.com/simple-example/";
    }
    #endregion
}