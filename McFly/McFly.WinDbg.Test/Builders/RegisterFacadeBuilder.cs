﻿// ***********************************************************************
// Assembly         : McFly.Tests
// Author           : @tysmithnet
// Created          : 03-18-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-19-2018
// ***********************************************************************
// <copyright file="RegisterFacadeBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using McFly.Core;
using McFly.Core.Registers;
using Moq;

namespace McFly.WinDbg.Test.Builders
{
    /// <summary>
    ///     Class RegisterFacadeBuilder.
    /// </summary>
    internal class RegisterFacadeBuilder
    {
        /// <summary>
        ///     The mock
        /// </summary>
        public Mock<IRegisterFacade> Mock = new Mock<IRegisterFacade>();

        /// <summary>
        ///     Builds this instance.
        /// </summary>
        /// <returns>IRegisterFacade.</returns>
        public IRegisterFacade Build()
        {
            return Mock.Object;
        }

        /// <summary>
        ///     Withes the get current register set.
        /// </summary>
        /// <param name="threadId">The thread identifier.</param>
        /// <param name="registers">The registers.</param>
        /// <param name="result">The result.</param>
        /// <returns>RegisterFacadeBuilder.</returns>
        public RegisterFacadeBuilder WithGetCurrentRegisterSet(int threadId, IEnumerable<Register> registers,
            RegisterSet result)
        {
            Mock.Setup(facade => facade.GetCurrentRegisterSet(threadId, registers)).Returns(result);
            return this;
        }

        /// <summary>
        ///     Withes the get current register set.
        /// </summary>
        /// <param name="registers">The registers.</param>
        /// <param name="result">The result.</param>
        /// <returns>RegisterFacadeBuilder.</returns>
        public RegisterFacadeBuilder WithGetCurrentRegisterSet(IEnumerable<Register> registers,
            RegisterSet result)
        {
            Mock.Setup(facade => facade.GetCurrentRegisterSet(registers)).Returns(result);
            Mock.Setup(facade => facade.GetCurrentRegisterSet(It.IsAny<int>(), registers)).Returns(result);
            return this;
        }

        /// <summary>
        ///     Withes the get current register set.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>RegisterFacadeBuilder.</returns>
        public RegisterFacadeBuilder WithGetCurrentRegisterSet(RegisterSet result)
        {
            Mock.Setup(facade => facade.GetCurrentRegisterSet(It.IsAny<IEnumerable<Register>>())).Returns(result);
            Mock.Setup(facade => facade.GetCurrentRegisterSet(It.IsAny<int>(), It.IsAny<IEnumerable<Register>>()))
                .Returns(result);
            return this;
        }
    }
}