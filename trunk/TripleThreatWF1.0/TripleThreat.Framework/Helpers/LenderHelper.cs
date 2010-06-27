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
    }
}
