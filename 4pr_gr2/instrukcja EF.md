# Instrukcja: Instalacja Entity Framework Core, tworzenie migracji i aktualizacja bazy danych

Poniżej znajdziesz instrukcję krok po kroku, jak zainstalować narzędzie Entity Framework Core lokalnie w projekcie, utworzyć migracje oraz zaktualizować bazę danych.

---

## 1. Utworzenie manifestu narzędziowego (.NET Tool Manifest)

W katalogu głównym projektu (np. `4pr_gr2`) uruchom w terminalu:

```bash
dotnet new tool-manifest
```

To polecenie utworzy plik `.config/dotnet-tools.json` do zarządzania narzędziami .NET w projekcie.

---

## 2. Instalacja Entity Framework Core CLI lokalnie

Następnie zainstaluj narzędzie EF Core CLI:

```bash
dotnet tool install dotnet-ef
```

Po instalacji możesz korzystać z poleceń EF Core bez potrzeby globalnej instalacji narzędzia.

---

## 3. Tworzenie migracji

Jeżeli w projekcie masz już skonfigurowany kontekst bazy danych (DbContext), możesz utworzyć pierwszą migrację:

```bash
dotnet ef migrations add InitialCreate
```

Zalecane jest nadanie migracji opisowej nazwy, np. `InitialCreate` dla pierwszej migracji.

---

## 4. Aktualizacja bazy danych

Aby zastosować migracje do bazy danych, użyj polecenia:

```bash
dotnet ef database update
```

Polecenie to utworzy lub zaktualizuje schemat bazy danych zgodnie z migracjami w projekcie.

---

## Podsumowanie poleceń (do skopiowania)

```bash
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## Uwagi dodatkowe

- Upewnij się, że jesteś w katalogu projektu (tam, gdzie znajduje się plik `.csproj`).
- W przypadku problemów z poleceniami, sprawdź czy narzędzia są zainstalowane lokalnie (w folderze `.config`).
- Migracje możesz nazywać dowolnie, np. `AddStudentTable`, `UpdateGrades`.

---


