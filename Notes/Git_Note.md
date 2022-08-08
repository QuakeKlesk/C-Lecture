# Git commands
* git config --global user.name
* git config --global user.email

* git --version                   - Проверка гита
* git init                        - Создание репозитория
* git status                      - Отслеживаемые файлы
* git add [tub]                   - Добавление файла к отслеживаемым, если поставить * все файлы реп. будут добавлены.
* git commit -m "name"            - Зафиксировать состояние, присвоить 
* git commit -a                 КАК?????????????
* git log                         - журнал фиксаций
* git checkout "commit's HashCode"- Перейти к комиту
* git checkout master             - перейти к ветке мастер
* git checkout "enter branch"     - перейти к ветке (указать имя)
* git diff                        - разница версий
* git branch                      - Текущая ветка среди остальных
* git branch "branch name"        - создание ветки
* clear                           - очистка терминала
* git merge "branch name"         - объединение двух веток
# Lesson_2
* git branch -d "name branch"     - удаление ветки(Можно через большую D)
* git log --graph                 - Графическое изображение веток и коммитов
* .gitignore                      - обязательно строгое название файла для игнорирования. после создания его необходимо добавить и закоммитить. 
# Lesson_3
* cd reposetory name               - chenge directory 
* git clone "link"
* git remote
* git push origin main
* git pull

# Lern git branching

* git reset --hard "hash code"    - откат к указанному коммиту с __*удалением*__ предыдущих.
*  git checkout -b "branch name"  - создать и перейти на ветку.
* git rebase "branch name"        - поменять родителя ветки на другую ветку. 
* git checkout master^            - оператор коретки (^) позволяет переместиться на один коммитвыше, (^^) на 2 коммита и т.д.
* git checkout HEAD~ "число"      - перемещение на (число) коммитов назад. 
* git branch -f main HEAD~3       - переместит ветку main принудительно (forcibly) на три родителя назад от HEAD.
* git reset HEAD~1                - переносит ссылку на 1 коммит назад от HEAD.(для локалки)
* git revert HEAD                 - отматывает на один коммит назад при этом не теряя последних изменений. (для удаленных репозиториев).

# C#
* dotnet new console              - создание проекта
* dotnet run                      - запустить проект

