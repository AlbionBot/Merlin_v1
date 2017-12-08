////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

using UnityEngine;

namespace Albion_Direct
{
    /* Internal type: bb0 */
    public partial class LandscapeManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private bb0 _internal;
        
        #region Properties
        
        public bb0 LandscapeManager_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetTerrainHeight(Point2 A_0, out RaycastHit A_1) => _internal.d((amk)A_0, out A_1);
        
        #endregion
        
        #region Constructor
        
        public LandscapeManager(bb0 instance)
        {
            _internal = instance;
        }
        
        static LandscapeManager()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator bb0(LandscapeManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator LandscapeManager(bb0 instance)
        {
            return new LandscapeManager(instance);
        }
        
        public static implicit operator bool(LandscapeManager instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}