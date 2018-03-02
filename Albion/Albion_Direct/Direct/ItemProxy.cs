////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.112411-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: ava */
    public partial class ItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ava _internal;
        
        #region Properties
        
        public ava ItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static ItemProxy Create(ItemObject A_0) => ava.o((au7)A_0);
        public ItemDescriptor GetItemDescriptor() => _internal.p();
        
        #endregion
        
        #region Constructor
        
        public ItemProxy(ava instance)
        {
            _internal = instance;
        }
        
        static ItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ava(ItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemProxy(ava instance)
        {
            return new ItemProxy(instance);
        }
        
        public static implicit operator bool(ItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
