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
    /* Internal type: afy */
    public partial class ItemsDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private afy _internal;
        
        #region Properties
        
        public afy ItemsDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ItemsDataFile(afy instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ItemsDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator afy(ItemsDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemsDataFile(afy instance)
        {
            return new ItemsDataFile(instance);
        }
        
        public static implicit operator bool(ItemsDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}