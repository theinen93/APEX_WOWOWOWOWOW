﻿using System;
using System.Web.Mvc;
using System.Web.Security;

namespace AdageSmartContent.Epi.Web
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)

            CreateDefaultRolesAndUser();
        }

        private void CreateDefaultRolesAndUser()
        {
            var adminRole = "WebAdmins";
            var editRole = "WebEditors";

            var username = "localadmin";
            var password = "Password1";
            var email = "admin@localhost.com";

            if (!Roles.RoleExists(adminRole))
            {
                Roles.CreateRole(adminRole);
            }

            if (!Roles.RoleExists(editRole))
            {
                Roles.CreateRole(editRole);
            }

            if (Membership.GetUser(username) == null)
            {
                var user = Membership.CreateUser(username, password, email);
                user.IsApproved = true;
            }

            Roles.AddUserToRole(username, adminRole);
        }
    }
}