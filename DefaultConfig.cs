using System;
using System.Collections.Generic;
using System.Text;

namespace University_SUBD
{
    class DefaultConfig
    {
        public Database db;
        public User user;
        public DefaultConfig()
        {
            db = new Database();
            db.Server = "localhost";
            db.Port = 5435;
            db.database = "admissionCommittee2";
            user = new User("postgres", "postgres", "postgres");

        }
    }
}
