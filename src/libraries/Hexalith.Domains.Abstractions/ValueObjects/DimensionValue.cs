﻿// <copyright file="DimensionValue.cs" company="ITANEO">
// Copyright (c) ITANEO (https://www.itaneo.com). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Hexalith.Domains.ValueObjects;

using System.Runtime.Serialization;

/// <summary>
/// Represents a dimension value.
/// </summary>
[DataContract]
public record DimensionValue(
    [property:DataMember(Order = 1)]
    string Type,
    [property:DataMember(Order = 2)]
    string Value,
    [property:DataMember(Order = 3)]
    string Name)
{
}