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
    /* Internal type: e0 */
    public partial class PlayerCharactersDataFile : CharactersDataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private e0 _internal;
        
        #region Properties
        
        public e0 PlayerCharactersDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public PlayerCharactersDataFile(e0 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static PlayerCharactersDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator e0(PlayerCharactersDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PlayerCharactersDataFile(e0 instance)
        {
            return new PlayerCharactersDataFile(instance);
        }
        
        public static implicit operator bool(PlayerCharactersDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}