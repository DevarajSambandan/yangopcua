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
using System.Xml;
using System.Runtime.Serialization;
using types3gpp;

namespace type5g3gpp
{
    #region SnssaiState Class
    #if (!OPCUA_EXCLUDE_SnssaiState)
    /// <summary>
    /// Stores an instance of the SnssaiType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SnssaiState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SnssaiState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(type5g3gpp.ObjectTypes.SnssaiType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACcAAAB1cm46M2dwcDpzYTU6XzNncHAtNWctY29tbW9uLXlhbmctdHlwZXMkAAAAaHR0cDovL29w" +
           "Y2ZvdW5kYXRpb24ub3JnL1VBL2RlZmF1bHQv/////wRggAIBAAAAAQASAAAAU25zc2FpVHlwZUluc3Rh" +
           "bmNlAQGsOgEBrDqsOgAA/////wIAAAA1YIkKAgAAAAEAAgAAAFNkAQGtOgMAAAAAQwAAAFNsaWNlIERp" +
           "ZmZlcmVudGlhdG9yCklmIG5vdCBuZWVkZWQsIHRoZSB2YWx1ZSBjYW4gYmUgc2V0IHRvIEZGRkZGRi4A" +
           "LgBErToAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAAwAAAFNzdAEBrjoDAAAAAJwAAABTbGljZS9T" +
           "ZXJ2aWNlIFR5cGUuClZhbHVlcyAwIHRvIDEyNyBiZWxvbmcgdG8gc3RhbmRhcmRpemVkIFNTVCByYW5n" +
           "ZSBhbmQgYXJlIGRlZmluZWQgaW4KM0dQUCBUUyAyMy41MDEuIFZhbHVlcyAxMjggdG8gMjU1IGJlbG9u" +
           "ZyB0byBvcGVyYXRvci1zcGVjaWZpYyByYW5nZS4ALgBErjoAAAAD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Sd
        {
            get
            {
                return m_sd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sd = value;
            }
        }

