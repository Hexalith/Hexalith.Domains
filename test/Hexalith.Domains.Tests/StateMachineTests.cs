// <copyright file="StateMachineTests.cs" company="ITANEO">
// Copyright (c) ITANEO (https://www.itaneo.com). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Hexalith.Domains.Tests;

using System.Collections.Generic;

using Hexalith.Domains;

using Shouldly;

using Xunit;

/// <summary>
/// Tests for the <see cref="StateMachine{T}"/> class.
/// </summary>
public sealed class StateMachineTests
{
    /// <summary>
    /// Tests that IsValidTransition returns true for defined transitions.
    /// </summary>
    [Fact]
    public void IsValidTransitionWithValidTransitionShouldReturnTrue()
    {
        // Arrange
        TestStateMachine stateMachine = new();

        // Act & Assert
        stateMachine.IsValidTransition("Start", "Processing").ShouldBeTrue();
        stateMachine.IsValidTransition("Processing", "Completed").ShouldBeTrue();
    }

    /// <summary>
    /// Tests that IsValidTransition returns false for undefined transitions.
    /// </summary>
    [Fact]
    public void IsValidTransitionWithInvalidTransitionShouldReturnFalse()
    {
        // Arrange
        TestStateMachine stateMachine = new();

        // Act & Assert
        stateMachine.IsValidTransition("Start", "Completed").ShouldBeFalse();
        stateMachine.IsValidTransition("Processing", "Start").ShouldBeFalse();
    }

    /// <summary>
    /// Tests that GetValidTransitions returns the correct list of transitions for a valid state.
    /// </summary>
    [Fact]
    public void GetValidTransitionsWithExistingStateShouldReturnTransitions()
    {
        // Arrange
        TestStateMachine stateMachine = new();

        // Act
        IEnumerable<string> transitions = stateMachine.GetValidTransitions("Start");

        // Assert
        transitions.ShouldContain("Processing");
        transitions.ShouldContain("Cancelled");
        transitions.Count().ShouldBe(2);
    }

    /// <summary>
    /// Tests that GetValidTransitions returns an empty list for a state with no transitions.
    /// </summary>
    [Fact]
    public void GetValidTransitionsWithNonExistingStateShouldReturnEmpty()
    {
        // Arrange
        TestStateMachine stateMachine = new();

        // Act
        IEnumerable<string> transitions = stateMachine.GetValidTransitions("Unknown");

        // Assert
        transitions.ShouldBeEmpty();
    }

    private sealed record TestStateMachine : StateMachine<string>
    {
        private static readonly IDictionary<string, IEnumerable<string>> _transitions = new Dictionary<string, IEnumerable<string>>
        {
            { "Start", ["Processing", "Cancelled"] },
            { "Processing", ["Completed", "Failed"] },
            { "Failed", ["Processing"] },
        };

        protected override IDictionary<string, IEnumerable<string>> ValidTransitions => _transitions;
    }
}
