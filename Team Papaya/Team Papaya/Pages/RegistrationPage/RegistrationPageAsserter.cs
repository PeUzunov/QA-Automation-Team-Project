﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Papaya.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertMissingEmailMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForMissingEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForMissingEmail.Text);
        }

        public static void AssertInvalidEmailMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForInvalidEmail.Text);
        }

        public static void AssertMissingFullNameMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForMissingFullName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForMissingFullName.Text);
        }

        public static void AssertTooLongFullNameMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForTooLongFullName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForTooLongFullName.Text);
        }

        public static void AssertMissingPasswordMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForMissingPassword.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForMissingPassword.Text);
        }

        public static void AssertUnmatchedPasswordMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForUnmatchedPasswords.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForUnmatchedPasswords.Text);
        }
    }
}