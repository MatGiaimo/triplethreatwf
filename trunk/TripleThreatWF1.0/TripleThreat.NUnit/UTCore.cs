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

using NUnit.Framework;

using TripleThreat.Framework;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;

namespace TripleThreat.NUnit
{
    [TestFixture()]
    public class UTCore
    {
        [SetUp()]
        public void Init()
        {
        }

        [TearDown()]
        public void Clean()
        {
        }


        #region test cases
        
        [Test]
        public void CreateNewDocument()
        {

            Document newDoc = DocumentHelper.Instance.CreateDocument("Test","TestUser");
        }

        [Test]
        public void CreateNewFolder()
        {
            Folder newFolder = FolderHelper.Instance.CreateFolder("Test");
        }

        [Test]
        public void CreateNewWorkFlowStep()
        {
        }

        [Test]
        public void CreateNewWorkFlow()
        {
        }

        [Test]
        public void CreateNewCustomer()
        {
        }

        [Test]
        public void CreateNewCustomerGroup()
        {
        }

        [Test]
        public void CreateNewUser()
        {
        }

        [Test]
        public void CreateNewUserGroup()
        {
        }

        [Test]
        public void AddUserToGroup()
        {
        }

        [Test]
        public void RemoveUserFromGroup()
        {
        }

        [Test]
        public void AddDocumentToFolder()
        {
        }

        [Test]
        public void ModifyDocument()
        {
        }

        [Test]
        public void RemoveDocumentFromFolder()
        {
        }

        [Test]
        public void ArchiveDocument()
        {
        }

        [Test]
        public void CreateReport()
        {
        }

        #endregion test cases
    }
}
