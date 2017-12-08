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
using System.Linq;

namespace Albion_Direct
{
    /* Internal type: auz */
    public partial class Guild
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private auz _internal;
        
        #region Properties
        
        public auz Guild_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public GuildMember[] GetMembers() => _internal.al().Select(x =>(GuildMember)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public Guild(auz instance)
        {
            _internal = instance;
        }
        
        static Guild()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator auz(Guild instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Guild(auz instance)
        {
            return new Guild(instance);
        }
        
        public static implicit operator bool(Guild instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}