using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTestApp
{
    class Program
    {
        private PhoneBook phonebook = new PhoneBook();
        static void Main(string[] args)
        {
            try
            {
                DatabaseUtil.initializeDatabase();
                /* TODO: create person objects and put them in the PhoneBook and the Database
                * Sam Rothwell, (999) 123-4567, 1242 Morcosse Dr, Jamestown, MN
                * Clara Tzetkin, (812) 555-1255, 853 Broadway, Hollow, WI
                */

                // TODO: print the phonebook out to System.out
                // TODO: find Clara Tzetkin and print out just this entry
                // TODO: insert the new person objects into the database
            }
            finally
            {
                DatabaseUtil.CleanUp();
            }
        }
    }
}
