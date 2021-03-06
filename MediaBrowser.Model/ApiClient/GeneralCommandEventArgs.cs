﻿using MediaBrowser.Model.Session;
using System;

namespace MediaBrowser.Model.ApiClient
{
    /// <summary>
    /// Class SystemCommandEventArgs
    /// </summary>
    public class GeneralCommandEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>The command.</value>
        public GeneralCommand Command { get; set; }

        /// <summary>
        /// Gets or sets the type of the known command.
        /// </summary>
        /// <value>The type of the known command.</value>
        public GeneralCommandType? KnownCommandType { get; set; }
    }
}
