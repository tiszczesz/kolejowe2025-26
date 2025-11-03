# Instrukcja tworzenia solution Nwd.Solution za pomocą dotnet CLI

## 1. Tworzenie pustego solution

```bash
# Tworzenie pustego solution
dotnet new sln -n Nwd.Solution
```

## 2. Tworzenie projektów

```bash
# Tworzenie biblioteki klas
dotnet new classlib -n Nwd.ClassLib -f net9.0

# Tworzenie aplikacji konsolowej
dotnet new console -n Nwd.ConsoleApp -f net9.0

# Tworzenie aplikacji WinForms
dotnet new winforms -n Nwd.WinFormsApp -f net9.0

# Tworzenie aplikacji MVC
dotnet new mvc -n Nwd.MvcApp -f net9.0

# Tworzenie Web API
dotnet new webapi -n Nwd.Api -f net9.0

# Tworzenie projektu testów jednostkowych
dotnet new xunit -n Nwd.UnitTests -f net9.0
```

## 3. Dodawanie projektów do solution

```bash
# Dodawanie wszystkich projektów do solution
dotnet sln Nwd.Solution.sln add Nwd.ClassLib\Nwd.ClassLib.csproj
dotnet sln Nwd.Solution.sln add Nwd.ConsoleApp\Nwd.ConsoleApp.csproj
dotnet sln Nwd.Solution.sln add Nwd.WinFormsApp\Nwd.WinFormsApp.csproj
dotnet sln Nwd.Solution.sln add Nwd.MvcApp\Nwd.MvcApp.csproj
dotnet sln Nwd.Solution.sln add Nwd.Api\Nwd.Api.csproj
dotnet sln Nwd.Solution.sln add Nwd.UnitTests\Nwd.UnitTests.csproj
```

## 4. Dodawanie referencji między projektami

### Dodanie referencji Nwd.ClassLib do Nwd.Api

```bash
dotnet add Nwd.Api\Nwd.Api.csproj reference Nwd.ClassLib\Nwd.ClassLib.csproj
```

### Dodatkowe referencje (opcjonalnie)

```bash
# Dodanie referencji ClassLib do pozostałych projektów
dotnet add Nwd.ConsoleApp\Nwd.ConsoleApp.csproj reference Nwd.ClassLib\Nwd.ClassLib.csproj
dotnet add Nwd.MvcApp\Nwd.MvcApp.csproj reference Nwd.ClassLib\Nwd.ClassLib.csproj
dotnet add Nwd.WinFormsApp\Nwd.WinFormsApp.csproj reference Nwd.ClassLib\Nwd.ClassLib.csproj

# Dodanie referencji ClassLib do projektu testów
dotnet add Nwd.UnitTests\Nwd.UnitTests.csproj reference Nwd.ClassLib\Nwd.ClassLib.csproj
```

## 5. Budowanie i uruchamianie

```bash
# Budowanie całego solution
dotnet build Nwd.Solution.sln

# Uruchamianie poszczególnych projektów
dotnet run --project Nwd.ConsoleApp
dotnet run --project Nwd.MvcApp
dotnet run --project Nwd.Api

# Uruchamianie testów
dotnet test Nwd.UnitTests
```

## 6. Przydatne komendy

```bash
# Sprawdzenie struktury solution
dotnet sln Nwd.Solution.sln list

# Sprawdzenie referencji w projekcie
dotnet list Nwd.Api\Nwd.Api.csproj reference

# Czyszczenie solution
dotnet clean Nwd.Solution.sln

# Przywracanie pakietów NuGet
dotnet restore Nwd.Solution.sln
```

## Uwagi

- Wszystkie projekty używają .NET 9.0
- Projekt `Nwd.ClassLib` jest biblioteką klas, która może być referencjonowana przez inne projekty
- Projekt `Nwd.Api` to Web API, który ma referencję do `Nwd.ClassLib`
- Projekt `Nwd.UnitTests` używa frameworku xUnit do testów jednostkowych
- Komenda `dotnet new` tworzy podstawowe szablony, które można następnie modyfikować według potrzeb
