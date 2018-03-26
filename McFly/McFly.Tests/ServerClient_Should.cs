﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using McFly.Core;
using McFly.Server.Contract;
using Moq;
using Xunit;

namespace McFly.Tests
{
    public class ServerClient_Should
    {
        [Fact]
        public void Add_Notes()
        {
            // arrange
            var httpBuilder = new HttpFacadeBuilder();
            httpBuilder.WithPostAsync(new HttpResponseMessage(HttpStatusCode.OK));
            var settings = new Settings
            {
                ServerUrl = "https://some.server.net",
                ProjectName = "testing"
            };
            var serverClient = new ServerClient {HttpFacade = httpBuilder.Build(), Settings = settings};
            var expected = new Dictionary<string, string>
            {
                ["projectName"] = "testing",
                ["position"] = "ABC:123",
                ["threadId"] = "1",
                ["text"] = "hello world"
            };

            // act
            serverClient.AddNote(new Position(0xabc, 0x123), 1, "hello world");

            // assert
            httpBuilder.Mock.Verify(
                facade => facade.PostAsync(new Uri("https://some.server.net/api/note/testing"),
                    It.Is<Dictionary<string, string>>(e => e.Count == expected.Count && !e.Except(expected).Any()), null),
                Times.Once);
        }

        [Fact]
        public void Initialize_Projects()
        {
            // arrange
            var httpBuilder = new HttpFacadeBuilder();
            httpBuilder.WithPostAsync(new HttpResponseMessage(HttpStatusCode.OK));
            var settings = new Settings
            {
                ServerUrl = "https://some.server.net",
                ProjectName = "testing"
            };
            var serverClient = new ServerClient {HttpFacade = httpBuilder.Build(), Settings = settings};
            var expected = new NewProjectRequest("testing", "35:0", "1000:0");

            // act
            serverClient.InitializeProject("testing", new Position(0x35, 0), new Position(0x1000, 0));

            // assert
            httpBuilder.Mock.Verify(f => f.PostJsonAsync(new Uri("https://some.server.net/api/project"), expected, null), Times.Once);
        }

        [Fact]
        public void Upsert_Frames()
        {
            // arrange
            var httpBuilder = new HttpFacadeBuilder();
            httpBuilder.WithPostJsonAsync(new HttpResponseMessage(HttpStatusCode.OK));
            var settings = new Settings
            {
                ServerUrl = "https://some.server.net",
                ProjectName = "testing"
            };
            var serverClient = new ServerClient {HttpFacade = httpBuilder.Build(), Settings = settings};
            var frames = MockFrames.SingleThreaded0;
            var headers = new HttpHeaders()
            {   
                ["X-Project-Name"] = "testing"
            };

            // act
            serverClient.UpsertFrames(frames);

            // assert
            httpBuilder.Mock.Verify(facade => facade.PostJsonAsync(new Uri("https://some.server.net/api/frame"),
                It.Is<IEnumerable<Frame>>(e => e.SequenceEqual(frames)), headers), Times.Once);
        }
    }
}