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
    public class LenderHelper : HelperBase
    {
        public static volatile LenderHelper _instance;
        public static object _sync = new Object();

        internal LenderHelper(IDatabaseContext DatabaseConext) : base(DatabaseConext)
        {
        }

        public static LenderHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new LenderHelper(DatabaseContextFactory.Instance.GetDatabaseContext());
                            return _instance;
                        }
                    }
                }

                return _instance;
            }
        }

        public Lender CreateLender(string Name)
        {
            Lender lender = new Lender();

            lender.Name = Name;

            return lender;
        }

        public List<Lender> GetAllLenders()
        {
            IQueryable<Lender> lenderQuery =
                from lender in this.Database.Lenders
                select lender;

            return lenderQuery.ToList();
        }

        public Lender GetLender(int Id)
        {
            IQueryable<Lender> lenderQuery =
                from lender in this.Database.Lenders
                where lender.Id == Id
                select lender;

            return lenderQuery.FirstOrDefault();
        }

        public Lender SaveLender(Lender Lender)
        {
            ((DatabaseContext)this.Database).Lenders.AddObject(Lender);

            ((DatabaseContext)this.Database).SaveChanges();

            ((DatabaseContext)this.Database).Refresh(System.Data.Objects.RefreshMode.StoreWins, Lender);

            return Lender;
        }
    }
}
