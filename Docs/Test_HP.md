## Általános módú tesztelés
 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Új teendő hozzáadása gomb megnyomása, ha üres a cím szövegdoboz | Megjelenik a PopUp Form és kiírja, hogy nem lehet üres a cím mező. |
 | Új teendő hozzáadása gomb megnyomása, ha üres a cím és a leírás szövegdoboza | Megjelenik a PopUp Form és kiírja, hogy nem lehet üres a cím mező. |
 | Új teendő hozzáadása gomb megnyomása, ha nem üres a cím szövegdoboz | Hozzáadja a checkedListBox-hoz a teendőt. | 
 | Új teendő hozzáadása gomb megnyomása, ha nem üres a cím szövegdoboz, a leírásé pedig üres | Hozzáadja a checkedListBox-hoz a teendőt. |
 | Új teendő hozzáadása gomb megnyomása, ha korábbi dátumot adunk meg | Megjelenik a PopUp Form és kiírja, hogy nem lehet korábbi dátumot megadni. |
 | Új teendő hozzáadása gomb megnyomása, ha későbbi dátumot adunk meg | Hozzáadja a checkedListBox-hoz a teendőt. |
 | Szerkesztés gomb megnyomása egy kiválasztott teendőnél | Átírja a checkedListBox-ban lévő teendő címét és/vagy leírását. |
 | Szerkesztés gomb megnyomása kettő vagy annál több kiválasztott teendőnél | Nem írja át a checkedListBox-ban lévő teendő címét és/vagy leírását, a PopUp Form megjelenik és kiírja, hogy nem szerkeszthető egyszerre két teendő. | 
 | Törlés gomb megnyomása egy kiválasztott teendő esetében | Kitörli a checkedListBox-ból az elemet. |
 | Törlés gomb megnyomása kettő vagy annál több teendő esetében | Kitörli a checkedListBox-ból az elemeket. |
 | Mentés gomb megnyomása | Elmenti a teendőket, és kilép a programból. |

 ### Ezeket a teszteseteket végrehajtani a legtöbb kombinációval

Tesztelő: Hegyközi Petra
Tesztelés dátuma: 2023. október. 08 23:40
| Tesztszám | Rövid leírás                     | Várt eredmény                                                                           | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|-----------------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Új teendő hozzáadása gomb megnyomása, ha üres a cím szövegdoboz | Megjelenik a PopUp Form és kiírja, hogy nem lehet üres a cím mező. | Megjelenik a PopUp Form és a várt hibát kiírja. | Nem találtam hibát. |
| Teszt #02 | Új teendő hozzáadása gomb megnyomása, ha üres a cím és a leírás szövegdoboza | Megjelenik a PopUp Form és kiírja, hogy nem lehet üres a cím mező. | Megjelenik a PopUp Form és a várt hibát kiírja. | Nem találtam hibát. |
| Teszt #03 | Új teendő hozzáadása gomb megnyomása, ha nem üres a cím szövegdoboz | Hozzáadja a checkedListBox-hoz a teendőt. | A checkedListBox-ban megjelenik a címmel és leírással ellátott elem. | Nem találtam hibát. |
| Teszt #04 | Új teendő hozzáadása gomb megnyomása, ha nem üres a cím szövegdoboz, a leírásé pedig üres | Hozzáadja a checkedListBox-hoz a teendőt. | A checkedListBox-ban megjelenik a címmel ellátott elem. | Nem találtam hibát. |
| Teszt #05 | Új teendő hozzáadása gomb megnyomása, ha korábbi dátumot adunk meg | Megjelenik a PopUp Form és kiírja, hogy nem lehet korábbi dátumot megadni. | Megjelenik a PopUp Form és a várt hibát kiírja. | Nem találtam hibát. |
| Teszt #06 | Új teendő hozzáadása gomb megnyomása, ha későbbi dátumot adunk meg | Hozzáadja a checkedListBox-hoz a teendőt. | Hozzáadja a checkedListBox-hoz a teendőt. | Nem találtam hibát. |
| Teszt #07 | Szerkesztés gomb megnyomása egy kiválasztott teendőnél | Átírja a checkedListBox-ban lévő teendő címét és/vagy leírását. | A checkedListBox-ban lévő kiválasztott elem módosításra kerül. | Nem találtam hibát. |
| Teszt #08 | Szerkesztés gomb megnyomása kettő vagy annál több kiválasztott teendőnél | Nem írja át a checkedListBox-ban lévő teendő címét és/vagy leírását, a PopUp Form megjelenik és kiírja, hogy nem szerkeszthető egyszerre két teendő. | A checkedListBox-ban lévő kiválasztott elem nem kerül módosításra. | Nem találtam hibát. |
| Teszt #09 | Törlés gomb megnyomása egy kiválasztott teendő esetében | Kitörli a checkedListBox-ból az elemet. | A checkedListBox-ban lévő kiválasztott elemet eltávolítja. | Nem találtam hibát. |
| Teszt #10 | Törlés gomb megnyomása kettő vagy annál több teendő esetében | Kitörli a checkedListBox-ból az elemet. | A checkedListBox-ban lévő kiválasztott elemeket eltávolítja. | Nem találtam hibát. |
| Teszt #11 | Mentés gomb megnyomása | Elmenti a teendőket, és kilép a programból. Ha ismét elindítjuk a programot, akkor a listában szerepelnek a korábban megadott teendők. | A teendők mentésre kerültek, utána pedig kilép a programból. | Nem találtam hibát. |