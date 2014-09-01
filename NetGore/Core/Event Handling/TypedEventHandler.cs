﻿using System;
using System.Linq;

namespace NetGore
{
    /// <summary>
    /// Represents the method that will handle an event.
    /// </summary>
    /// <typeparam name="TSender">The type of the sender of the event.</typeparam>
    /// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    [Serializable]
    public delegate void TypedEventHandler<in TSender, in TEventArgs>(TSender sender, TEventArgs e) where TEventArgs : EventArgs;

    /// <summary>
    /// Represents the method that will handle an event.
    /// </summary>
    /// <typeparam name="TSender">The type of the sender of the event.</typeparam>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    [Serializable]
    public delegate void TypedEventHandler<in TSender>(TSender sender, EventArgs e);
}