﻿/*
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

namespace TripleThreat.Framework
{
    public enum DocumentState
    {
        //todo: identify states
        Incomplete,
        Complete
    }

    public interface IDocument
    {
        string GetPath();

        void UpdateDocument(string documentPath);

        void ArchiveDocument();

        //Date Added 
        DateTime DateAdded { get; set; }

        //Added By 
        User AddedBy { get; set; }

        //Document Name 
        string DocumentName { get; set; }

        //Customer Name
        CustomerGroup CustomerAccount { get; set; }

        //State 
        DocumentState State { get; set; }

        //View Groups 
        List<UserGroup> ReadAccessGroups { get; set; }

        //Admin Groups
        List<UserGroup> FullAccessGroups { get; set; }

        Lender Lender
        {
            get;
            set;
        }
    }
}
