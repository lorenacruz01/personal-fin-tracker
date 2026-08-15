# Personal Fin Tracker

Personal finance management application focused on providing a clear overview of financial health through expense tracking, credit card management, recurring expenses, and purchase planning.

The project is being developed as a personal portfolio and learning project, with an emphasis on **software architecture, API security, authentication, authorization, and integration with external services**.

## Project Goals

The main goal of Personal Fin Tracker is to provide a centralized view of personal finances, helping users understand how their spending affects their monthly budget and financial planning.

The application will allow users to:

* Track personal expenses.
* Manage credit cards and their expenses.
* Register recurring and fixed expenses.
* Plan future purchases.
* Evaluate the impact of planned purchases on the available budget.
* Visualize an overview of their financial health.

## Architecture

The backend will follow **Clean Architecture**, keeping business rules independent from infrastructure and external services.

The project will be structured around the following layers:

* **Domain** — Business entities and domain rules.
* **Application** — Application use cases and business orchestration.
* **Infrastructure** — Persistence and integrations with external services.
* **API** — HTTP interface and application entry point.

The frontend will be developed separately using React.js.

## Technologies

### Backend

* .NET
* C#
* Minimal API
* Entity Framework Core
* Clean Architecture

### Frontend

* React.js
* TypeScript
* Vite

### Authentication & Security

* Google OAuth / OpenID Connect
* Authentication
* Authorization
* Secure API access
* Token-based authentication

### Data & External Services

The project will evaluate the use of **Google Sheets API** as a persistence mechanism, allowing financial data to remain associated with the user's own Google account.

Entity Framework Core will also be used in the project to explore data access and persistence concepts.

## Security

Security is one of the main learning objectives of this project.

The API will explore concepts such as:

* Authentication
* Authorization
* OAuth 2.0
* OpenID Connect
* Access tokens
* Claims
* Resource-based authorization
* Secure configuration
* Secret management
* API input validation
* CORS
* Error handling

The application should never rely solely on identifiers supplied by the client to determine which user's resources can be accessed. User identity and permissions should be derived from the authenticated context.

## Planned Features

* [ ] User authentication with Google
* [ ] User authorization
* [ ] Financial dashboard
* [ ] Expense management
* [ ] Credit card management
* [ ] Recurring expense management
* [ ] Purchase planning
* [ ] Budget impact analysis
* [ ] Financial summaries
* [ ] Google Sheets integration
* [ ] Automated tests
* [ ] Docker support
* [ ] CI/CD pipeline

## Learning Objectives

This project is also intended to provide practical experience with:

* Clean Architecture
* Domain-Driven Design concepts
* Minimal APIs
* REST API development
* Authentication and authorization
* OAuth 2.0 / OpenID Connect
* API security
* Entity Framework Core
* React.js
* External API integration
* Automated testing
* Containerization
* CI/CD

## Project Status

**In development.**

The architecture and technical decisions may evolve as the project progresses and new requirements are identified.

## License

This project is licensed under the MIT License.
