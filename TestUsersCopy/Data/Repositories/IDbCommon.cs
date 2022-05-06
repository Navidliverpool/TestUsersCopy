using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUsersCopy.Data.Repositories
{
    //This interface was suppose to be used for refactoring the project in order to implement DI. But I undo it and it's dependencies for now.
    public interface IDbCommon<T>
    {
        void EntryState(T t);
    }
}