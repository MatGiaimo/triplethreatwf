/*
 Copyright (c) 2010 TripleThreatWF

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleThreat.Framework.Core;

namespace TripleThreat.Framework.Helpers
{
    public class FolderHelper : HelperBase
    {
        public static volatile FolderHelper _instance;
        public static object _sync = new Object();

        internal FolderHelper(IDatabaseContext DatabaseConext) : base(DatabaseConext)
        {
        }

        public static FolderHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new FolderHelper(DatabaseContextFactory.Instance.GetDatabaseContext());
                            return _instance;
                        }
                    }
                }

                return _instance;
            }
        }
    
        public Folder CreateFolder(string Name)
        {
            Folder folder = new Folder();

            folder.Name = Name;

            return folder;
        }

        public Folder GetFolder(int Id)
        {
            IQueryable<Folder> folderQuery =
                from folder in this.Database.Folders
                where folder.Id == Id
                select folder;

            return folderQuery.FirstOrDefault();
        }

        public List<Folder> GetAllFolders()
        {
            IQueryable<Folder> folderQuery = 
                from folder in this.Database.Folders
                select folder;

            return folderQuery.ToList<Folder>();
        }

        public void SaveFolder(Folder folder)
        {
            ((DatabaseContext)this.Database).Folders.AddObject(folder);

            ((DatabaseContext)this.Database).SaveChanges();

            ((DatabaseContext)this.Database).Refresh(System.Data.Objects.RefreshMode.StoreWins, folder);
        }

    }
}
