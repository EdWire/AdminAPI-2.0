using System;

namespace EdFi.Ods.AdminApi.V2.Client.Client
{
    /// <summary>
    /// Useful for tracking server health
    /// </summary>
    public class ApiResponseEventArgs : EventArgs
    {
        /// <summary>
        /// The ApiResponse
        /// </summary>
        public ApiResponse ApiResponse { get; }

        /// <summary>
        /// The ApiResponseEventArgs
        /// </summary>
        /// <param name="apiResponse"></param>
        public ApiResponseEventArgs(ApiResponse apiResponse)
        {
            ApiResponse = apiResponse;
        }
    }
}
