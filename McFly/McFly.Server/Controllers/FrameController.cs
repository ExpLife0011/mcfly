﻿// ***********************************************************************
// Assembly         : McFly.Server
// Author           : @tysmithnet
// Created          : 03-03-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-26-2018
// ***********************************************************************
// <copyright file="FrameController.cs" company="McFly.Server">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using System.Web.Http;
using Common.Logging;
using McFly.Core;
using McFly.Server.Data;
using McFly.Server.Headers;

namespace McFly.Server.Controllers
{
    /// <summary>
    ///     Represents the business logic behind the frame api
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    /// <seealso cref="System.Web.Mvc.Controller" />
    [Route("api/frame/")]
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public sealed class FrameController : ApiController
    {
        /// <summary>
        ///     Gets or sets the logger.
        /// </summary>
        /// <value>The logger.</value>
        private static readonly ILog Log = LogManager.GetLogger<FrameController>();

        /// <summary>
        ///     Adds frames to a project's collection
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="frames">The frames.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post([FromProjectNameHeader] string projectName, [FromBody] IEnumerable<Frame> frames)
        {
            try
            {
                FrameAccess.UpsertFrames(projectName, frames);
            }
            catch (Exception e)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Problem upserting frames. Does the {projectName} database exist?");
                sb.AppendLine($"{e.GetType().FullName} - {e.Message}");
                sb.AppendLine($"{e.StackTrace}");
                Log.Error(sb.ToString());
                return InternalServerError(e);
            }

            return Ok();
        }

        /// <summary>
        ///     Gets or sets the frame access.
        /// </summary>
        /// <value>The frame access.</value>
        [Import]
        internal IFrameAccess FrameAccess { get; set; }
    }
}