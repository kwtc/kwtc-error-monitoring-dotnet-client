﻿namespace Kwtc.ErrorMonitoring.Client;

using Payload;

public interface IClient
{
    Task NotifyAsync(System.Exception exception, Severity severity);
}
