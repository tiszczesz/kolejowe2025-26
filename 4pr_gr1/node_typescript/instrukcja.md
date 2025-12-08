# Instrukcja: Inicjowanie projektu TypeScript + ESM (krok po kroku)

Poniższa instrukcja pokaże jak w prosty sposób utworzyć projekt Node + TypeScript, zainstalować TypeScript lokalnie i skonfigurować kompilator tak, aby:
- źródła były w katalogu `src`
- skompilowane pliki trafiały do katalogu `dist`
- projekt używał natywnych ES modules (ESM) w wynikowych plikach `.js`

Wymagania:
- Node.js w wersji co najmniej 16 (zalecane 18+)
- npm (dołączony do Node)

Krok 0 — przygotowanie katalogu projektu
- Jeśli jeszcze nie masz katalogu projektu:
  - mkdir node_typescript
  - cd node_typescript
- Jeśli jesteś w repozytorium, przejdź do wybranego katalogu projektu.

Krok 1 — inicjalizacja npm
1. npm init -y
   - Utworzy podstawowy `package.json`.

Krok 2 — instalacja TypeScript lokalnie
1. npm install --save-dev typescript
   - Instalacja TypeScript jako zależności deweloperskiej.

Krok 3 — inicjalizacja tsconfig.json
1. npx tsc --init
   - Utworzy plik `tsconfig.json`. Zastąp jego zawartość (lub edytuj) przykładową konfiguracją poniżej.

Przykładowy `tsconfig.json` przygotowany dla Node ESM (zalecane ustawienia):
```json
{
  "compilerOptions": {
    "target": "ES2020",
    "module": "NodeNext",
    "moduleResolution": "NodeNext",
    "rootDir": "src",
    "outDir": "dist",
    "strict": true,
    "esModuleInterop": true,
    "forceConsistentCasingInFileNames": true,
    "skipLibCheck": true,
    "resolveJsonModule": true,
    "declaration": false,
    "sourceMap": true
  },
  "include": ["src"]
}
```
Wyjaśnienia kluczowych opcji:
- `module: "NodeNext"` oraz `moduleResolution: "NodeNext"` — mówi TypeScript, żeby stosował nowy model rozwiązywania modułów zgodny z Node.js (obsługa ESM i rozszerzeń plików).
- `rootDir: "src"` i `outDir: "dist"` — źródła w `src`, wynik w `dist`.
- `target: "ES2020"` — wynikowy JS będzie używać nowoczesnych funkcji ES.

Alternatywnie odkomentowujesz outDir i rootDir

Doinstalować typy TS do node
```console
npm i @types/node -D
```
W pliku tsconfig dodać do tablicy uzycie typów node

Krok 4 — konfiguracja package.json do użycia ESM
Otwórz `package.json` i dodaj/zmodyfikuj pola:
```json
{
  "type": "module",
  "main": "dist/index.js",
  "scripts": {
    "build": "tsc -p .",
    "start": "node dist/index.js",
    "clean": "rm -rf dist || rd /s /q dist",
    "watch": "tsc -w -p ."
  }
}
```
- `type: "module"` — mówi Node, że `.js` to moduły ESM.
- `start` uruchamia skompilowaną aplikację z `dist`.

Krok 5 — wskazówki dotyczące importów w TypeScript (ważne dla ESM)
- Przy użyciu `module: "NodeNext"` możesz w plikach `.ts` używać rozszerzeń `.js` w ścieżkach importu:
  - import { foo } from "./utils.js";
  - TypeScript poprawnie zmapuje to przy kompilacji i Node będzie w stanie znaleźć plik `dist/utils.js`.
- Alternatywnie można używać bez rozszerzeń, ale wtedy zależy to od ustawień i zachowania bundlera/resolve; najbardziej przewidywalne jest używanie rozszerzeń `.js` w importach źródłowych `.ts` przy Node ESM.
- Unikaj mieszania `require()` (CJS) z `import` (ESM). Przy ESM używaj `import`/`export`.

Krok 6 — przykładowe pliki źródłowe
Utwórz katalog `src` i przykładowy plik `src/index.ts`:
```ts
// src/index.ts
import { hello } from "./hello.js";

console.log(hello("świat"));
```

I `src/hello.ts`:
```ts
// src/hello.ts
export function hello(name: string) {
  return `Cześć, ${name}!`;
}
```
Zwróć uwagę na `.js` w importach źródłowych — to potrzebne, żeby po kompilacji Node ESM znalazł poprawny plik `dist/hello.js`.

Krok 7 — kompilacja i uruchomienie
1. npm run build
   - Skompiluje TypeScript z `src` do `dist`.
2. npm start
   - Uruchomi `node dist/index.js`.

Krok 8 — tryb deweloperski
- Szybkie odbudowywanie podczas pracy:
  - npm run watch
- Dla szybkiego uruchamiania bez pełnej kompilacji możesz rozważyć użycie `ts-node` (z uwagami do ESM), ale dla stabilności produkcyjnej rekomendowane jest najpierw `tsc` → `node`.

Dodatkowe uwagi i typowe problemy
- Node wymagany w wersji obsługującej ESM (najlepiej 16+). Starsze wersje mogą wymagać flag lub nie wspierać `NodeNext`.
- Jeżeli widzisz błędy typu "Cannot find module" po kompilacji, sprawdź:
  - Czy w importach dodajesz rozszerzenie `.js`.
  - Czy `package.json` ma `"type": "module"`.
  - Czy `outDir` faktycznie zawiera skompilowane pliki.
- Jeżeli potrzebujesz kompatybilności CommonJS + ESM, rozważ bardziej zaawansowaną konfigurację (podwójne buildy, pola `exports` w package.json itp.).

Przykładowy minimalny workflow (komendy do skopiowania):
```bash
# w katalogu projektu
npm init -y
npm install --save-dev typescript
npx tsc --init
# zamień zawartość tsconfig.json zgodnie z przykładem powyżej
mkdir src
# dodaj src/index.ts oraz inne pliki
# zaktualizuj package.json: dodaj "type": "module" i scripts (build, start)
npm run build
npm start
```
