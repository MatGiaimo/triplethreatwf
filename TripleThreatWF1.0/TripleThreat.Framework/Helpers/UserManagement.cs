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
    public class UserManagement
    {
        //public TripleThreat.Framework.DatabaseInteractions.IDatabase Database { get; set; }

        //public void CreateUserGroup(string groupName)
        //{
        //    UserGroup u = new UserGroup();
        //    u.GroupName = groupName;
        //    Database.AddUserGroup(u);
        //}
        public TripleThreat.Framework.Core.IDatabaseContext DatabaseContext
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static UserGroup CreateNewUserGroup(string Name)
        {
            UserGroup usrGroup = new UserGroup();

            usrGroup.GroupName = Name;

            usrGroup.Members = new List<User>();

            return usrGroup;
        }
    }
}
