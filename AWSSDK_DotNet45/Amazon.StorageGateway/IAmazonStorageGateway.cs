/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.StorageGateway.Model;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Interface for accessing AmazonStorageGateway.
    /// 
    /// AWS Storage Gateway Service <para>AWS Storage Gateway is the service that connects an on-premises software appliance with cloud-based
    /// storage to provide seamless and secure integration between an organization's on-premises IT environment and AWS's storage infrastructure.
    /// The service enables you to securely upload data to the AWS cloud for cost effective backup and rapid disaster recovery.</para> <para>Use the
    /// following links to get started using the <i>AWS Storage Gateway Service API Reference</i> :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayHTTPRequestsHeaders.html">AWS Storage Gateway
    /// Required Request Headers</a> : Describes the required headers that you must send with every POST request to AWS Storage Gateway.</li>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewaySigningRequests.html">Signing Requests</a> : AWS
    /// Storage Gateway requires that you authenticate every request you send; this topic describes how sign such a request.</li>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/APIErrorResponses.html">Error Responses</a> : Provides reference
    /// information about AWS Storage Gateway errors.</li>
    /// <li> <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPIOperations.html">Operations in AWS Storage
    /// Gateway</a> : Contains detailed descriptions of all AWS Storage Gateway operations, their request parameters, response elements, possible
    /// errors, and examples of requests and responses.</li>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">AWS Storage Gateway Regions and Endpoints</a> : Provides
    /// a list of each of the regions and endpoints available for use with AWS Storage Gateway. </li>
    /// 
    /// </ul>
    /// </summary>
	public partial interface IAmazonStorageGateway : IDisposable
    {
 

        /// <summary>
        /// <para>This operation activates the gateway you previously deployed on your host. For more information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/DownloadAndDeploy.html">Downloading and Deploying AWS Storage Gateway
        /// VM</a> . In the activation process you specify information such as the region you want to use for storing snapshots, the time zone for
        /// scheduled snapshots and the gateway schedule window, an activation key, and a name for your gateway. The activation process also associates
        /// your gateway with your account (see UpdateGatewayInformation).</para> <para><b>NOTE:</b>You must power on the gateway VM before you can
        /// activate your gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ActivateGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation configures one or more gateway local disks as cache for a cached-volume gateway. This operation is supported only for
        /// the gateway-cached volume architecture (see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">Storage Gateway Concepts</a> ).</para> <para>In the request, you specify the gateway Amazon Resource Name (ARN) to which you want to add
        /// cache, and one or more disk IDs that you want to configure as cache. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddCacheResponse AddCache(AddCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation configures one or more gateway local disks as upload buffer for a specified gateway. This operation is supported for
        /// both the gateway-stored and gateway-cached volume architectures. </para> <para> In the request, you specify the gateway Amazon Resource Name
        /// (ARN) to which you want to add upload buffer, and one or more disk IDs that you want to configure as upload buffer.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation configures one or more gateway local disks as working storage for a gateway. This operation is supported only for the
        /// gateway-stored volume architecture. This operation is deprecated method in cached-volumes API version (20120630). Use AddUploadBuffer
        /// instead.</para> <para><b>NOTE:</b> Working storage is also referred to as upload buffer. You can also use the AddUploadBuffer operation to
        /// add upload buffer to a stored-volume gateway. </para> <para>In the request, you specify the gateway Amazon Resource Name (ARN) to which you
        /// want to add working storage, and one or more disk IDs that you want to configure as working storage.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.AddWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving process is initiated. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CancelArchivalResponse CancelArchival(CancelArchivalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelArchival operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CancelArchival"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelArchivalResponse> CancelArchivalAsync(CancelArchivalRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway after the retrieval process is initiated. The
        /// virtual tape is returned to the VTS.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRetrieval operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CancelRetrieval"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelRetrievalResponse> CancelRetrievalAsync(CancelRetrievalRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation creates a cached volume on a specified cached gateway. This operation is supported only for the gateway-cached volume
        /// architecture.</para> <para><b>NOTE:</b>Cache storage must be allocated to the gateway before you can create a cached volume. Use the
        /// AddCache operation to add cache storage to a gateway. </para> <para>In the request, you must specify the gateway, size of the volume in
        /// bytes, the iSCSI target name, an IP address on which to expose the target, and a unique client token. In response, AWS Storage Gateway
        /// creates the volume and returns information about it such as the volume Amazon Resource Name (ARN), its size, and the iSCSI target ARN that
        /// initiators can use to connect to the volume target.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateCachediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation initiates a snapshot of a volume.</para> <para>AWS Storage Gateway provides the ability to back up point-in-time
        /// snapshots of your data to Amazon Simple Storage (S3) for durable off-site recovery, as well as import the data to an Amazon Elastic Block
        /// Store (EBS) volume in Amazon Elastic Compute Cloud (EC2). You can take snapshots of your gateway volume on a scheduled or ad-hoc basis. This
        /// API enables you to take ad-hoc snapshot. For more information, see <a href="TBD">Working With Snapshots in the AWS Storage Gateway
        /// Console</a> .</para> <para>In the CreateSnapshot request you identify the volume by providing its Amazon Resource Name (ARN). You must also
        /// provide description for the snapshot. When AWS Storage Gateway takes the snapshot of specified volume, the snapshot and description appears
        /// in the AWS Storage Gateway Console. In response, AWS Storage Gateway returns you a snapshot ID. You can use this snapshot ID to check the
        /// snapshot progress or later use it when you want to create a volume from a snapshot.</para> <para><b>NOTE:</b>To list or delete a snapshot,
        /// you must use the Amazon EC2 API. For more information, .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation initiates a snapshot of a gateway from a volume recovery point. This operation is supported only for the gateway-cached
        /// volume architecture (see ).</para> <para>A volume recovery point is a point in time at which all data of the volume is consistent and from
        /// which you can create a snapshot. To get a list of volume recovery point for gateway-cached volumes, use ListVolumeRecoveryPoints.</para>
        /// <para>In the <c>CreateSnapshotFromVolumeRecoveryPoint</c> request, you identify the volume by providing its Amazon Resource Name (ARN). You
        /// must also provide a description for the snapshot. When AWS Storage Gateway takes a snapshot of the specified volume, the snapshot and its
        /// description appear in the AWS Storage Gateway console. In response, AWS Storage Gateway returns you a snapshot ID. You can use this
        /// snapshot ID to check the snapshot progress or later use it when you want to create a volume from a snapshot.</para> <para><b>NOTE:</b> To
        /// list or delete a snapshot, you must use the Amazon EC2 API. For more information, in Amazon Elastic Compute Cloud API Reference. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// CreateSnapshotFromVolumeRecoveryPoint service method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateSnapshotFromVolumeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation creates a volume on a specified gateway. This operation is supported only for the gateway-stored volume architecture.
        /// </para> <para>The size of the volume to create is inferred from the disk size. You can choose to preserve existing data on the disk, create
        /// volume from an existing snapshot, or create an empty volume. If you choose to create an empty gateway volume, then any existing data on the
        /// disk is erased.</para> <para>In the request you must specify the gateway and the disk information on which you are creating the volume. In
        /// response, AWS Storage Gateway creates the volume and returns volume information such as the volume Amazon Resource Name (ARN), its size, and
        /// the iSCSI target ARN that initiators can use to connect to the volume target.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateStorediSCSIVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates one or more virtual tapes. You write data to the virtual tapes and then archive the tapes.</para> <para><b>NOTE:</b>Cache
        /// storage must be allocated to the gateway before you can create virtual tapes. Use the AddCache operation to add cache storage to a gateway.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		CreateTapesResponse CreateTapes(CreateTapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.CreateTapes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateTapesResponse> CreateTapesAsync(CreateTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation deletes the bandwidth rate limits of a gateway. You can delete either the upload and download bandwidth rate limit, or
        /// you can delete both. If you delete only one of the limits, the other limit remains unchanged. To specify which gateway to work with, use the
        /// Amazon Resource Name (ARN) of the gateway in your request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified iSCSI target and initiator
        /// pair.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name (ARN) of the gateway in your
        /// request. The operation deletes the gateway; however, it does not delete the gateway virtual machine (VM) from your host computer.</para>
        /// <para>After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway volumes are not deleted upon deleting the
        /// gateway, however, pending snapshots will not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.</para> <para><b>IMPORTANT:</b> You no longer pay software charges after the gateway is deleted; however, your existing Amazon
        /// EBS snapshots persist and you will continue to be billed for these snapshots. You can choose to remove all remaining Amazon EBS snapshots by
        /// canceling your Amazon EC2 subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete your snapshots using the
        /// Amazon EC2 console. For more information, see the AWS Storage Gateway Detail Page. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> This operation deletes a snapshot of a volume. </para> <para> You can take snapshots of your gateway volumes on a scheduled or ad-hoc
        /// basis. This API enables you to delete a snapshot schedule for a volume. For more information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working with Snapshots</a> . In the
        /// <c>DeleteSnapshotSchedule</c> request, you identify the volume by providing its Amazon Resource Name (ARN). </para> <para><b>NOTE:</b> To
        /// list or delete a snapshot, you must use the Amazon EC2 API. in Amazon Elastic Compute Cloud API Reference. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified virtual tape.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteTapeResponse DeleteTape(DeleteTapeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTape operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteTape"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteTapeResponse> DeleteTapeAsync(DeleteTapeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified virtual tape from the virtual tape shelf (VTS).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteTapeArchive"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteTapeArchiveResponse> DeleteTapeArchiveAsync(DeleteTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation delete the specified gateway volume that you previously created using the CreateStorediSCSIVolume API. For
        /// gateway-stored volumes, the local disk that was configured as the storage volume is not deleted. You can reuse the local disk to create
        /// another storage volume. </para> <para>Before you delete a gateway volume, make sure there are no iSCSI connections to the volume you are
        /// deleting. You should also make sure there is no snapshot in progress. You can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query
        /// snapshots on the volume you are deleting and check the snapshot status. For more information, go to <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud API Reference</i> .</para> <para>In the request, you must provide the Amazon Resource Name (ARN) of the
        /// storage volume you want to delete.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns the bandwidth rate limits of a gateway. By default, these limits are not set, which means no bandwidth rate
        /// limiting is in effect.</para> <para>This operation only returns a value for a bandwidth rate limit only if the limit is set. If no limits
        /// are set for the gateway, then this operation returns only the gateway ARN in the response body. To specify which gateway to describe, use
        /// the Amazon Resource Name (ARN) of the gateway in your request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns information about the cache of a gateway. This operation is supported only for the gateway-cached volume
        /// architecture. </para> <para> The response includes disk IDs that are configured as cache, and it includes the amount of cache allocated and
        /// used. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeCacheResponse DescribeCache(DescribeCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns a description of the gateway volumes specified in the request. This operation is supported only for the
        /// gateway-cached volume architecture.</para> <para> The list of gateway volumes in the request must be from one gateway. In the response
        /// Amazon Storage Gateway returns volume information sorted by volume Amazon Resource Name (ARN). </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeCachediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials information for a specified iSCSI
        /// target, one for each target-initiator pair.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns metadata about a gateway such as its name, network interfaces, configured time zone, and the state (whether the
        /// gateway is running or not). To specify which gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns your gateway's weekly maintenance start time including the day and time of the week. Note that values are in
        /// terms of the gateway's time zone.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation describes the snapshot schedule for the specified gateway volume. The snapshot schedule information includes intervals
        /// at which snapshots are automatically initiated on the volume.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns description of the gateway volumes specified in the request. The list of gateway volumes in the request must be
        /// from one gateway. In the response Amazon Storage Gateway returns volume information sorted by volume ARNs.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeStorediSCSIVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a description of specified virtual tapes in the virtual tape shelf (VTS). </para> <para>If a specific <c>TapeARN</c> is not
        /// specified, AWS Storage Gateway returns a description of all virtual tapes found in the VTS associated with your account.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeArchives operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeTapeArchives"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(DescribeTapeArchivesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a description of specified virtual tapes in the virtual tape shelf (VTS). </para> <para>If a specific <c>TapeARN</c> is not
        /// specified, AWS Storage Gateway returns a description of all virtual tapes found in the VTS associated with your account.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeTapeArchivesResponse DescribeTapeArchives();
 

        /// <summary>
        /// <para>Returns a list of virtual tape recovery points that are available for the specified gateway-VTL.</para> <para>A recovery point is a
        /// point in time view of a virtual tape at which all the data on the virtual tape is consistent. If your gateway crashes, virtual tapes that
        /// have recovery points can be recovered to a new gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeTapeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTapeRecoveryPointsResponse> DescribeTapeRecoveryPointsAsync(DescribeTapeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes. If a <c>TapeARN</c> is not specified, returns a
        /// description of all virtual tapes associated with the specified gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeTapesResponse DescribeTapes(DescribeTapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeTapes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTapesResponse> DescribeTapesAsync(DescribeTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns information about the upload buffer of a gateway. This operation is supported for both the gateway-stored and
        /// gateway-cached volume architectures. </para> <para> The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeUploadBuffer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a description of virtual tape library (VTL) devices for the specified gateway. In the response, AWS Storage Gateway returns
        /// VTL device information. </para> <para>The list of VTL devices must be from one gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVTLDevices operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeVTLDevices"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVTLDevicesResponse> DescribeVTLDevicesAsync(DescribeVTLDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation returns information about the working storage of a gateway. This operation is supported only for the gateway-stored
        /// volume architecture. This operation is deprecated in cached-volumes API version (20120630). Use DescribeUploadBuffer instead.</para>
        /// <para><b>NOTE:</b> Working storage is also referred to as upload buffer. You can also use the DescribeUploadBuffer operation to add upload
        /// buffer to a stored-volume gateway. </para> <para>The response includes disk IDs that are configured as working storage, and it includes the
        /// amount of working storage allocated and used.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DescribeWorkingStorage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Disables a gateway when the gateway is no longer functioning. For example, if your gateway VM is damaged, you can disable the gateway
        /// so you can recover virtual tapes. </para> <para>Use this operation for a gateway-VTL that is not reachable or not functioning.</para>
        /// <para><b>IMPORTANT:</b>Once a gateway is disabled it cannot be enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		DisableGatewayResponse DisableGateway(DisableGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.DisableGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableGatewayResponse> DisableGatewayAsync(DisableGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation lists gateways owned by an AWS account in a region specified in the request. The returned list is ordered by gateway
        /// Amazon Resource Name (ARN).</para> <para>By default, the operation returns a maximum of 100 gateways. This operation supports pagination
        /// that allows you to optionally reduce the number of gateways returned in a response.</para> <para>If you have more gateways than are returned
        /// in a response-that is, the response returns only a truncated list of your gateways-the response contains a marker that you can specify in
        /// your next request to fetch the next page of gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListGatewaysResponse ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation lists gateways owned by an AWS account in a region specified in the request. The returned list is ordered by gateway
        /// Amazon Resource Name (ARN).</para> <para>By default, the operation returns a maximum of 100 gateways. This operation supports pagination
        /// that allows you to optionally reduce the number of gateways returned in a response.</para> <para>If you have more gateways than are returned
        /// in a response-that is, the response returns only a truncated list of your gateways-the response contains a marker that you can specify in
        /// your next request to fetch the next page of gateways.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListGatewaysResponse ListGateways();
 

        /// <summary>
        /// <para>This operation returns a list of the local disks of a gateway. To specify which gateway to describe you use the Amazon Resource Name
        /// (ARN) of the gateway in the body of the request.</para> <para>The request returns all disks, specifying which are configured as working
        /// storage, stored volume or not configured at all.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListLocalDisks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation lists the recovery points for a specified gateway. This operation is supported only for the gateway-cached volume
        /// architecture.</para> <para>Each gateway-cached volume has one recovery point. A volume recovery point is a point in time at which all data
        /// of the volume is consistent and from which you can create a snapshot. To create a snapshot from a volume recovery point use the
        /// CreateSnapshotFromVolumeRecoveryPoint operation.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumeRecoveryPoints"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The response includes only the volume
        /// ARNs. If you want additional volume information, use the DescribeStorediSCSIVolumes API.</para> <para>The operation supports pagination. By
        /// default, the operation returns a maximum of up to 100 volumes. You can optionally specify the <c>Limit</c> field in the body to limit the
        /// number of volumes in the response. If the number of volumes returned in the response is truncated, the response includes a Marker field. You
        /// can use this Marker value in your subsequent request to retrieve the next set of volumes.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ListVolumesResponse ListVolumes(ListVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ListVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a gateway-VTL. Virtual tapes archived in the VTS are not
        /// associated with any gateway. However after a tape is retrieved, it is associated with a gateway, even though it is also listed in the
        /// VTS.</para> <para>Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to another gateway. You must archive the
        /// tape again before you can retrieve it to another gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeArchive operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.RetrieveTapeArchive"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RetrieveTapeArchiveResponse> RetrieveTapeArchiveAsync(RetrieveTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves the recovery point for the specified virtual tape.</para> <para>A recovery point is a point in time view of a virtual tape
        /// at which all the data on the tape is consistent. If your gateway crashes, virtual tapes that have recovery points can be recovered to a new
        /// gateway.</para> <para><b>NOTE:</b>The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only. The virtual tape
        /// can be retrieved to only a gateway-VTL. There is no charge for retrieving recovery points.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeRecoveryPoint operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.RetrieveTapeRecoveryPoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RetrieveTapeRecoveryPointResponse> RetrieveTapeRecoveryPointAsync(RetrieveTapeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource Name (ARN) of the gateway in the
        /// body of your request.</para> <para>The operation shuts down the gateway service component running in the storage gateway's virtual machine
        /// (VM) and not the VM.</para> <para><b>NOTE:</b>If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.</para> <para>After the gateway is shutdown, you cannot call any other API except
        /// StartGateway, DescribeGatewayInformation, and ListGateways. For more information, see ActivateGateway. Your applications cannot read from or
        /// write to the gateway's storage volumes, and there are no snapshots taken.</para> <para><b>NOTE:</b>When you make a shutdown request, you
        /// will get a 200 OK success response immediately. However, it might take some time for the gateway to shut down. You can call the
        /// DescribeGatewayInformation API to check the status. For more information, see ActivateGateway.</para> <para>If do not intend to use the
        /// gateway again, you must delete the gateway (using DeleteGateway) to no longer pay software charges associated with the gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.ShutdownGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation starts a gateway that you previously shut down (see ShutdownGateway). After the gateway starts, you can then make other
        /// API calls, your applications can read from or write to the gateway's storage volumes and you will be able to take snapshot backups.</para>
        /// <para><b>NOTE:</b>When you make a request, you will get a 200 OK success response immediately. However, it might take some time for the
        /// gateway to be ready. You should call DescribeGatewayInformation and check the status before making any additional API calls. For more
        /// information, see ActivateGateway.</para> <para>To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway in your
        /// request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		StartGatewayResponse StartGateway(StartGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.StartGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates the bandwidth rate limits of a gateway. You can update both the upload and download bandwidth rate limit or
        /// specify only one of the two. If you don't set a bandwidth rate limit, the existing rate limit remains.</para> <para>By default, a gateway's
        /// bandwidth rate limits are not set. If you don't set any limit, the gateway does not have any limitations on its bandwidth usage and could
        /// potentially use the maximum available bandwidth.</para> <para>To specify which gateway to update, use the Amazon Resource Name (ARN) of the
        /// gateway in your request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateBandwidthRateLimit"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified iSCSI target. By default, a
        /// gateway does not have CHAP enabled; however, for added security, you might use it.</para> <para><b>IMPORTANT:</b> When you update CHAP
        /// credentials, all existing connections on the target are closed and initiators must reconnect with the new credentials. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateChapCredentials"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates a gateway's metadata, which includes the gateway's name and time zone. To specify which gateway to update, use
        /// the Amazon Resource Name (ARN) of the gateway in your request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewayInformation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates the gateway virtual machine (VM) software. The request immediately triggers the software update. </para>
        /// <para><b>NOTE:</b>When you make this request, you get a 200 OK success response immediately. However, it might take some time for the update
        /// to complete. You can call DescribeGatewayInformation to verify the gateway is in the STATE_RUNNING state.</para> <para><b>IMPORTANT:</b>A
        /// software update forces a system restart of your gateway. You can minimize the chance of any disruption to your applications by increasing
        /// your iSCSI Initiators' timeouts. For more information about increasing iSCSI Initiator timeouts for Windows and Linux, see Customizing Your
        /// Windows iSCSI Settings and Customizing Your Linux iSCSI Settings, respectively.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method
        /// on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateGatewaySoftwareNow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates a gateway's weekly maintenance start time information, including day and time of the week. The maintenance time
        /// is the time in your gateway's time zone.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service
        /// method on AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateMaintenanceStartTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation updates a snapshot schedule configured for a gateway volume.</para> <para>The default snapshot schedule for volume is
        /// once every 24 hours, starting at the creation time of the volume. You can use this API to change the snapshot schedule configured for the
        /// volume.</para> <para>In the request you must identify the gateway volume whose snapshot schedule you want to update, and the schedule
        /// information, including when you want the snapshot to begin on a day and the frequency (in hours) of snapshots.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method on
        /// AmazonStorageGateway.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by AmazonStorageGateway.</returns>
        /// 
        /// <exception cref="T:Amazon.StorageGateway.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.StorageGateway.Model.InvalidGatewayRequestException" />
		UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// <seealso cref="Amazon.StorageGateway.IAmazonStorageGateway.UpdateSnapshotSchedule"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
