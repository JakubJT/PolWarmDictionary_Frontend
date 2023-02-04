# PolWarmDictionary_Frontend

English verion below.

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
- biblioteka Blazor.SessionStorage.WebAssembly w celu korzystania z session storage,
- lokalizacja; dostępna jest angielska i polska wersja słownika.


Funkcjonalności w rozbiciu na poszczególne strony dostępne w aplikacji.

Szukaj (Strona główna):
- możliwość zmiany wyglądu komponentu wyszukiwania przy pomocy suwaka,
- możliwość wyszukiwanie słów w bazie słówek poprzez zapytanie do Web API,
- możliwość wyszukiwania słów po warmińsku i polsku.

Pasek na górze wszystkich stron:
- umożliwia logowanie i wylogowywanie się ze strony; wykorzystywany jest Azure Active Directory; logowanie jest konieczne by mieć dostęp do trzech poniższych stron.

Wszystkie słowa:
- tabela ze wszystkim słowami w bazie słów podzielona na strony (10 słów na stronę),
- paginacja – kliknięcie przycisku z numerem strony powoduje wysłanie zapytania do Web API o słówka z danej strony,
- sortowanie na wszystkich kolumnach w sposób alfabetyczny – kliknięcie na górze danej kolumny powoduje wysłanie zapytania do Web API o słówka z danej strony w wybranej kolejności,
- możliwość edycji słowa - po kliknięciu w przycisk Edytuj użytkownik jest przenoszony do strony edycji, gdzie może zmienić zapis słowa po warmińsku i polsku oraz zmienić jaką jest częścią mowy (część mowy wybierane są przez dropdown)
  - zaimplementowana jest walidacja uzupełnianych w formularzu pól – max 16 znaków itd.; w przypadku błędu walidacji zapytanie do API nie zostaje wysłane,
  - kliknięcie Wróć przenosi użytkownika do strony ze wszystkim słowami (wczytując je ponownie),
  - kliknięcie Zapisz, gdy dane przejdą pomyślnie proces walidacji wysyła żądanie edycji słowa do Web API i przenosi użytkownika do strony ze wszystkim słowami (wczytując je ponownie);
- po kliknięciu przycisku Usuń wyskakuje modal (pop-up) z pytanie czy na pewno użytkownik chce usunąć dane słowo,
- kliknięcie przycisku Utwórz nowe słowo – przenosi użytkownika na stronę z formularzem, w którym może uzupełnić odpowiednie pola dotyczące słowa (takie same jak przy edycji),
  - zaimplementowana jest walidacja uzupełnianych w formularzu pól – max 16 znaków itd.; w przypadku błędu walidacji zapytanie do API nie zostaje wysłane,
  - kliknięcie Wróć przenosi użytkownika do strony ze wszystkim słowami (wczytując je ponownie)
  - kliknięcie Zapisz, gdy dane przejdą pomyślnie proces walidacji wysyła żądanie utworzenia słowa do Web API i przenosi użytkownika do strony ze wszystkim słowami (wczytując je ponownie)
