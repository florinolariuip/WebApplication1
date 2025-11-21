# Tasks for Students

## Review and Refactor
- Review the provided codebase.
- Refactor following best practices learned: clean architecture, meaningful naming, separation of concerns, single responsibility, and dependency injection.

## Add New Endpoints
Implement the following Minimal API endpoints (exposed from `Program.cs`):
- `GET /papers/{id}` → Get paper by ID. Return `404` if not found.
- `GET /papers` → Get all papers.
- `GET /papers/top3` → Get the top 3 most recent papers ordered by date.

Ensure responses use proper DTOs and map domain entities to DTOs in the application layer.

## Write Unit Tests
- Create unit tests for the FluentValidation validators (for example, `AddPaperValidator`).
- Validate success and failure scenarios (required fields, invalid values).
- Use a test framework such as xUnit and a mocking library like Moq or NSubstitute.

## Expose All Endpoints
- Ensure all endpoints are registered using the Minimal API style in `Program.cs`.
- Keep `Program.cs` minimal: register services, map endpoints, and call `app.Run()`.

## Bonus (Extra Points)
- Write unit tests for MediatR handlers (for example, `AddPaperHandler`, `DeletePaperHandler`).
- Mock repository/DB contexts and assert handler behaviors.

## ✅ Important Notes
- The project **must run successfully** after your changes.
- The database must contain at least 5 papers after migrations and initial seeding.
- EF Core migrations must be created and applied initially. Run these commands:
  - `dotnet ef migrations add InitialCreate`
  - `dotnet ef database update`
- Ensure seed data (at least 5 papers) is added either in the `DbContext` seed configuration or in a migration/initializer.

## Packaging / Submission
- Create an archive of the project excluding `bin` and `obj` folders.

## Deliverables
- Refactored codebase with clear project structure (API, Application, Domain, Infrastructure).
- Implemented endpoints and DTOs.
- Unit tests for FluentValidation validators.
## (Bonus) Unit tests for MediatR handlers.


