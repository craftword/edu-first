﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    interface ISessionRepository
    {
        Session AddSession(Session session);
        Session UpdateSession(Session sessionChanges);
        Session DeleteSession(int id);
        Session fetchSession(int id);
        IEnumerable<Session> fetchAllSession();
    }
}
