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
        public FolderHelper(IDatabaseContext DatabaseConext) : base(DatabaseConext)
        {
        }
    
        static public IFolder CreateNewFolder(/*todo add creation criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<Folder> GetFolders(/*todo: search criterion*/)
        {
            //IQueryable<CustomerGroup> cGroupQuery =
            //    from customergroup in this.Database.CustomerGroups
            //    where customergroup.Id == Id
            //    select customergroup;

            IQueryable<Folder> folderQuery = 
                from folder in this.Database.Folders
                select folder;

            return folderQuery.ToList<Folder>();
        }

    }
}
