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
    /* Internal type: au5 */
    public partial class GuildMember
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private au5 _internal;
        
        #region Properties
        
        public au5 GuildMember_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuildMember(au5 instance)
        {
            _internal = instance;
        }
        
        static GuildMember()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator au5(GuildMember instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuildMember(au5 instance)
        {
            return new GuildMember(instance);
        }
        
        public static implicit operator bool(GuildMember instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
