//namespace TaskInfo.Core.Enums
//{
//    /// <summary>
//    /// 0 Pending, 1 Progress, 2 Completed
//    /// </summary>
//    public enum CustomTaskStatus
//    {
//        Pending,
//        InProgress,
//        Completed
//    }

//}


using System.Runtime.Serialization;

namespace TaskInfo.Core.Enums
{
    /// <summary>
    /// Task Status Enum
    /// </summary>
    public enum CustomTaskStatus
    {
        [EnumMember(Value = "Pending")]
        Pending = 0,

        [EnumMember(Value = "InProgress")]
        InProgress = 1,

        [EnumMember(Value = "Completed")]
        Completed = 2
    }
}
