﻿using UnitTestChallenge.Models;

namespace UnitTestChallenge.Helpers;

public static class OrganizationUserHelper
{
    public static UserList GetUsers(UserList users, int organizationID)
    {
        if (users == null)
            throw new Exception("Unable to find users.");

        var organizationUsers = users.Users.Where(x => x.Organization.OrganizationID == organizationID).ToList();
        return new()
        {
            Users = organizationUsers
        };
    }
}
