## LS02 - Steuerelemente und Wertzuweisungen
- LS02-1 wurde übersprungen bzw. nur kurz behandelt, wir sind mit LS02-2 (Intranet) gestartet.
- Aufgabenstellung in: [./LS2-2_Übung_Intranet.pdf](https://github.com/bsiii-dummy/kkreibic-awp/blob/main/LS02_Steuerelemente_und_Wertzuweisungen/LS2-2_%C3%9Cbung_Intranet.pdf)

Lösung im ls2-intranet Ordner. Datenstand nicht aktuell, muss die aktuellste Version noch vom Schul-PC laden.

Aufgrund von Langeweile habe ich mit meiner Lösung evtl. etwas übertrieben ;-)

Der Authentifizierungs-Server ist laut Aufgabenstellung nicht erforderlich, aber ein schönes Gimmick. Die Nutzer werden via Post-Request an die API hinzugefügt, eine Anmeldung dafür braucht es nicht.
Unter /api/User/ gibts es dafür auch alle Nutzer inklusive Pin. Bei diesem Level von Sicherheit machen wir uns natürlich nicht die Mühe von Hashing, denn mit einer PUT-Request an /api/User/{id} kann man natürlich jederzeit ALLE Daten (inklusive Nutzer-Id) ändern.

Es ist eine Spielerei um Verschiedene Technologien kennenzulernen und nicht, um etwas für eine Production-Umgebung zu schaffen.

Ich finde Entwicklung in C# ja schrecklich, aber ich habe noch nie so schnell eine API gebaut wie damit. Deswegen tut mir trotzdem jeder leid, der das regelmäßig Nutzen muss.

Alle mitgelieferten Resourcen befinden sich in diesem Ordner.
