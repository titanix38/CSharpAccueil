// <copyright file="PersonTest.cs">Copyright ©  2015</copyright>
using System;
using GestionAccueil.com.doubleedgedsword.entities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GestionAccueil.com.doubleedgedsword.entities.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Person</summary>
    [PexClass(typeof(Person))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PersonTest
    {
     
    }
}
