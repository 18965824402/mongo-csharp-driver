﻿/* Copyright 2013-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Core.Connections;
using MongoDB.Driver.Core.WireProtocol.Messages;

namespace MongoDB.Driver.Core.Events
{
    /// <preliminary/>
    /// <summary>
    /// Represents information about a ConnectionAfterReceivingMessage event.
    /// </summary>
    public struct ConnectionAfterReceivingMessageEvent
    {
        private readonly ConnectionId _connectionId;
        private readonly TimeSpan _elapsed;
        private readonly int _length;
        private readonly ResponseMessage _receivedMessage;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionAfterReceivingMessageEvent"/> struct.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="receivedMessage">The received message.</param>
        /// <param name="length">The length.</param>
        /// <param name="elapsed">The elapsed time.</param>
        public ConnectionAfterReceivingMessageEvent(ConnectionId connectionId, ResponseMessage receivedMessage, int length, TimeSpan elapsed)
        {
            _connectionId = connectionId;
            _receivedMessage = receivedMessage;
            _length = length;
            _elapsed = elapsed;
        }

        /// <summary>
        /// Gets the connection identifier.
        /// </summary>
        /// <value>
        /// The connection identifier.
        /// </value>
        public ConnectionId ConnectionId
        {
            get { return _connectionId; }
        }

        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <value>
        /// The elapsed time.
        /// </value>
        public TimeSpan Elapsed
        {
            get { return _elapsed; }
        }

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length
        {
            get { return _length; }
        }

        /// <summary>
        /// Gets the received message.
        /// </summary>
        /// <value>
        /// The received message.
        /// </value>
        public ResponseMessage ReceivedMessage
        {
            get { return _receivedMessage; }
        }
    }
}
