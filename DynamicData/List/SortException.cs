using System;

namespace DynamicData
{
    /// <summary>
    /// Thrown when an index is expected but not specified
    /// </summary>
    public class UnspecifiedIndexException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnspecifiedIndexException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UnspecifiedIndexException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnspecifiedIndexException"/> class.
        /// </summary>
        public UnspecifiedIndexException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnspecifiedIndexException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public UnspecifiedIndexException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Thrown when an exception occurs within the sort operators
    /// </summary>
    public class SortException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortException"/> class.
        /// </summary>
        public SortException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SortException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public SortException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
