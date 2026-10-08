# Contributing to This Project

Thank you for taking the time to consider contributing to our project.

The following is a set of guidelines for contributing to the project.
These are mostly guidelines, not rules, and can be changed in the future.
Please submit your suggestions with a pull-request to this document.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [What should I know before I get started](#what-should-i-know-before-i-get-started)
  - [Project Folder Structure](#project-folder-structure)
  - [Design Decisions](#design-decisions)
  - [How can I contribute](#how-can-i-contribute)
    - [Create an Issue](#create-an-issue)
    - [Respond to an Issue](#respond-to-an-issue)
    - [Write code](#write-code)
    - [Write documentation](#write-documentation)

## Welcome

Thank you for your interest in contributing! We value all contributions and strive to make this project a welcoming, inclusive space for everyone.

Below are guidelines to help you get started. If you have suggestions, please submit a pull request to this document.

## Code of Conduct

We have adopted a code of conduct from the Contributor Covenant. Contributors to this project are expected to adhere to this code. Please report unwanted behavior to [Project Maintainer](mailto:matthew.paulosky@outlook.com)

## Quick Start

1. Fork the repository and clone your fork.
2. Follow [PROCESS.md](PROCESS.md): the one-time hook setup, a branch named to the standard in its own worktree,
   commit and PR title format, the PR description, and how checks, review, merging and releases work.
3. Make your changes, following the code style and guidelines below, with tests.
4. Push your branch and open a Pull Request to `main` using the template.

## What should I know before I get started

SuggestionApp is a Blazor Server web application, on .NET 10, for posting and voting on suggestions. It stores its data in
MongoDB and signs users in with Azure AD B2C through Microsoft.Identity.Web.

### Code Style & Commit Messages

- Use consistent formatting (C# conventions, .editorconfig if present).
- Commits and PR titles follow [git-commit-instructions.md](../.github/instructions/git-commit-instructions.md)
  (`<type>(<scope>): <Summary>`); see [PROCESS.md](PROCESS.md#commits-and-pr-titles).
- Add comments to explain complex logic.

### Project Folder Structure

This project can be built and run with Visual Studio, JetBrains Rider, Visual Studio Code or the `dotnet` CLI.
The folders are configured so that they will support editing and working in other editors and on other operating systems.
We encourage you to develop with these other environments, because we would like to be able to support developers who use those tools as well.
The folders are configured as follows:

```bash
.github/                                -- Workflows, instructions and templates
docs/                                   -- Documentation and guides
scripts/                                -- Local quality gate and PR title / branch name checks

SuggestionAppLibrary/                   -- Class library: models and data access
  DataAccess/                           -- MongoDB connection and the I*Data / Mongo*Data stores
  Models/                               -- Domain models

SuggestionAppUI/                        -- Blazor Server UI project
  Components/                           -- Reusable components
  Helpers/                              -- Authentication state helpers
  Models/                               -- UI form models
  Pages/                                -- Razor pages and their code-behind
  Shared/                               -- Layout, login display and not-authorized views
  wwwroot/                              -- Static web assets (CSS, JS, etc.)
  appsettings.json                      -- UI configuration
  Program.cs, RegisterServices.cs       -- Startup and service registration

SuggestionApp.slnx                      -- Solution file
codecov.yml                             -- Code coverage configuration
GitVersion.yml                          -- Versioning configuration
global.json                             -- Global SDK version
LICENSE                                 -- License
README.md                               -- Project overview
```

See the main [README.md](../README.md) for more details.

All official versions of the project are built and delivered with GitHub Actions and linked in the main README.md and the [releases tab](https://github.com/mpaulosky/SuggestionApp/releases).

### Design Decisions

Design for this project is ultimately decided by the project team lead (the repository maintainer). The following project tenets are adhered to when making decisions:

1. Use Blazor Server for the UI.
1. Use MongoDB, through MongoDB.Driver, for data persistence.
1. Use Azure AD B2C, through Microsoft.Identity.Web, for authentication.
1. Keep data access behind the `I*Data` interfaces in SuggestionAppLibrary.

If you have suggestions, please open an issue or discuss in your pull request.

### How can I contribute

We are always looking for help on this project. There are several ways that you can help:
This means one of several types of contributions:

1. [Create an Issue](#create-an-issue)
1. [Respond to an Issue](#respond-to-an-issue)
1. [Write code](#write-code)
1. [Write documentation](#write-documentation)

## Contribution Types

- **Report a Bug:** Please add the `Bug` label so we can triage and track it.
- **Suggest an Enhancement:** Add the `Enhancement` label for new features or improvements.
- **Write Code:** All code should be linked to an issue. Include or update tests for new features and bug fixes.
- **Write Documentation:** Help us improve `/docs` and keep the main [README.md](../README.md) up to date.

### Create an Issue

Create a [New Issue Here](https://github.com/mpaulosky/SuggestionApp/issues/new/choose).

1. If you are reporting a `Bug` that you have found. Be sure to add the `Bug` label so that we can triage and track it.
1. If you are reporting an `Enhancement` that you think would improve the project. Be sure to add the `Enhancement`
   label so we can track it.

Please provide as much detail as possible, including steps to reproduce, expected behavior, and screenshots if helpful.

### Respond to an Issue

[Fork the Repository to your account](https://github.com/mpaulosky/SuggestionApp/fork).

1. Create a branch in its own worktree, named for the existing Issue number (e.g. `fix/123-null-title`); see [PROCESS.md](PROCESS.md#branches-and-worktrees).
1. Work on the issue.
1. Create Unit, Integration tests for any code that require them. We use xUnit to test our code and bUnit to test Blazor components.
1. When you are done Create a Pull Request from your branch to the main branch.
1. Submit the Pull Request.

**Note:** Pull requests without unit tests will be delayed until tests are added. All new features and bug fixes must
include appropriate tests.

Any code that is written to support a component or new functionality are required to be accompanied with unit tests at the time the pull request is submitted.
Pull requests without unit tests will be delayed and asked for unit tests to prove their functionality.

### Review Process

Every PR is reviewed by Copilot on each push, and merges once its required checks pass and every review thread is
resolved: a same-repo PR merges on its own, and the maintainer merges a fork's. The details are in
[PROCESS.md](PROCESS.md#checks-review-and-merging).

### Write code

All code should have an assigned issue that matches it. This way we can prevent contributors from working on the same
feature at the same time.

Code for components' features should also include some definition in the `/docs` folder so that our users can
identify and understand which feature is supported.

See [docs/](../docs) for feature documentation guidelines.

### Write documentation

The documentation for the project is always needed. We are always looking for help to add content to the `/docs`
section of the repository with proper links back through to the main `/README.md`.

---

Thank you for helping us make this project better!
