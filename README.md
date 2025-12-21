# Hexalith.Domains

**Hexalith.Domains** provides the core Domain Driven Design (DDD) abstractions and implementations for the Hexalith ecosystem. It serves as the foundation for building domain-centric microservices and modules, defining standard interfaces for aggregates, entities, events, and value objects.

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

## Repository Structure

The repository is organized as follows:

- [src](./src/README.md): Source code directory.
  - [src/libraries](./src/libraries/README.md): Core libraries and abstractions.
  - [src/examples](./src/examples/README.md): Example implementations.
- [test](./test/README.md): Unit and integration tests.
- [Hexalith.Builds](./Hexalith.Builds/README.md): Shared build configurations.

## Getting Started

### Prerequisites

- [Hexalith.Builds](https://github.com/Hexalith/Hexalith.Builds)
- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later
- [PowerShell 7](https://github.com/PowerShell/PowerShell) or later
- [Git](https://git-scm.com/)

### Git Submodules

This project uses the Hexalith.Builds repository as a Git submodule for build infrastructure. Ensure submodules are initialized:

```bash
git submodule update --init --recursive
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
