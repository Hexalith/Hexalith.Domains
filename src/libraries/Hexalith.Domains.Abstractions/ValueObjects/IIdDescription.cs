﻿// <copyright file="IIdDescription.cs" company="ITANEO">
// Copyright (c) ITANEO (https://www.itaneo.com). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Hexalith.Domains.ValueObjects;

/// <summary>
/// Interface for objects that have an ID and a description.
/// </summary>
public interface IIdDescription
{
    /// <summary>
    /// Gets the description of the object.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets a value indicating whether the object is disabled.
    /// </summary>
    bool Disabled { get; }

    /// <summary>
    /// Gets the ID of the object.
    /// </summary>
    string Id { get; }

    /// <summary>
    /// Gets the name of the object.
    /// </summary>
    string Search => Id + " " + Description;
}