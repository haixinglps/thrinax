﻿using System;

namespace Thrinax
{
    public class Logger
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Logger));

        /// <summary>
        /// Debug the specified message and e.
        /// </summary>
        /// <returns>The debug.</returns>
        /// <param name="message">Message.</param>
        /// <param name="e">E.</param>
        public static void Debug(string message, Exception e = null)
        {
            logger.Debug(message, e);
        }

        /// <summary>
        /// Info the specified message and e.
        /// </summary>
        /// <returns>The info.</returns>
        /// <param name="message">Message.</param>
        /// <param name="e">E.</param>
        public static void Info(string message, Exception e = null)
        {
            logger.Info(message, e);
        }

        /// <summary>
        /// Warn the specified message and e.
        /// </summary>
        /// <returns>The warn.</returns>
        /// <param name="message">Message.</param>
        /// <param name="e">E.</param>
        public static void Warn(string message, Exception e = null)
        {
            logger.Warn(message, e);
        }

        /// <summary>
        /// Error the specified message and e.
        /// </summary>
        /// <returns>The error.</returns>
        /// <param name="message">Message.</param>
        /// <param name="e">E.</param>
        public static void Error(string message, Exception e = null)
        {
            logger.Error(message, e);
        }
    }
}
