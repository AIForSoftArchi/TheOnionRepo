# The perfect Onion Architecture / Clean Architecture

This is our version of a Repo, that our system finds no errors in.
This is based on the repo created by <a href="https://github.com/NilavPatel">NilavPatel</a>, which can be found <a href="https://github.com/NilavPatel/dotnet-onion-architecture">here</a>

This repository has then been through our system, and then changed with it's individual changes

## BE AWARE

The Docs folder has also been removed.

## The original violations, according to out prototype

1. `UserDTO` in Application layer directly references Domain entity (User) in its constructor, violating dependency rule as Application should not depend directly on concrete Domain entities.

2. `SpecificationEvaluator` in Infrastructure layer uses Domain interfaces (`ISpecification`) and models (`BaseEntity`), but is not implementing any Domain interface itself, making it an infrastructure concern that's too tightly coupled to Domain.

3. `UserService` in Application layer directly instantiates Domain entities (User), violating the dependency inversion principle. It should use a factory or mapper.

4. `MyAppDbContext` in Infrastructure directly references Domain entities (User) without any abstraction layer or mapping configuration, creating tight coupling between Infrastructure and Domain.

5. `BaseRepositoryAsync` implementation in Infrastructure layer directly uses Domain models and interfaces without proper abstraction, making the Domain dependent on specific Infrastructure implementations.

6. `Email` and `MailAttachment` classes are in Application.Core but contain infrastructure-specific implementations (using System.Net.Mail), violating separation of concerns.

7. `UserController` in WebApi layer directly uses Application layer request/response models, creating tight coupling between presentation and application layers.

8. `SpecificationEvaluatorTestHelper` in Domain.Test references Infrastructure concerns (LINQ queries), violating layer isolation in testing.

9. Infrastructure's `ServiceExtensions` directly instantiates concrete implementations without proper abstractions, making it difficult to swap implementations.

10. `UserSpecifications` in Domain layer uses LINQ expressions, which are infrastructure concerns, violating domain isolation.

## The new architectual violations our prototype found
The new architectual violations our prototype found, can be found in the txt file named "The Next response from this.txt"
