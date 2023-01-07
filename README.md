# PolWarmDictionary_Frontend

So far only Polish version, I'm sorry.

Aplikacja nie jest jeszcze gotowym projektem!

Frontend do słownika warmińsko-polskiego/polsko-warmińskiego napisany w Blazor WebAssembly i działający w oparciu o Web API z repozytorium:  https://github.com/JakubJT/PolWarmDictionary_Backend.

Użyte technologie, rozwiązania:
- aplikacja frontendowa w technologii Blazor WebAssembly,
- gotowe zestawy darmowych komponentów napisanych dla Blazora : Mud Blazor i Radzen Blazor,
- użycie komponentów napisanych dla aplikacji/stron działających w HTML i JS: Bootstrap,
- Autentykacja/Autoryzacja przez Azure Active Directory,
- uruchamianie kodu java scriptowego z poziomu kodu C#,
- Dependency Injection,
- obsługa błędów przez wspólny komponent Error,
- biblioteka Blazor.SessionStorage.WebAssembly w celu korzystania z session storage.


Funkcjonalności w rozbiciu na poszczególne strony dostępne w aplikacji.

Strona główna:
- możliwość zmiany wyglądu komponentu wyszukiwania przy pomocy suwaka,
- możliwość wyszukiwanie słów w bazie słówek poprzez zapytanie do Web API,
- możliwość wyszukiwania słów po warmińsku i polsku,
- obsługa błędów.

Pasek na górze wszystkich stron:
- umożliwia logowanie i wylogowywanie się ze strony; wykorzystywany jest Azure Active Directory; logowanie jest konieczne by mieć dostęp do dwóch poniższych stron.

Wszystkie słowa:
- tabela ze wszystkim słowami w bazie słów podzielona na strony (10 słów na stronę),
- paginacja – kliknięcie przycisku strony powoduje wysłanie zapytania do Web API o słówka z danej strony,
- sortowanie na wszystkich kolumnach w sposób alfabetyczny – kliknięcie sortowania powoduje wysłanie zapytania do Web API o słówka z danej strony w wybranej kolejności,
- możliwość edycji słowa,
- po kliknięciu w przycisk Edytuj jestem przenoszeni do strony edycji, gdzie możemy zmienić zapis słowa po warmińsku i polsku oraz zmienić jaką jest częścią mowy (część mowy wybierane są przez dropdown)
  - zaimplementowana jest walidacja uzupełnianych w formularzu pól – max 16 znaków itd.; w przypadku błędu walidacji zapytanie do API nie zostaje wysłane,
  - kliknięcie Wróć przenosi nas do strony ze wszystkim słowami (wczytując je ponownie),
  - kliknięcie Zapisz, gdy dane są zgodne z walidacją w modelu Word wysyła żądanie edycji słowa do Web API i przenosi nas do strony ze wszystkim słowami (wczytując je ponownie);
- po kliknięciu przycisku Usuń wyskakuje modal (pop-up) z pytanie czy na pewno chcemy usunąć dane słowo
- kliknięcie przycisku Utwórz nowe słowo – przenosi nas na stronę z formularzem, w którym uzupełniamy odpowiednie pola słowa (takie same jak przy edycji)
  - zaimplementowana jest walidacja uzupełnianych w formularzu pól – max 16 znaków itd.; w przypadku błędu walidacji zapytanie do API nie zostaje wysłane,
  - kliknięcie Wróć przenosi nas do strony ze wszystkim słowami (wczytując je ponownie)
  - kliknięcie Zapisz, gdy dane są zgodne z walidacją w modelu Word wysyła żądanie utworzenia słowa do Web API i przenosi nas do strony ze wszystkim słowami (wczytując je ponownie)
- gdy słowo zostanie zedytowane lub powiedzie się jego utworzenie wyświetla się toast ze stosowną informacją (do jego wyświetlenia używany jest krótki kod java scriptowy uruchamiany z poziomu kodu w C#)

Kolekcje słów:
- pokazuje w tabeli wszystkie kolekcje słów danego użytkownika,
- można usunąć daną kolekcję – po kliknięciu przycisku Usuń przy danej kolekcji wyświetla się modal (pop-up) z pytaniem czy na pewno chcemy usunąć daną kolekcję,
- po kliknięciu Edytuj przy danej kolekcji, przenosi nas do widoku z edycją kolekcji (nie przenosi nas na nową stronę razor),
	- w tym widoku możemy usuwać słowa,
  - dodawać nowe – robimy to przez ich wyszukanie w bazie (do dyspozycji mamy ten sam komponent wyszukiwania co na stronie głównej), wybranie odpowiedniej pozycji z tabeli wyszukanych tłumaczeń i kliknięcie przycisku Dodaj
  - kliknięcie przycisku Wróć zmienia widok na tabelę kolekcji słów,
  - kliknięcie Zapisz, gdy dane są zgodne z walidacją w modelu WordGroup wysyła żądanie edycji kolekcji do Web API,
- po kliknięciu przycisku Utwórz nową grupę, otwiera się modal (pop-up), który korzysta z tego samego komponentu z formularzem co w edycji kolekcji słów,
	- w okienku możemy usuwać słowa,
  - dodawać nowe – robimy to przez ich wyszukanie w bazie (do dyspozycji mamy ten sam komponent wyszukiwania co na stronie głównej), wybranie odpowiedniej pozycji z tabeli wyszukanych tłumaczeń i kliknięcie przycisku Dodaj,
  - kliknięcie przycisku Zamknij zamyka modal,
  - kliknięcie przycisku Utwórz, gdy dane są zgodne z walidacją w modelu WordGroup wysyła żądanie edycji kolekcji do Web API,
