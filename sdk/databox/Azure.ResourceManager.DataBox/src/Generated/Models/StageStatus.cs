// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Holds the device erasure completion status. </summary>
    public enum StageStatus
    {
        /// <summary> No status available yet. </summary>
        None,
        /// <summary> Stage is in progress. </summary>
        InProgress,
        /// <summary> Stage has succeeded. </summary>
        Succeeded,
        /// <summary> Stage has failed. </summary>
        Failed,
        /// <summary> Stage has been cancelled. </summary>
        Cancelled,
        /// <summary> Stage is cancelling. </summary>
        Cancelling,
        /// <summary> Stage has succeeded with errors. </summary>
        SucceededWithErrors,
        /// <summary> Stage is stuck until customer takes some action. </summary>
        WaitingForCustomerAction,
        /// <summary> Stage has succeeded with warnings. </summary>
        SucceededWithWarnings,
        /// <summary> Stage is waiting for customer action for kek action items. </summary>
        WaitingForCustomerActionForKek,
        /// <summary> Stage is waiting for customer action for clean up. </summary>
        WaitingForCustomerActionForCleanUp,
        /// <summary> Stage has performed customer action for clean up. </summary>
        CustomerActionPerformedForCleanUp,
        /// <summary> Stage has performed customer action for clean up. </summary>
        CustomerActionPerformed
    }
}
