// <copyright file="MainFormTest.cs" company="Microsoft">Copyright © Microsoft 2015</copyright>
using System;
using CalcDatabaseSize;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcDatabaseSize.Tests
{
    /// <summary>This class contains parameterized unit tests for MainForm</summary>
    [PexClass(typeof(MainForm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MainFormTest
    {
    }
}
