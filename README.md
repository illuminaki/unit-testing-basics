# Unit Testing Basics

This repository provides a basic structure for understanding and practicing unit testing using .NET, xUnit, and SonarQube.

---

## Prerequisites

Before getting started, ensure the following tools are installed on your system:

1. [.NET SDK 8.0 or later](https://dotnet.microsoft.com/download)
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

#### b. Run Compile, Tests and Collect Coverage

```bash
dotnet build
```

Use `coverlet` to generate the coverage report in `opencover` format:

```bash
dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover
```
---


#### c. Run the analysis

Start the analysis:
```bash
   dotnet sonarscanner begin /k:"CSharp-UnitTesting-Basics" /d:sonar.login="YOUR_GENERATED_TOKEN" /d:sonar.host.url="http://localhost:9000"
```

Build your solution:
```bash
   dotnet build UnitTestingBasics.sln
```

Run tests with coverage:
```bash
 dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover 
```

Finish the analysis and send the data to SonarQube:
```bash
   dotnet sonarscanner end /d:sonar.login="YOUR_GENERATED_TOKEN"
```


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


