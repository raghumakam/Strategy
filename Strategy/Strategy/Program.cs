using System;
using System.Collections.Generic;
using static Strategy.Program;

namespace Strategy
{
    public enum ePassengerTitle
    {
        Mr,
        Mrs,
        Doctor,
    }

    class Program
    {
        static void Main(string[] args)
        {

            Context.DoAlgorithm( ePassengerTitle.Doctor);
        }
    }

    public interface IPassengerTitleStrategy
    {
        void DoAlgorithm();
    }

    #region "Concrete Classes"

    public class MrPassengerTitleStrategy : IPassengerTitleStrategy
    {
        public void DoAlgorithm()
        {
            throw new NotImplementedException();
        }
    }

    public class MrsPassengerTitleStrategy : IPassengerTitleStrategy
    {
        public void DoAlgorithm()
        {
            throw new NotImplementedException();
        }
    }

    public class DoctorPassengerTitleStrategy : IPassengerTitleStrategy
    {
        public void DoAlgorithm()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    public class Context
    {
        #region members
        private static Dictionary<ePassengerTitle, IPassengerTitleStrategy> _strategies = 
            new Dictionary<ePassengerTitle, IPassengerTitleStrategy>();
        #endregion

         static Context()
        {
            _strategies.Add(ePassengerTitle.Mr, new MrPassengerTitleStrategy());
            _strategies.Add(ePassengerTitle.Mrs, new MrsPassengerTitleStrategy());
            _strategies.Add(ePassengerTitle.Doctor, new DoctorPassengerTitleStrategy());
        }
        public static void DoAlgorithm(ePassengerTitle title)
        {
            _strategies[title].DoAlgorithm();
        }

    }
}
