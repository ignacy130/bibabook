using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bibabook.Implementation.DatabaseContext;

namespace Bibabook.DAL
{
    public class DataBaseInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        //tutaj mają zawrzeć się wszytkie dodania do bazy jeżeli baza bnie jest zainicjalizowana
        //kilka pól które tworzą się podczas stawiania bazy na nowo

    }
}