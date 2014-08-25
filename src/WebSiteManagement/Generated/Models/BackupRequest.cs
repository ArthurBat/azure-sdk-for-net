// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// A specific backup.
    /// </summary>
    public partial class BackupRequest
    {
        private BackupSchedule _backupSchedule;
        
        /// <summary>
        /// Optional. The backup schedule structure - valid only when setting
        /// up a schedule. Should be Null for on-demand backups.
        /// </summary>
        public BackupSchedule BackupSchedule
        {
            get { return this._backupSchedule; }
            set { this._backupSchedule = value; }
        }
        
        private IList<DatabaseBackupSetting> _databases;
        
        /// <summary>
        /// Optional. Database settings for backup.
        /// </summary>
        public IList<DatabaseBackupSetting> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }
        
        private bool? _enabled;
        
        /// <summary>
        /// Optional. Valid only for a backup schedule (can be Null for
        /// on-demand backups). True if enabled; false if disabled (no backups
        /// will be performed).
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of this backup - will be used for generating a
        /// blob name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _storageAccountUrl;
        
        /// <summary>
        /// Optional. SAS URL for a container in a storage account. E.g.
        /// https://NAME.blob.core.windows.net/CONTAINERNAME/?sv=2012-02-12&st=2013-12-05T19%3A30%3A45Z&se=2017-12-04T19%3A30%3A45Z&sr=c&sp=rwdl&sig=abcdefABCDEFabcdef0123456789
        /// </summary>
        public string StorageAccountUrl
        {
            get { return this._storageAccountUrl; }
            set { this._storageAccountUrl = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupRequest class.
        /// </summary>
        public BackupRequest()
        {
            this.Databases = new List<DatabaseBackupSetting>();
        }
    }
}
