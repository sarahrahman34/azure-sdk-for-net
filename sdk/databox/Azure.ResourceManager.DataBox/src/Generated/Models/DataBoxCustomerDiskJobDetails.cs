// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Customer disk job details. </summary>
    public partial class DataBoxCustomerDiskJobDetails : JobDetails
    {
        /// <summary> Initializes a new instance of DataBoxCustomerDiskJobDetails. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="returnToCustomerPackageDetails"> Return package shipping details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactDetails"/> or <paramref name="returnToCustomerPackageDetails"/> is null. </exception>
        public DataBoxCustomerDiskJobDetails(ContactDetails contactDetails, PackageCarrierDetails returnToCustomerPackageDetails) : base(contactDetails)
        {
            if (contactDetails == null)
            {
                throw new ArgumentNullException(nameof(contactDetails));
            }
            if (returnToCustomerPackageDetails == null)
            {
                throw new ArgumentNullException(nameof(returnToCustomerPackageDetails));
            }

            ImportDiskDetailsCollection = new ChangeTrackingDictionary<string, ImportDiskDetails>();
            ExportDiskDetailsCollection = new ChangeTrackingDictionary<string, ExportDiskDetails>();
            CopyProgress = new ChangeTrackingList<DataBoxCustomerDiskCopyProgress>();
            ReturnToCustomerPackageDetails = returnToCustomerPackageDetails;
            JobDetailsType = ClassDiscriminator.DataBoxCustomerDisk;
        }

        /// <summary> Initializes a new instance of DataBoxCustomerDiskJobDetails. </summary>
        /// <param name="jobStages"> List of stages that run in the job. </param>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deliveryPackage"> Delivery package shipping details. </param>
        /// <param name="returnPackage"> Return package shipping details. </param>
        /// <param name="dataImportDetails"> Details of the data to be imported into azure. </param>
        /// <param name="dataExportDetails"> Details of the data to be exported from azure. </param>
        /// <param name="jobDetailsType"> Indicates the type of job details. </param>
        /// <param name="preferences"> Preferences for the order. </param>
        /// <param name="copyLogDetails">
        /// List of copy log details.
        /// Please note <see cref="CopyLogDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxAccountCopyLogDetails"/>, <see cref="DataBoxCustomerDiskCopyLogDetails"/>, <see cref="DataBoxDiskCopyLogDetails"/> and <see cref="DataBoxHeavyAccountCopyLogDetails"/>.
        /// </param>
        /// <param name="reverseShipmentLabelSasKey"> Shared access key to download the return shipment label. </param>
        /// <param name="chainOfCustodySasKey"> Shared access key to download the chain of custody logs. </param>
        /// <param name="deviceErasureDetails"> Holds device data erasure details. </param>
        /// <param name="keyEncryptionKey"> Details about which key encryption type is being used. </param>
        /// <param name="expectedDataSizeInTeraBytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        /// <param name="actions"> Available actions on the job. </param>
        /// <param name="lastMitigationActionOnJob"> Last mitigation action performed on the job. </param>
        /// <param name="datacenterAddress">
        /// Datacenter address to ship to, for the given sku and storage location.
        /// Please note <see cref="DatacenterAddressResponse"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DatacenterAddressInstructionResponse"/> and <see cref="DatacenterAddressLocationResponse"/>.
        /// </param>
        /// <param name="dataCenterCode"> DataCenter code. </param>
        /// <param name="importDiskDetailsCollection"> Contains the map of disk serial number to the disk details for import jobs. </param>
        /// <param name="exportDiskDetailsCollection"> Contains the map of disk serial number to the disk details for export jobs. </param>
        /// <param name="copyProgress"> Copy progress per disk. </param>
        /// <param name="deliverToDcPackageDetails"> Delivery package shipping details. </param>
        /// <param name="returnToCustomerPackageDetails"> Return package shipping details. </param>
        /// <param name="enableManifestBackup"> Flag to indicate if disk manifest should be backed-up in the Storage Account. </param>
        internal DataBoxCustomerDiskJobDetails(IReadOnlyList<JobStages> jobStages, ContactDetails contactDetails, ShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, ClassDiscriminator jobDetailsType, Preferences preferences, IReadOnlyList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, DeviceErasureDetails deviceErasureDetails, KeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTeraBytes, IReadOnlyList<CustomerResolutionCode> actions, LastMitigationActionOnJob lastMitigationActionOnJob, DatacenterAddressResponse datacenterAddress, DataCenterCode? dataCenterCode, IDictionary<string, ImportDiskDetails> importDiskDetailsCollection, IReadOnlyDictionary<string, ExportDiskDetails> exportDiskDetailsCollection, IReadOnlyList<DataBoxCustomerDiskCopyProgress> copyProgress, PackageCarrierInfo deliverToDcPackageDetails, PackageCarrierDetails returnToCustomerPackageDetails, bool? enableManifestBackup) : base(jobStages, contactDetails, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, jobDetailsType, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, deviceErasureDetails, keyEncryptionKey, expectedDataSizeInTeraBytes, actions, lastMitigationActionOnJob, datacenterAddress, dataCenterCode)
        {
            ImportDiskDetailsCollection = importDiskDetailsCollection;
            ExportDiskDetailsCollection = exportDiskDetailsCollection;
            CopyProgress = copyProgress;
            DeliverToDcPackageDetails = deliverToDcPackageDetails;
            ReturnToCustomerPackageDetails = returnToCustomerPackageDetails;
            EnableManifestBackup = enableManifestBackup;
            JobDetailsType = jobDetailsType;
        }

        /// <summary> Contains the map of disk serial number to the disk details for import jobs. </summary>
        public IDictionary<string, ImportDiskDetails> ImportDiskDetailsCollection { get; }
        /// <summary> Contains the map of disk serial number to the disk details for export jobs. </summary>
        public IReadOnlyDictionary<string, ExportDiskDetails> ExportDiskDetailsCollection { get; }
        /// <summary> Copy progress per disk. </summary>
        public IReadOnlyList<DataBoxCustomerDiskCopyProgress> CopyProgress { get; }
        /// <summary> Delivery package shipping details. </summary>
        public PackageCarrierInfo DeliverToDcPackageDetails { get; }
        /// <summary> Return package shipping details. </summary>
        public PackageCarrierDetails ReturnToCustomerPackageDetails { get; set; }
        /// <summary> Flag to indicate if disk manifest should be backed-up in the Storage Account. </summary>
        public bool? EnableManifestBackup { get; set; }
    }
}
