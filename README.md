# Emelésérzékelő készítése

Készítsen kiegészítő hardver egységet az STM32 NUCLEO-F446RE kithez. Az elkészült kártya tartalmazzon egy
gyorsulásérzékelőt és 2 db 7 szegmenses kijelzőt annak kijelzésére, hogy a kártyát képzeletben kettéosztó tengely
a vízszintes síkkal mekkora szöget zár be (5 fok pontossággal). Az asztalon fekvő egység 0 fok, függőlegesre
felállított kártya esetén 90 fok jelenjen meg a kijelzőn. A kijelzés „igazodjon” a leolvasás lehetőségéhez (ne kelljen
fejre állnunk a leolvasáshoz), tehát a kijelzőknek mindig a magasabban elhelyezkedő éle legyen a képzeletbeli
„teteje”, a kijelzés ennek megfelelően „irányhelyesen” jelenjen meg! Helyezzen el továbbá 2 nyomógombot is,
valamint egy buzzert. Nyomógombok segítségével egy kritikus szög legyen beállítható, amelyet elérve a
felhasználót a buzzer segítségével hangjelzéssel figyelmezteti. Ne feledkezzen el a gombok (szoftveres)
pergésmentesítéséről!

A kijelzők vezérlése is a mikrokontroller SPI portján keresztül történjen (sorosan), egy léptető regiszter
alkalmazásával.

Az áramkör megtervezése, megépítése és üzembe helyezése után készítsen el egy, az eszköz bemutatására
szolgáló demonstrációs célú tesztprogram rendszert, amely magában foglalja a megfelelő működést biztosító
mikrokontrolleres programot, illetve egy PC-s kliensprogramot. A mikrokontroller és a PC közötti kommunikációt
virtuális UART kommunikációval valósítsa meg USB-n keresztül.

**<ins>Ajánlott alkatrésztípusok:</ins>**

• Gyorsulásérzékelő modul: STEVAL-MKI178V2 (ST, tanszéki forrásból)

• 7 szegmenses kijelző: FYS-3911BUHR-21 (Lomex 35-03-94)

• Léptető regiszter: STP08CP05TTR (ST, tanszéki forrásból)

• Nyomógomb: FSM4JSMA (Lomex 45-05-43, Farnell 3801305)



## Hardver tervek
![image](https://github.com/bnyitrai03/Tilt_detector/assets/126956031/1c6b67fa-e40d-46f7-a7b0-b9aaf6ccb050)

![image](https://github.com/bnyitrai03/Tilt_detector/assets/126956031/81d32335-cc66-4527-816f-2e3c9c7b56c2)

