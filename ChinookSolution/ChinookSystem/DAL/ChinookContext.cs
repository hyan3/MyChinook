﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional NameSpaces
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //This is an interanl class for security reasons
    //Acess is restricted to within this class library project
    //Inherits DbContext for Entity Framework, which requires
    //     System.Data.Entity
    internal class ChinookContext:DbContext
    {
        //Pass the connection string name to the
        //DbContext using :base()
        // i.e. connection string name is "ChinookDB"
        public ChinookContext() :base("ChinookDB")
        {

        }
    }
}
