Funktionalität: Lebowski special
Der Dude braucht ein Programm, welches auf Basis einer gegebenen Wurfreihe den Endstand für einen Bowling-Spieler berechnet. 
Zu grunde gelegt sind die Regeln für das Standard American Ten-Pin Bowling.

The dude abides:
    
-	Jeder Spieler spielt 10 Durchgeänge
-   In jedem Durchgang hat er maximal 2 Versuche alle Pins abzuräumen.
-   Wenn er es mit zwei Würfen nicht schafft, wird ihm für diesen Durchgang die Summe der geworfenen Pins angeschrieben.
-   Wenn er mit zwei Würfen alle 10 Pins abräumt, dann nennt man das "Spare" und
	für diesen Durchgang wird 10 PLUS dem Ergebnis des ersten Wurfs des nächsten Durchgangs angerechnet.
-   Wenn der Spieler mit dem ersten Wurf eines Durchgangs alle 10 Pins abräumt, nennt man dies einen "Strike". 
	Der Durchgang ist beendet und er bekommt 10 PLUS dem Ergebnis der nächsten beiden Würfe angeschrieben.
-   Wirft der Spieler im letzten Durchgang einen Strike, so bekommt er noch 2 Nach-Würfe die dazugerechnet werden.
-   Wirft der Spieler im letzten Durchgang einen Spare, so bekommt er noch einen Nachwurf, der dazugerechnet wird.
-   Der Endstand ist die Summe der 10. Durchgänge

The dude doesn't abide:

    Es prüft nicht auf gültige Würfe
    Es prüft nicht auf die korrekte Anzahl von Würfen und Durchgängen
    Es gibt keine Zwischenstände heraus

Szenario: Gutterball
Gegeben sei ein Spieler wirft folgende Würfe
| Nummer | Punkte |
| 1      | -      |
| 2      | -      |
| 3      | -      |
| 4      | -      |
| 5      | -      |
| 6      | -      |
| 7      | -      |
| 8      | -      |
| 9      | -      |
| 10     | -      |
| 11     | -      |
| 12     | -      |
| 13     | -      |
| 14     | -      |
| 15     | -      |
| 16     | -      |
| 17     | -      |
| 18     | -      |
| 19     | -      |
| 20     | -      |
Wenn das Programm die Ausgabe berechnet
Dann soll folgendes Ergebnis herauskommen
| Frame | Punkte |
| 1     | 0      |
| 2     | 0      |
| 3     | 0      |
| 4     | 0      |
| 5     | 0      |
| 6     | 0      |
| 7     | 0      |
| 8     | 0      |
| 9     | 0      |
| 10    | 0      |

Szenario: Just lets go bowling
Gegeben sei ein Spieler wirft folgende Würfe
| Nummer | Punkte |
| 1      | 1      |
| 2      | 2      |
| 3      | 3      |
| 4      | 4      |
| 5      | 5      |
| 6      | 1      |
| 7      | 2      |
| 8      | 3      |
| 9      | 4      |
| 10     | 5      |
| 11     | 1      |
| 12     | 2      |
| 13     | 3      |
| 14     | 4      |
| 15     | 5      |
| 16     | 1      |
| 17     | 2      |
| 18     | 3      |
| 19     | 4      |
| 20     | 5      |
Wenn das Programm die Ausgabe berechnet
Dann soll folgendes Ergebnis herauskommen
| Frame | Punkte |
| 1     | 3      |
| 2     | 7      |
| 3     | 6      |
| 4     | 5      |
| 5     | 9      |
| 6     | 3      |
| 7     | 7      |
| 8     | 6      |
| 9     | 5      |
| 10    | 9      |

Szenario: The rug
Gegeben sei ein Spieler wirft folgende Würfe
| Nummer | Punkte |
| 1      | 9      |
| 2      | -      |
| 3      | 9      |
| 4      | -      |
| 5      | 9      |
| 6      | -      |
| 7      | 9      |
| 8      | -      |
| 9      | 9      |
| 10     | -      |
| 11     | 9      |
| 12     | -      |
| 13     | 9      |
| 14     | -      |
| 15     | 9      |
| 16     | -      |
| 17     | 9      |
| 18     | -      |
| 19     | 9      |
| 20     | -      |
Wenn das Programm die Ausgabe berechnet
Dann soll folgendes Ergebnis herauskommen
| Frame | Punkte |
| 1     | 9      |
| 2     | 9      |
| 3     | 9      |
| 4     | 9      |
| 5     | 9      |
| 6     | 9      |
| 7     | 9      |
| 8     | 9      |
| 9     | 9      |
| 10    | 9      |

Szenario: League play
Gegeben sei ein Spieler wirft folgende Würfe
| Nummer | Punkte |
| 1      | 5      |
| 2      | /      |
| 3      | 5      |
| 4      | /      |
| 5      | 5      |
| 6      | /      |
| 7      | 5      |
| 8      | /      |
| 9      | 5      |
| 10     | /      |
| 11     | 5      |
| 12     | /      |
| 13     | 5      |
| 14     | /      |
| 15     | 5      |
| 16     | /      |
| 17     | 5      |
| 18     | /      |
| 19     | 5      |
| 20     | /      |
| 21     | 5      |
Wenn das Programm die Ausgabe berechnet
Dann soll folgendes Ergebnis herauskommen
| Frame | Punkte |
| 1     | 15     |
| 2     | 15     |
| 3     | 15     |
| 4     | 15     |
| 5     | 15     |
| 6     | 15     |
| 7     | 15     |
| 8     | 15     |
| 9     | 15     |
| 10    | 15     |
| 11    | 5     |

Szenario: The Creedance
Gegeben sei ein Spieler wirft folgende Würfe
| Nummer | Punkte |
| 1      | x      |
| 2      | -      |
| 3      | x      |
| 4      | -      |
| 5      | x      |
| 6      | -      |
| 7      | x      |
| 8      | -      |
| 9      | x      |
| 10     | -      |
| 11     | x      |
| 12     | -      |
| 13     | x      |
| 14     | -      |
| 15     | x      |
| 16     | -      |
| 17     | x      |
| 18     | -      |
| 19     | x      |
| 20     | -      |
| 21     | x      |
| 22     | x      |
Wenn das Programm die Ausgabe berechnet
Dann soll folgendes Ergebnis herauskommen
| Frame | Punkte |
| 1     | 30     |
| 2     | 30     |
| 3     | 30     |
| 4     | 30     |
| 5     | 30     |
| 6     | 30     |
| 7     | 30     |
| 8     | 30     |
| 9     | 30     |
| 10    | 30     |
| 11    | 10     |
| 12    | 10     |

