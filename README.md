# CandidateStatistics
The candidate statistic project contains the code to extract the statistics about the occurrence of a letter as initial of a forename.

## Projects and folder structure

### CandidatesManager
The CandidatesManager solution contains a set of projects that represent the backend of the application. They are

#### CandidatesManager
Contains the class library project

#### CandidatesManager.Tests
Unit tests for the CandidatesManager classes

#### CandidatesStatisticManager.WebAPI
Web API project exposing the results of the computed statistics

## CandidateStatisticFrontend
Angular 4 project, containing a basic frontend in order to show the result of the statistic.
Please note that this project has the only purpose of showing the result from the Web API call, so no authentication, style, etc. have been included.