- gdy słowo zostanie zedytowane lub powiedzie się jego utworzenie wyświetla się toast ze stosowną informacją (do jego wyświetlenia używany jest krótki kod java scriptowy uruchamiany z poziomu kodu w C#)

Twoje kolekcje słów:
- pokazuje w tabeli wszystkie kolekcje słów utworzonych przez użytkownika,
- użytkownik możne usunąć daną kolekcję – po kliknięciu przycisku Usuń przy danej kolekcji wyświetla się modal (pop-up) z pytaniem czy na pewno użytkownik chce usunąć daną kolekcję,
- kliknięcie przycisku Edytuj przy danej kolekcji, przenosi użytkownika do widoku z fomrumlarzem edycji kolekcji (nie przenosi nas na nową stronę razor),
	- w tym widoku użytkownik może usuwać słowa,
  - dodawać nowe – robi to przez ich wyszukanie w bazie (do dyspozycji ma ten sam komponent wyszukiwania co na stronie głównej), wybranie odpowiedniej pozycji z tabeli wyszukanych tłumaczeń i kliknięcie przycisku Dodaj
  - kliknięcie przycisku Wróć zmienia widok na tabelę kolekcji słów,
  - kliknięcie przycisku Zapisz, gdy dane przejdą pomyślnie proces walidacji wysyła żądanie edycji kolekcji do Web API,
- po kliknięciu przycisku Utwórz nową grupę, otwiera się modal (pop-up), który korzysta z tego samego komponentu z formularzem co w edycji kolekcji słów,
	- w okienku użytkownik może usuwać słowa,
  - dodawać nowe – robi to przez ich wyszukanie w bazie (do dyspozycji ma ten sam komponent wyszukiwania co na stronie głównej), wybranie odpowiedniej pozycji z tabeli wyszukanych tłumaczeń i kliknięcie przycisku Dodaj,
  - kliknięcie przycisku Zamknij zamyka modal,
  - kliknięcie przycisku Utwórz, gdy dane przejdą pomyślnie proces walidacji wysyła żądanie utworzenia kolekcji do Web API,

Użytkownicy (tylko administrator jest autoryzowany by zobaczyć zawartość tej strony):
- pokazuje wszystkich aktywnych użytkowników tj. użytkowników, którzy utworzyli wcześniej kolekcję słów (dopiero w momencie tworzenia kolekcji słów, dane użytkownika są wpisywane do bazy danych)


English version

Frontend for the Warmian-Polish/Polish-Warmian dictionary (Warmian is a subdialect of Polish) written in Blazor WebAssembly and based on Web API from the repository: https://github.com/JakubJT/PolWarmDictionary_Backend.

Technologies and solutions used:
- frontend application in Blazor WebAssembly technology,
- ready-made sets of free components written for Blazor: Mud Blazor and Radzen Blazor,
- components written for applications/pages utilizing HTML and JS: Bootstrap,
- Authentication/Authorization by Azure Active Directory,
- running java script code from the C# code level,
- Dependency Injection,
- error handling by shared Error component,
- Blazor.SessionStorage.WebAssembly library to use session storage,
- localization; english and polish version available.


Pages functionalities

Search (Home page):
- changing the appearance of the search component using the slider,
- searching for words in the vocabulary database by querying the Web API,
- searching for words in Warmian and Polish.

Bar at the top of all pages:
- allows user to log in and out of the website; Azure Active Directory is used; login is required to access the three pages below.

All words:
- a table with all the words in the word database divided into pages (10 words per page),
- pagination - clicking the page number button sends a request to the Web API for words from a given page,
- sorting on all columns in alphabetical and reverse order - clicking on the top of chosen column sends a request to the Web API for words from a given page in the selected order,
- word editing function - after clicking the Edit button, user is taken to the editing page, where she/he can change the spelling of the word in Warmian and Polish and change what part of speech it is (parts of speech are selected using dropdown)
   - validation of fields content is implemented - max 16 characters, etc.; in the case of a validation error, the request to the API is not sent,
   - clicking Back button takes user to the page with all the words (reloading them),
   - clicking Save button when the data was successfully validated sends a request to the Web API to edit the word and takes us to the page with all the words (reloading them);
- after clicking the Delete button, a modal pops up asking if user really wants to delete the word,
- clicking the Create a new word button - takes user to the page with the form in which she/he can complete the appropriate word fields (the same fields as when editing),
   - validation of fields content is implemented - max 16 characters, etc.; in the case of a validation error, the request to the API is not sent,
   - clicking Back button takes user to the page with all the words (reloading them)
   - clicking Save button when the data was successfully validated sends a request to create the word to the Web API and takes user to the page with all the words (reloading them)
- when the word edititng or creation is successful, a toast with suitable information is displayed (a short java script code running from the C# code level is used to display it)

Your word collections:
- shows in the table all collections of words that user created,
- user can delete a chosen collection - after clicking the Delete button next to the chosen collection, a modal (pop-up) is displayed asking if user really wants to delete the collection,
- after clicking Edit button next to a chosen collection, it takes user to the view where she/he can edit the collection (it doesn't take user to a new razor page),
	- in this view user can delete words,
   - add new ones - user can do it by searching for them in the database (using the same search component as on the home page), selecting the appropriate item from the table of found translations and clicking the Add button,
   - clicking the Back button changes the view to the word collection table,
   - clicking Save when the data was successfully validated sends a request to edit the collection to the Web API,
- after clicking the Create a new group button, a modal (pop-up) shows up; modal uses the same component with the form as in the word collection editor,
	- in this window we can delete words,
   - add new ones - user can do it by searching for them in the database (using the same search component as on the home page), selecting the appropriate item from the table of found translations and clicking the Add button,
   - clicking the Close button closes the modal,
   - clicking the Create button when the data was successfully validated sends a request to create the collection to the Web API,

Users (only admin is authorized to see the content of this page):
- shows all active users, i.e. users who have previously created a collection of words (only when creating a collection of words, user data is put into the database)
