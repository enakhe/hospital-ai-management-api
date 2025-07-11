﻿using HospitalManagement.Application.Common.Interfaces;
using Moq;
using NUnit.Framework;

namespace HospitalManagement.Application.UnitTests.Common.Behaviours;
public class RequestLoggerTests
{
    private Mock<IUser> _user = null!;
    private Mock<IIdentityService> _identityService = null!;

    [SetUp]
    public void Setup()
    {
        _user = new Mock<IUser>();
        _identityService = new Mock<IIdentityService>();
    }

}
