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
    /* Internal type: aie */
    public partial class SpellSlot
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aie _internal;
        
        #region Properties
        
        public aie SpellSlot_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetCooldownPercent(GameTimeStamp A_0) => _internal.n((GameTimeStamp)A_0);
        public GameTimeStamp GetCooldownTimeStamp() => _internal.o();
        public CastSpellDescriptor GetSpellDescriptor() => _internal.k();
        
        #endregion
        
        #region Constructor
        
        public SpellSlot(aie instance)
        {
            _internal = instance;
        }
        
        static SpellSlot()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aie(SpellSlot instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellSlot(aie instance)
        {
            return new SpellSlot(instance);
        }
        
        public static implicit operator bool(SpellSlot instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