        /// <remarks />
        public PropertyState<byte> Sst
        {
            get
            {
                return m_sst;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sst, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sst = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sd != null)
            {
                children.Add(m_sd);
            }

            if (m_sst != null)
            {
                children.Add(m_sst);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case type5g3gpp.BrowseNames.Sd:
                {
                    if (createOrReplace)
                    {
                        if (Sd == null)
                        {
                            if (replacement == null)
                            {
                                Sd = new PropertyState<string>(this);
                            }
                            else
                            {
                                Sd = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Sd;
                    break;
                }

                case type5g3gpp.BrowseNames.Sst:
                {
                    if (createOrReplace)
                    {
                        if (Sst == null)
                        {
                            if (replacement == null)
                            {
                                Sst = new PropertyState<byte>(this);
                            }
                            else
                            {
                                Sst = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = Sst;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_sd;
        private PropertyState<byte> m_sst;
        #endregion
    }
    #endif
    #endregion

    #region SupportedfuncState Class
    #if (!OPCUA_EXCLUDE_SupportedfuncState)
    /// <summary>
    /// Stores an instance of the SupportedfuncType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SupportedfuncState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SupportedfuncState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(type5g3gpp.ObjectTypes.SupportedfuncType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACcAAAB1cm46M2dwcDpzYTU6XzNncHAtNWctY29tbW9uLXlhbmctdHlwZXMkAAAAaHR0cDovL29w" +
           "Y2ZvdW5kYXRpb24ub3JnL1VBL2RlZmF1bHQv/////wRggAIBAAAAAQAZAAAAU3VwcG9ydGVkZnVuY1R5" +
           "cGVJbnN0YW5jZQEBqToBAak6qToAAP////8CAAAAFWCJCgIAAAABAAgAAABGdW5jdGlvbgEBqjoALgBE" +
           "qjoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAFBvbGljeQEBqzoALgBEqzoAAAAM/////wEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Function
        {
            get
            {
                return m_function;
            }

            set
            {
                if (!Object.ReferenceEquals(m_function, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_function = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Policy
        {
            get
            {
                return m_policy;
            }

            set
            {
                if (!Object.ReferenceEquals(m_policy, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_policy = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_function != null)
            {
                children.Add(m_function);
            }

            if (m_policy != null)
            {
                children.Add(m_policy);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case type5g3gpp.BrowseNames.Function:
                {
                    if (createOrReplace)
                    {
                        if (Function == null)
                        {
                            if (replacement == null)
                            {
                                Function = new PropertyState<string>(this);
                            }
                            else
                            {
                                Function = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Function;
                    break;
                }

                case type5g3gpp.BrowseNames.Policy:
                {
                    if (createOrReplace)
                    {
                        if (Policy == null)
                        {
                            if (replacement == null)
                            {
                                Policy = new PropertyState<string>(this);
                            }
                            else
                            {
                                Policy = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Policy;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_function;
        private PropertyState<string> m_policy;
        #endregion
    }
    #endif
    #endregion

    #region CommmodelState Class
    #if (!OPCUA_EXCLUDE_CommmodelState)
    /// <summary>
    /// Stores an instance of the CommmodelType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommmodelState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommmodelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(type5g3gpp.ObjectTypes.CommmodelType, type5g3gpp.Namespaces._3gpp-5g-common-yang-types, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACcAAAB1cm46M2dwcDpzYTU6XzNncHAtNWctY29tbW9uLXlhbmctdHlwZXMkAAAAaHR0cDovL29w" +
           "Y2ZvdW5kYXRpb24ub3JnL1VBL2RlZmF1bHQv/////wRggAIBAAAAAQAVAAAAQ29tbW1vZGVsVHlwZUlu" +
           "c3RhbmNlAQGvOgEBrzqvOgAA/////wQAAAAVYIkKAgAAAAEABwAAAEdyb3VwaWQBAbA6AC4ARLA6AAAA" +
           "Bf////8BAf////8AAAAAFWCJCgIAAAABAA0AAABDb21tbW9kZWx0eXBlAQGxOgAuAESxOgAAAQGZOv//" +
           "//8BAf////8AAAAAFWCJCgIAAAABABMAAABUYXJnZXRuZnNlcnZpY2VsaXN0AQGyOgAuAESyOgAAAQGZ" +
           "Ov////8BAf////8AAAAAFWCJCgIAAAABABYAAABDb21tbW9kZWxjb25maWd1cmF0aW9uAQGzOgAuAESz" +
           "OgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> Groupid
        {
            get
            {
                return m_groupid;
            }

            set
            {
                if (!Object.ReferenceEquals(m_groupid, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_groupid = value;
            }
        }

        /// <remarks />
        public PropertyState<CommmodeltypeType> Commmodeltype
        {
            get
            {
                return m_commmodeltype;
            }

            set
            {
                if (!Object.ReferenceEquals(m_commmodeltype, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_commmodeltype = value;
            }
        }

        /// <remarks />
        public PropertyState<CommmodeltypeType> Targetnfservicelist
        {
            get
            {
                return m_targetnfservicelist;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetnfservicelist, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetnfservicelist = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Commmodelconfiguration
        {
            get
            {
                return m_commmodelconfiguration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_commmodelconfiguration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_commmodelconfiguration = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_groupid != null)
            {
                children.Add(m_groupid);
            }

            if (m_commmodeltype != null)
            {
                children.Add(m_commmodeltype);
            }

            if (m_targetnfservicelist != null)
            {
                children.Add(m_targetnfservicelist);
            }

            if (m_commmodelconfiguration != null)
            {
                children.Add(m_commmodelconfiguration);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case type5g3gpp.BrowseNames.Groupid:
                {
                    if (createOrReplace)
                    {
                        if (Groupid == null)
                        {
                            if (replacement == null)
                            {
                                Groupid = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                Groupid = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Groupid;
                    break;
                }

                case type5g3gpp.BrowseNames.Commmodeltype:
                {
                    if (createOrReplace)
                    {
                        if (Commmodeltype == null)
                        {
                            if (replacement == null)
                            {
                                Commmodeltype = new PropertyState<CommmodeltypeType>(this);
                            }
                            else
                            {
                                Commmodeltype = (PropertyState<CommmodeltypeType>)replacement;
                            }
                        }
                    }

                    instance = Commmodeltype;
                    break;
                }

                case type5g3gpp.BrowseNames.Targetnfservicelist:
                {
                    if (createOrReplace)
                    {
                        if (Targetnfservicelist == null)
                        {
                            if (replacement == null)
                            {
                                Targetnfservicelist = new PropertyState<CommmodeltypeType>(this);
                            }
                            else
                            {
                                Targetnfservicelist = (PropertyState<CommmodeltypeType>)replacement;
                            }
                        }
                    }

                    instance = Targetnfservicelist;
                    break;
                }

                case type5g3gpp.BrowseNames.Commmodelconfiguration:
                {
                    if (createOrReplace)
                    {
                        if (Commmodelconfiguration == null)
                        {
                            if (replacement == null)
                            {
                                Commmodelconfiguration = new PropertyState<string>(this);
                            }
                            else
                            {
                                Commmodelconfiguration = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Commmodelconfiguration;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_groupid;
        private PropertyState<CommmodeltypeType> m_commmodeltype;
        private PropertyState<CommmodeltypeType> m_targetnfservicelist;
        private PropertyState<string> m_commmodelconfiguration;
        #endregion
    }
    #endif
    #endregion
}