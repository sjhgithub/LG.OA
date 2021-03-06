//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LG.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstancesTable
    {
        public System.Guid Id { get; set; }
        public long SurrogateInstanceId { get; set; }
        public Nullable<long> SurrogateLockOwnerId { get; set; }
        public byte[] PrimitiveDataProperties { get; set; }
        public byte[] ComplexDataProperties { get; set; }
        public byte[] WriteOnlyPrimitiveDataProperties { get; set; }
        public byte[] WriteOnlyComplexDataProperties { get; set; }
        public byte[] MetadataProperties { get; set; }
        public Nullable<byte> DataEncodingOption { get; set; }
        public Nullable<byte> MetadataEncodingOption { get; set; }
        public long Version { get; set; }
        public Nullable<System.DateTime> PendingTimer { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.Guid> WorkflowHostType { get; set; }
        public Nullable<long> ServiceDeploymentId { get; set; }
        public string SuspensionExceptionName { get; set; }
        public string SuspensionReason { get; set; }
        public string BlockingBookmarks { get; set; }
        public string LastMachineRunOn { get; set; }
        public string ExecutionStatus { get; set; }
        public Nullable<bool> IsInitialized { get; set; }
        public Nullable<bool> IsSuspended { get; set; }
        public Nullable<bool> IsReadyToRun { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public long SurrogateIdentityId { get; set; }
    }
}
