# Unit Testing Basics

This repository provides a basic structure for understanding and practicing unit testing using .NET, xUnit, and SonarQube.

---

## Prerequisites

Before getting started, ensure the following tools are installed on your system:

1. [.NET SDK 7.0 or later](https://dotnet.microsoft.com/download)
2. [Git](https://git-scm.com/downloads)
3. [SonarQube](https://www.sonarqube.org/) (running locally or on a server)
4. `dotnet-sonarscanner`:
   ```bash
   dotnet tool install --global dotnet-sonarscanner
   ```

---

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/illuminaki/unit-testing-basics.git
cd unit-testing-basics
```

#### b. Run Tests and Collect Coverage

Use `coverlet` to generate the coverage report in `opencover` format:

```bash
dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover
```
---

## Project Structure

```
unit-testing-basics/
│
├── src/
│   └── UnitTestingBasics/
│       ├── Calculator.cs         # Implementation of the Calculator class
│       └── UnitTestingBasics.csproj
│
├── tests/
│   └── UnitTestingBasics.Tests/
│       ├── CalculatorTests.cs    # Unit tests for the Calculator class
│       ├── coverage.opencover.xml # Coverage report
│       └── UnitTestingBasics.Tests.csproj
│
├── sonar-project.properties       # SonarQube configuration file
├── README.md                      # Project documentation
└── unit-testing-basics.sln        # Solution file
```

---

## Contributing

Feel free to fork this repository and create pull requests for improvements or additional examples.

---

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.


