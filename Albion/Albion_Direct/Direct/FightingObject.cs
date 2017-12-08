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
    /* Internal type: avw */
    public partial class FightingObject : MovingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private avw _internal;
        
        #region Properties
        
        public avw FightingObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public FightingAttributes GetAttributes() => _internal.at();
        public ObservableRange<afr> GetEnergy() => _internal.xr();
        public ObservableRange<afr> GetHealth() => _internal.xq();
        public CharacterDescriptor GetCharacterDescriptor() => _internal.xz();
        public bool GetIsAttacking() => _internal.zp();
        public bool GetIsCasting() => _internal.zk();
        public bool GetIsDead() => _internal.jg();
        public bool GetIsChanneling() => _internal.zl();
        public bool GetIsIdle() => _internal.zj();
        public float GetLoad() => _internal.ji();
        public float GetLoadPercentage() => _internal.x2();
        public float GetLoadSpeedFactor() => _internal.x3();
        public float GetMaxLoad() => _internal.x1();
        public string GetName() => _internal.iu();
        public long GetTargetId() => _internal.xw();
        public a GetEventHandler<a>() where a: avx => (a)_internal.y9<a>();
        
        #endregion
        
        #region Constructor
        
        public FightingObject(avw instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FightingObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator avw(FightingObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FightingObject(avw instance)
        {
            return new FightingObject(instance);
        }
        
        public static implicit operator bool(FightingObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}