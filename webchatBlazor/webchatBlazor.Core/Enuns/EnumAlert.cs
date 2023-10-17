using System.ComponentModel;

namespace webchatBlazor.Core.Enuns
{
    public enum EnumAlert
    {   
        [Description("Danger")]
        Danger = 0,

        [Description("Info")]
        Info = 1,

        [Description("Success")]
        Success = 3,

        [Description("Warning")]
        Warning = 4
    }
}
