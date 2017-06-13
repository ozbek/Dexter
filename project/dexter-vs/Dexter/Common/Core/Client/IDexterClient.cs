﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dexter.Common.Defect;

namespace Dexter.Common.Client
{
    /// <summary>
    /// Communicates with the dexter server
    /// </summary>
    public interface IDexterClient
    {
        /// <summary>
        /// Returns whether stand-alone mode is checked
        /// </summary>
        bool IsStandAloneMode();
        string SourceCode(string modulePath, string fileName);
        Task SendAnalysisResult(string result);
        /// <summary>
        /// Sends dexter defects to the dexter server
        /// </summary>
        /// <param name="result">Container of dexter defects</param>
        Task SendAnalysisResult(DexterResult result);
        Task StoreSourceCodeCharSequence(long snapshotId, long groupId, string modulePath, string fileName, string sourcecode);

        /// <summary>
        /// Adds new user account
        /// </summary>
        /// <param name="userName">User name to ocreate</param>
        /// <param name="userPassword">User password to ocreate</param>
        /// <param name="isAdmin">True, if new user should have administrator rights</param>
        /// <returns></returns>
        Task AddAccount(string userName, string userPassword, bool isAdmin);
    }
}
