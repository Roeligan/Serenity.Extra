﻿
namespace MVC
{
    public static class Views
    {
        public static class _Ext
        {
            public static class DevTools
            {
                public static class CompareEntityToDB
                {
                    public const string CompareEntityToDBIndex = "~/Modules/_Ext/DevTools/CompareEntityToDB/CompareEntityToDBIndex.cshtml";
                }

                public static class EnumExproler
                {
                    public const string EnumExprolerIndex = "~/Modules/_Ext/DevTools/EnumExproler/EnumExprolerIndex.cshtml";
                }

                public static class GenerateMigrationFromEntity
                {
                    public const string GenerateMigrationFromEntityIndex = "~/Modules/_Ext/DevTools/GenerateMigrationFromEntity/GenerateMigrationFromEntityIndex.cshtml";
                    public const string GenerateMigrationFromEntityMigrationViewer = "~/Modules/_Ext/DevTools/GenerateMigrationFromEntity/GenerateMigrationFromEntityMigrationViewer.cshtml";
                    public const string GenerateMigrationFromEntitySuccessMsg = "~/Modules/_Ext/DevTools/GenerateMigrationFromEntity/GenerateMigrationFromEntitySuccessMsg.cshtml";
                }
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public static class ChangePassword
                {
                    public const string ChangePasswordPage = "~/Modules/Membership/Account/ChangePassword/ChangePasswordPage.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string ForgotPasswordPage = "~/Modules/Membership/Account/ForgotPassword/ForgotPasswordPage.cshtml";
                }

                public static class Login
                {
                    public const string LoginPage = "~/Modules/Membership/Account/Login/LoginPage.cshtml";
                }

                public static class ResetPassword
                {
                    public const string ResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/ResetPasswordEmail.cshtml";
                    public const string ResetPasswordPage = "~/Modules/Membership/Account/ResetPassword/ResetPasswordPage.cshtml";
                }

                public static class SignUp
                {
                    public const string ActivateEmail = "~/Modules/Membership/Account/SignUp/ActivateEmail.cshtml";
                    public const string SignUpPage = "~/Modules/Membership/Account/SignUp/SignUpPage.cshtml";
                }
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
            public const string GridPage = "~/Views/Shared/GridPage.cshtml";
        }

    }
}
