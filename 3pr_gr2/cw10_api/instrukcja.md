# instrukcja

## Porównanie AddScoped, AddTransient, AddSingleton

W ASP.NET Core te metody rejestrują usługi w kontenerze DI z różnym czasem życia obiektu.

### AddTransient

- Tworzy nową instancję za każdym razem, gdy usługa jest pobierana.
- Najkrótszy cykl życia.
- Dobre dla lekkich i bezstanowych serwisów.

### AddScoped

- Tworzy jedną instancję na jeden zakres, zwykle na jedno żądanie HTTP.
- W obrębie jednego requestu używana jest ta sama instancja.
- Najczęstszy wybór dla logiki biznesowej i repozytoriów powiązanych z requestem.

### AddSingleton

- Tworzy jedną instancję na cały czas działania aplikacji.
- Ta sama instancja jest współdzielona przez wszystkie żądania.
- Dobre dla cache, konfiguracji i usług globalnych.
- Usługa musi być bezpieczna wielowątkowo.

## Ważna uwaga dla obecnej konfiguracji

Masz zarejestrowany ten sam interfejs trzy razy:

- AddScoped
- AddTransient
- AddSingleton

Przy wstrzykiwaniu pojedynczego interfejsu zwykle decyduje ostatnia rejestracja, czyli AddSingleton.

To oznacza, że w praktyce usługa działa jak Singleton, mimo wcześniejszych wpisów.

## Kiedy czego używać

- AddTransient: gdy usługa jest bardzo lekka i bez stanu.
- AddScoped: gdy stan ma żyć w obrębie jednego requestu.
- AddSingleton: gdy potrzebujesz jednej globalnej instancji dla całej aplikacji.
