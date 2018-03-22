////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.114130-prod
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
    /* Internal type: aiq */
    public partial class TileDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aiq _internal;
        
        #region Properties
        
        public aiq TileDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TileDescriptor(aiq instance)
        {
            _internal = instance;
        }
        
        static TileDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aiq(TileDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TileDescriptor(aiq instance)
        {
            return new TileDescriptor(instance);
        }
        
        public static implicit operator bool(TileDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
