# APBD - GitHub

## 1. Kiedy Git robi fast-forward, a kiedy powstaje merge commit?

Fast-forward jest wtedy, kiedy na gałęzi, do której mergujemy, nie było żadnych nowych commitów. Wtedy Git po prostu przesuwa wskaźnik gałęzi do przodu i nie tworzy nowego commita.

Merge commit powstaje wtedy, kiedy obie gałęzie mają już swoje własne commity i historia się rozdzieliła. W takiej sytuacji Git musi zrobić dodatkowy commit, który połączy te dwie gałęzie.

## 2. Czym w praktyce różni się merge od rebase?

Merge po prostu łączy dwie gałęzie i zostawia informację, że historia była rozdzielona. Dzięki temu widać cały przebieg pracy, ale historia jest mniej czytelna.

Rebase działa trochę inaczej, bo przenosi commity jednej gałęzi na koniec drugiej. Przez to historia wygląda bardziej liniowo i jest uporządkowana.

## 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt zrobił się dlatego, że na gałęzi main i na gałęzi feature-conflict została zmieniona ta sama linia w pliku Program.cs, ale na różne sposoby.

Po próbie merge Git pokazał konflikt w pliku. Rozwiązanie polegało na tym, że ręcznie edytowałem Program.cs, usunąłem znaczniki konfliktu i zostawiłem jedną wspólną wersję komunikatu.

Potem zrobiłem git add Program.cs i commit.