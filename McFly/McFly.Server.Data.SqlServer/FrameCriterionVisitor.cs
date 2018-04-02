﻿// ***********************************************************************
// Assembly         : McFly.Server.Data.SqlServer
// Author           : @tysmithnet
// Created          : 03-31-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-01-2018
// ***********************************************************************
// <copyright file="SqlServerCriterionVisitor.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using McFly.Core;
using Filter = System.Func<McFly.Server.Data.SqlServer.FrameEntity, bool>;

namespace McFly.Server.Data.SqlServer
{
    /// <summary>
    ///     Class SqlServerCriterionVisitor.
    /// </summary>
    /// <seealso cref="McFly.Server.ICriterionVisitor" />
    internal class FrameCriterionVisitor : ICriterionVisitor
    {
        /// <summary>
        ///     Visits the specified criterion.
        /// </summary>
        /// <param name="criterion">The criterion.</param>
        /// <returns>System.Object.</returns>
        public object Visit(ICriterion criterion)
        {
            Func<FrameEntity, bool> identity = entity => true;
            return identity;
        }

        /// <summary>
        ///     Visits the specified and criterion.
        /// </summary>
        /// <param name="andCriterion">The and criterion.</param>
        public Filter Visit(AndCriterion andCriterion)
        {
            var list = new List<Filter>();
            foreach (var c in andCriterion.Criteria)
            {
                var f = (Filter)c.Accept(this);
                list.Add(f);
            }
            return entity => list.All(x => x(entity));
        }

        public Filter Visit(OrCriterion orCriteria)
        {
            var list = new List<Filter>();
            foreach (var c in orCriteria.Criteria)
            {
                var f = (Filter)c.Accept(this);
                list.Add(f);
            }
            return entity => list.Any(x => x(entity));
        }

        public Filter Visit(RegisterEqualsCriterion registerEqualsCriterion)
        {
            return entity =>
            {
                if (registerEqualsCriterion.Register == Register.Rax)
                    return entity.Rax == registerEqualsCriterion.Value.ToLong();

                if (registerEqualsCriterion.Register == Register.Rbx)
                    return entity.Rbx == registerEqualsCriterion.Value.ToLong();

                if (registerEqualsCriterion.Register == Register.Rcx)
                    return entity.Rcx == registerEqualsCriterion.Value.ToLong();

                if (registerEqualsCriterion.Register == Register.Rdx)
                    return entity.Rdx == registerEqualsCriterion.Value.ToLong();

                return false;
            };
        }
    }
}