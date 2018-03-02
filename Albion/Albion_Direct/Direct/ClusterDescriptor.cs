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
    /* Internal type: ank */
    public partial class ClusterDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ank _internal;
        
        #region Properties
        
        public ank ClusterDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public AgentDescriptor GetAgent(Guid A_0) => _internal.ao((Guid)A_0);
        public List<AgentDescriptor> GetAgents() => _internal.ba().Select(x =>(AgentDescriptor)x).ToList();
        public Point2 GetCenter() => _internal.bs();
        public ClusterTypeDescriptor GetClusterType() => _internal.au();
        public List<ClusterExitDescriptor> GetExits() => _internal.a5().Select(x =>(ClusterExitDescriptor)x).ToList();
        public string GetIdent() => _internal.ao();
        public Point2 GetOrigin() => _internal.a0();
        public Point2 GetSize() => _internal.a1();
        public List<TerritoryDescriptor> GetTerritories() => _internal.a8().Select(x =>(TerritoryDescriptor)x).ToList();
        public TerritoryDescriptor GetTerritory(Guid A_0) => _internal.ap((Guid)A_0);
        public string GetName() => _internal.ar();
        #endregion
        
        #region Constructor
        
        public ClusterDescriptor(ank instance)
        {
            _internal = instance;
        }
        
        static ClusterDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ank(ClusterDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterDescriptor(ank instance)
        {
            return new ClusterDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
