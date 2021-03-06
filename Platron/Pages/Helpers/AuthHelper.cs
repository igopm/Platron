﻿using System;
using NUnit.Framework;

namespace Platron.Pages.Helpers
{
    public class AuthHelper : BaseHelper
    {
        #region Actions
        public AuthHelper ActionSetLogIn(string login)
        {
            this.ActionFillField(UIAuthPage.FieldLogIn, login);
            return this;
        }

        public AuthHelper ActionSetPassword(string password)
        {
            this.ActionFillField(UIAuthPage.FieldPassword, password);
            return this;
        }

        public AuthHelper ActionClickButtonSubmit()
        {
            UIAuthPage.ButtonSubmit.Click();
            return this;
        }
        #endregion
        #region Checks
        public AuthHelper CheckAlertMessage(string expected)
        {
            Assert.AreEqual(expected, WhenIsClickable(UIAuthPage.AlertMessage).Text.ToString());
            return this;
        }
        #endregion

    }
}
