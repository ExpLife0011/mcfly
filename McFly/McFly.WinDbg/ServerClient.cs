﻿// ***********************************************************************
// Assembly         : mcfly
// Author           : @tysmithnet
// Created          : 03-02-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-22-2018
// ***********************************************************************
// <copyright file="ServerClient.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using McFly.Core;
using McFly.Server.Contract;
using Newtonsoft.Json;

namespace McFly.WinDbg
{
    /// <summary>
    ///     Class ServerClient.
    /// </summary>
    /// <seealso cref="IServerClient" />
    /// <seealso cref="System.IDisposable" />
    [Export(typeof(IServerClient))]
    public class ServerClient : IServerClient // todo: move to McFly.Server
    {
        /// <inheritdoc />
        public void AddMemoryRange(MemoryChunk memoryChunk)
        {
            var ub = new UriBuilder(Settings.ServerUrl) {Path = $"api/memory"};
            var addMemoryRequest = new AddMemoryRequest(memoryChunk);
            var headers = new HttpHeaders
            {
                ["X-Project-Name"] = Settings.ProjectName
            };
            HttpFacade.PostJsonAsync(ub.Uri, addMemoryRequest, headers).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Adds the tag.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="threadIds">The thread ids.</param>
        /// <param name="text">The text.</param>
        public void AddTag(Position position, IEnumerable<int> threadIds, string text)
        {
            var ub = new UriBuilder(Settings.ServerUrl) {Path = $"api/tag"};
            var addNoteRequest = new AddTagRequest(position, threadIds, text);
            var headers = new HttpHeaders
            {
                ["X-Project-Name"] = Settings.ProjectName
            };
            HttpFacade.PostJsonAsync(ub.Uri, addNoteRequest, headers).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Initializes the project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        public void InitializeProject(string projectName, Position start, Position end)
        {
            var ub = new UriBuilder(Settings.ServerUrl) {Path = $"api/project"};
            var request = new NewProjectRequest(projectName, start.ToString(), end.ToString());
            HttpFacade.PostJsonAsync(ub.Uri, request, null).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Searches the frames.
        /// </summary>
        /// <param name="converted">The converted.</param>
        /// <returns>IEnumerable&lt;Frame&gt;.</returns>
        public IEnumerable<Frame> SearchFrames(SearchCriterionDto converted)
        {
            var ub = new UriBuilder(Settings.ServerUrl) {Path = $"api/search/frame"};
            var res = HttpFacade.PostJsonAsync(ub.Uri, converted, new HttpHeaders
            {
                ["X-Project-Name"] = Settings.ProjectName
            });
            var json = res.Result.Content.ReadAsStringAsync().Result; // todo: 500's
            var returnVal = JsonConvert.DeserializeObject<IEnumerable<Frame>>(json);
            return returnVal;
        }

        /// <summary>
        ///     Upserts the frames.
        /// </summary>
        /// <param name="frames">The frames.</param>
        /// <returns>Task.</returns>
        public void UpsertFrames(IEnumerable<Frame> frames)
        {
            var ub = new UriBuilder(Settings.ServerUrl) {Path = $"api/frame"};
            var headers = new HttpHeaders
            {
                ["X-Project-Name"] = Settings.ProjectName
            };
            HttpFacade.PostJsonAsync(ub.Uri, frames, headers).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Gets or sets the HTTP facade.
        /// </summary>
        /// <value>The HTTP facade.</value>
        [Import]
        protected internal IHttpFacade HttpFacade { get; set; }

        /// <summary>
        ///     Gets or sets the settings.
        /// </summary>
        /// <value>The settings.</value>
        [Import]
        protected internal Settings Settings { get; set; }
    }
}