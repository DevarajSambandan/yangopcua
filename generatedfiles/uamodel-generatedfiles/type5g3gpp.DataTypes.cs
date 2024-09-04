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
    #region CommmodeltypeType Enumeration
    #if (!OPCUA_EXCLUDE_CommmodeltypeType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = type5g3gpp.Namespaces._3gpp-5g-common-yang-types)]
    public enum CommmodeltypeType
    {
        /// <remarks />
        [EnumMember(Value = "enum DIRECT_COMMUNICATION_WO_NRF_0")]
        enum DIRECT_COMMUNICATION_WO_NRF = 0,

        /// <remarks />
        [EnumMember(Value = "enum DIRECT_COMMUNICATION_WITH_NRF_1")]
        enum DIRECT_COMMUNICATION_WITH_NRF = 1,

        /// <remarks />
        [EnumMember(Value = "enum INDIRECT_COMMUNICATION_WO_DEDICATED_DISCOVERY_2")]
        enum INDIRECT_COMMUNICATION_WO_DEDICATED_DISCOVERY = 2,

        /// <remarks />
        [EnumMember(Value = "enum INDIRECT_COMMUNICATION_WITH_DEDICATED_DISCOVERY_3")]
        enum INDIRECT_COMMUNICATION_WITH_DEDICATED_DISCOVERY = 3,
    }

    #region CommmodeltypeTypeCollection Class
    /// <summary>
    /// A collection of CommmodeltypeType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCommmodeltypeType", Namespace = type5g3gpp.Namespaces._3gpp-5g-common-yang-types, ItemName = "CommmodeltypeType")]
    #if !NET_STANDARD
    public partial class CommmodeltypeTypeCollection : List<CommmodeltypeType>, ICloneable
    #else
    public partial class CommmodeltypeTypeCollection : List<CommmodeltypeType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CommmodeltypeTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CommmodeltypeTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CommmodeltypeTypeCollection(IEnumerable<CommmodeltypeType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CommmodeltypeTypeCollection(CommmodeltypeType[] values)
        {
            if (values != null)
            {
                return new CommmodeltypeTypeCollection(values);
            }

            return new CommmodeltypeTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CommmodeltypeType[](CommmodeltypeTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CommmodeltypeTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommmodeltypeTypeCollection clone = new CommmodeltypeTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CommmodeltypeType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DayofweektType Enumeration
    #if (!OPCUA_EXCLUDE_DayofweektType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = type5g3gpp.Namespaces._3gpp-5g-common-yang-types)]
    public enum DayofweektType
    {
        /// <remarks />
        [EnumMember(Value = "enum Monday_1")]
        enum Monday = 1,

        /// <remarks />
        [EnumMember(Value = "enum Tuesday_2")]
        enum Tuesday = 2,

        /// <remarks />
        [EnumMember(Value = "enum Wednesday_3")]
        enum Wednesday = 3,

        /// <remarks />
        [EnumMember(Value = "enum Thursday_4")]
        enum Thursday = 4,

        /// <remarks />
        [EnumMember(Value = "enum Friday_5")]
        enum Friday = 5,

        /// <remarks />
        [EnumMember(Value = "enum Saturday_6")]
        enum Saturday = 6,

        /// <remarks />
        [EnumMember(Value = "enum Sunday_7")]
        enum Sunday = 7,
    }

    #region DayofweektTypeCollection Class
    /// <summary>
    /// A collection of DayofweektType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDayofweektType", Namespace = type5g3gpp.Namespaces._3gpp-5g-common-yang-types, ItemName = "DayofweektType")]
    #if !NET_STANDARD
    public partial class DayofweektTypeCollection : List<DayofweektType>, ICloneable
    #else
    public partial class DayofweektTypeCollection : List<DayofweektType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DayofweektTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DayofweektTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DayofweektTypeCollection(IEnumerable<DayofweektType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DayofweektTypeCollection(DayofweektType[] values)
        {
            if (values != null)
            {
                return new DayofweektTypeCollection(values);
            }

            return new DayofweektTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DayofweektType[](DayofweektTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DayofweektTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DayofweektTypeCollection clone = new DayofweektTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DayofweektType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}