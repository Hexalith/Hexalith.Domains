# Hexalith.Domains

This is a template repository for creating new Hexalith packages. The repository provides a structured starting point for developing new packages within the Hexalith ecosystem.

## Build Status

[![License: MIT](https://img.shields.io/github/license/hexalith/hexalith.Domains)](https://github.com/hexalith/hexalith/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1063152441819942922?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discordapp.com/channels/1102166958918610994/1102166958918610997)

[![Coverity Scan Build Status](https://scan.coverity.com/projects/31529/badge.svg)](https://scan.coverity.com/projects/hexalith-hexalith-Domains)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/d48f6d9ab9fb4776b6b4711fc556d1c4)](https://app.codacy.com/gh/Hexalith/Hexalith.Domains/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=sqale_index)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=Hexalith_Hexalith.Domains&metric=bugs)](https://sonarcloud.io/summary/new_code?id=Hexalith_Hexalith.Domains)

[![Build status](https://github.com/Hexalith/Hexalith.Domains/actions/workflows/build-release.yml/badge.svg)](https://github.com/Hexalith/Hexalith.Domains/actions)
[![NuGet](https://img.shields.io/nuget/v/Hexalith.Domains.svg)](https://www.nuget.org/packages/Hexalith.Domains)
[![Latest](https://img.shields.io/github/v/release/Hexalith/Hexalith.Domains?include_prereleases&label=preview)](https://github.com/Hexalith/Hexalith.Domains/pkgs/nuget/Hexalith.Domains)

## Overview

This repository provides a template for creating new Hexalith packages. It includes all the necessary configuration files, directory structure, and GitHub workflow configurations to ensure consistency across Hexalith packages.

## Repository Structure

The repository is organized as follows:

- [src](./src/README.md) Is the source code directory of your project.
- [src/libraries](./src/libraries/README.md) Is the source code directory where you will add your Nuget package projects.
- [src/examples](./src/examples/README.md) Contains example implementations of your projects.
- [src/servers](./src/servers/README.md) Is the source code directory where you will add your Docker container projects.
- [src/aspire](./src/aspire/README.md) Is the source code directory where you will add your Aspire project.
- [test](./test/README.md) Contains test projects for your packages.
- [Hexalith.Builds](./Hexalith.Builds/README.md) Contains shared build configurations and tools.

## Getting Started

### Prerequisites

- [Hexalith.Builds](https://github.com/Hexalith/Hexalith.Builds)
- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later
- [PowerShell 7](https://github.com/PowerShell/PowerShell) or later
- [Git](https://git-scm.com/)

### Initializing the Package

To use this template to create a new Hexalith package:

1. Clone this repository or use it as a template when creating a new repository on GitHub.
2. Run the initialization script with your desired package name:

```powershell
./initialize.ps1 -PackageName "YourPackageName"
```

This script will:

- Replace all occurrences of "Domains" with your package name
- Replace all occurrences of "Domains" with the lowercase version of your package name
- Rename directories and files that contain "Domains" in their name
- Initialize and update Git submodules
- Set up the project structure for your new package

### Git Submodules

This template uses the Hexalith.Builds repository as a Git submodule. For information about the build system and configuration, refer to the README files in the Hexalith.Builds directory.

## Development

After initializing your package, you can start developing by:

1. Opening the solution file in your preferred IDE
2. Adding your implementation to the src/ directory
3. Writing tests in the test/ directory
4. Building and testing your package

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
