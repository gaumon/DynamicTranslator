﻿namespace DynamicTranslator.Core.Domain.Uow
{
    #region using

    using System;

    #endregion

    /// <summary>
    ///     Used as event arguments on <see cref="IActiveUnitOfWork.Failed" /> event.
    /// </summary>
    public class UnitOfWorkFailedEventArgs : EventArgs
    {
        /// <summary>
        ///     Creates a new <see cref="UnitOfWorkFailedEventArgs" /> object.
        /// </summary>
        /// <param name="exception">Exception that caused failure</param>
        public UnitOfWorkFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        ///     Exception that caused failure.
        /// </summary>
        public Exception Exception { get; private set; }
    }
}