namespace EmailService.Core.Contracts
{
    /// <summary>
    /// Any method result must inherit form this class
    /// </summary>
    public class Result
    {
        /// <summary>
        /// If result is success it return number great than zero
        /// If result is fail it return number less than zero
        /// </summary>
        public int ResultCode { get; set; }

        /// <summary>
        /// Error or success massage,this may conatin valid message to read bu user like
        /// 'No internet connection'
        /// or return a code such
        /// 'NO_Connection'
        /// </summary>
        public string Message { get; set; }

        public bool IsSuccess => ResultCode > 0;

        /// <summary>
        /// Default results
        /// </summary>
        public enum ResultCodes 
        {
            Success=1,
            Failed=-1,
        }
    }
}