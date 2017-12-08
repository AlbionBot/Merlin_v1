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

namespace Albion_Direct
{
    /* Internal type: a42 */
    public partial class MountObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a42 _internal;
        
        #region Properties
        
        public a42 MountObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public MountItemDescriptor GetDescriptor() => _internal.s8();
        public bool IsInRemountDistance() => _internal.tb();
        public bool IsLocalPlayers() => _internal.s9();
        
        #endregion
        
        #region Constructor
        
        public MountObject(a42 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MountObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a42(MountObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MountObject(a42 instance)
        {
            return new MountObject(instance);
        }
        
        public static implicit operator bool(MountObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}