# WorkDemoForm

## Popis
Vytvořit webový formulář pro zadání kontaktních údajů s následným uložením do databáze a
exportem do jsonu.
Obsah formuláře:

- Jméno a příjmení (povinné)
- Rodné číslo (povinné), možnost checkboxu nemám rodné číslo, čímž se znepovinní
pole
- Datum narození (předvyplněno z rodného čísla, pokud je vyplněno) povinné pole
- Pohlaví (combo) povinné pole
- Email (validace struktury) povinné pole
- Státní příslušnost (combo) povinné pole
- Souhlas s GDPR (checkbox), odkaz PDF na nové kartě (může být prázdné jen pro test)
povinné pole
- Tlačítko na odeslání

## Funkcionalita formuláře
- Předvyplnění datumu narození po vyplnění rodného čísla
- Možnost přepnutí jazyka (en a cz)
- Po uložení zaznamenat data v db a vygenerovat json s daty z formuláře

## Technologie
- Využít .NET 8/9
- Databáze MSSQL
- Na frontendu libovolná webová technologie

## Výstup
- Poslat .Sln projektu bez obj a bin složek
- Poslat skript na vytvoření struktury DB
