﻿namespace Prometheus.Client.MetricServer
{
    /// <summary>
    ///     MetricSever
    /// </summary>
    public interface IMetricServer
    {
        /// <summary>
        ///     Start server
        /// </summary>
        void Start();

        /// <summary>
        ///     Stop server
        /// </summary>
        void Stop();
    }
}