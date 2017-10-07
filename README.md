# CandidateStatistics
The candidate statistic project contains the code to extract the statistics about the occurrence of a letter as initial of a forename.

## Projects and folder structure

### CandidatesManager
The CandidatesManager solution contains a set of projects that represent the backend of the application. They are

#### CandidatesManager.Library
Project containing the core classes and logic for the statistic computation

#### CandidatesManager.Tests
Project containing the unit tests for the CandidateManager.Library classes

#### CandidatesManager.WebAPI
Web API project exposing the results of the computed statistics, in order to be consumed by a REST client.
The WebAPI has a single controller GET method api/CandidateStatistic returning the calculated statistics.

## CandidateStatisticFrontend
Angular 4 project, containing a basic frontend in order to show the result of the statistic.
Please note that this project has the only purpose to consume of showing the result from the Web API call, so no authentication, style, etc. have been included.
Note: for simplicity the URL of the WebAPI backend has been hardcoded in the app.service.ts
