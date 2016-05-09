﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Microsoft.Azure.WebJobs
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class OutgoingHttpRequestAttribute : Attribute
    {
        public OutgoingHttpRequestAttribute(string uri)
        {
            Uri = new Uri(uri);
        }

        public Uri Uri { get; private set; }
    }
}