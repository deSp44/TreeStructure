# TreeStructure

1. Założenia co do technologii:
- baza danych MSSQL / MySQL / PostgreSQL,
- ASP.NET / MVC / .NET Core,
- HTML 5, CSS 3. 
2. Założenia dotyczące realizacja zadania:
- struktura drzewiasta ma umożliwiać działanie na dowolnej ilości poziomów,
- funkcje jakie mają być dostępne dla administratora: dodawanie, edycja, usuwania, sortowanie (zarówno węzłów jak i liści), przenoszenie węzłów do innych gałęzi,
- powinna być możliwość rozwinięcia całej struktury lub wybranych węzłów,
- powinny zostać zastosowane zabezpieczenia uniemożliwiające wprowadzanie nieprawidłowych danych,
- wskazane zastosowanie skryptów client-side (własnych, nie gotowych rozwiązań jak np. jsTree)
- preferowana implementacja algorytmu rekurencyjnego,
- preferowana wykorzystanie vue zamiast jquery,
- obsługa formularzy powinna zawierać klasę do generowania formularzy wraz z wizualizacją, walidacją oraz zabezpieczeniami.

## RELEVANT INFORMATION
Technologies and practices used
- ASP.NET MVC
- .NET Core
- Entity Framework Core
- MSSQL
- Vue.js
- onion architecture

To create a database, install SQL Server Express and execute the Update-Database command in Package Manager Console.

To change the node of an element, first select the element and press "Change node of current selected", then select the destination and press "Apply new selected node"
