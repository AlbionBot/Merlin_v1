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

namespace Albion_Direct
{
    /* Internal type: j3.PvpRules */
    public enum PvpRules
    {
        PvpDisabled = 0,
        PvpAllowed = 1,
        PvpForced = 2
    }
    
    public static class PvpRulesExtensions
    {
        public static j3.PvpRules ToInternal(this PvpRules instance)
        {
            return (j3.PvpRules)instance;
        }
        
        public static PvpRules ToWrapped(this j3.PvpRules instance)
        {
            return (PvpRules)instance;
        }
    }
}
