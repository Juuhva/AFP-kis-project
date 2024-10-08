# Funkcionális Specifikáció
## 1. Jelenlegi helyzet

Jelenleg a Google nem rendelkezik To Do List-tel, így a felhasználók nem tudják követni mindennapi teendőiket. Ezért szeretnénk megkönnyíteni egy egyszerű szoftver segítségével, hogy a felhasználók rendszerezetten és egy helyen láthassák a fontos dolgaikat, teendőiket akár naptárban is.

## 2. Vágyálom rendszer

A projektünk célja, hogy egy könnyen használható és optimális To Do Listet hozzunk létre felhasználóink számára. A programnak egyszerűnek és könnyen átláthatónak kell lennie. Az alkalmazás funkciói: naptár, listák, emlékeztetők.

## 3. Jelenlegi üzleti folyamatok modellje

Jelenleg a felhasználók a régi Google Calendar-t használják, amiben a teendőiket gyakran nem látják át és rendszertelenül jelenik meg.

## 4. Igényelt üzleti folyamatok modellje

Egy olyan szoftver, amely alkalmas arra, hogy a korábban megszokott Google funkciókat együttesen lehessen alkalmazni az új alkalmazással, például a naptárt.

A To Do List nem sokban különbözik az alapmodelltől, tartalmazza:

- Naptár
- List (pl: bevásárlólista, napi rutin pontokba szedése)
- Reminder (pl: jelzik a felhasználónak, ha az általa megadott időpont nemsokára elérkezik)

## 5. Követelménylista

| ID | Név | Kifejtés |
| :---: | --- | --- |
| K1 | Cím | Tetszőleges cím ami jellemzi a teendőt|
| K2 | Leírás | Adott teendő elkészítése |
| K3 | Új | Létrehozhatnak egy új teendőt|
| K4 |Szerkesztés | Tudják szerkeszteni a kiválasztott teendőt|
| K5 | Törlés | Törölni tudják a teendőt|
| K6 | Mentés | Menteni tudják a teendőt|
| K7 | Tábla a felvett teendővel | Teendőinket itt látjuk amiket felvettünk |

## 6. Használati esetek

A felhasználó az alkalmazásban gombok segítségével ki tudja választani, hogy milyen műveletet szeretne elvégezni a már meglévő, illetve az új teendőivel. A program eltárolja a címmel és leírással ellátott teendőket, amit a felhasználó tud szerkeszteni, majd elmenteni a változtatásokat, illetve törölheti azt. Ha elvégzésre került egy teendő, akkor egy pipával jelezhető annak állapota.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

|ID|Leírás           |
|-------------------------|---------------------------|
|K1|A felhasználó megadja a teendőjének a címét.|          
|K2|A felhasználó megadja a teendőjének a leírását.|
|K3|A felhasználó az új gomb megnyomásával felveszi a kívánt teendőjét.|
|K4|A felhasználó egyik előző teendőjét tudja szerkeszteni.|
|K5|A felhasználó tudja törlni egyik előző teendőjét.|
|K6|A felhasználó mentheti a szerkesztett illetve a létrehozni kívánt teendőjét.|
|K7|A felhasználó megnézheti eddigi felvett teendőit.|


## 8. Képernyőtervek

### Korai Látványterv

![korai_látványterv](../Docs/Img/TODOLIST.png)

### Korai Prototípus

![prototípus](../Docs/Img/TODOLISTBeta.png)

## 9. Forgatókönyvek

A program elindítása után minden felhasználónak a főablak jelenik meg, melyben a következők jelennek meg:

    Feladatlista megjelenítésére szolgáló szövegdoboz
    Felhasználó által hozzáadható új feladat gombjai
        Új feladat hozzáadása szövegmezőbe
        Hozzáadás gomb
    Feladatok kezelése gombokkal:
        Feladat megjelölése elvégzettként
        Feladat szerkesztése
        Feladat törlése

A szövegdobozban jelenik meg:

    A felhasználó által megadott feladatok listája

A felhasználó új feladatot tud hozzáadni a megfelelő mezőbe beírva, majd a Hozzáadás gomb megnyomásával a feladat bekerül a listába. Minden új feladat a listában jelenik meg, ahol a feladatokat kategóriákba is lehet sorolni.
A feladatok kezelése:

    Ha egy feladatot elvégzettnek jelöl, akkor az törlődik.
    Ha egy feladatot szerkeszteni szeretne, akkor a szerkesztés gombra kattintva módosíthatja annak szövegét vagy kategóriáját.
    Ha a felhasználó törölni szeretne egy feladatot, a Törlés gomb segítségével véglegesen eltávolíthatja azt a listából.

Különleges funkciók:

    Ha a felhasználó hibásan adott meg egy feladatot, és törölni szeretné, akkor a Törlés gombbal tudja megtenni.


Egyéb műveletek:

    Ha a felhasználó hibásan írt be egy feladatot, és azt kijavítani szeretné, a szerkesztés gombbal tudja megtenni.

## 10. Funkció - követelmény megfeleltetése

Id|Követelmény|Funkció|
| :---: | --- | --- |
K1|Hibamentes működés, letisztult megjelenítés|	Egy felhasználó által megadott új feladat hozzáadása a listához a „Hozzáadás” gomb megnyomása után.
K2|Hibamentes működés, letisztult megjelenítés|	Egy meglévő feladat módosítása. A „Szerkesztés” gomb megnyomása után a felhasználó módosíthatja a kiválasztott feladatot, ami frissítve jelenik meg a listában.
K3|Hibamentes működés, letisztult megjelenítés|	Egy meglévő feladat törlése a listából a „Törlés” gomb megnyomása után.
K4|Precíz, hibamentes működés, letisztult megjelenítés|	A törlés gomb eltávolít egy adott feladatot a listából, ha van kiválasztott feladat. Üres lista esetén a gomb megnyomása nem változtat semmin.
K5|Gyors eredménymegadás, pontosság, kiszámíthatóság|	A felhasználó által végrehajtott műveletek (hozzáadás, szerkesztés, törlés) után a frissített lista helyesen és azonnal megjelenik a felületen. Ha nincs aktív feladat, a műveletek nem változtatnak semmin.

## 11. Fogalomszótár



### Fogalomszótár

* To Do List: Teendőlista, olyan felület, ahol a felhasználók listázhatják és rendszerezhetik a teendőiket.
* Reminder: Emlékeztető, amely figyelmezteti a felhasználót egy előre meghatározott esemény időpontjára.
* Google Calendar: A Google naptárszolgáltatása, amely lehetőséget biztosít események és találkozók időzítésére.
* List: Lista, amely különböző teendőket vagy elemeket tartalmazhat, például bevásárlólistát vagy napi rutinokat.
* Prototípus: Az alkalmazás egy kezdeti, még fejlesztés alatt álló verziója, amely bemutatja az alapvető funkciókat.
