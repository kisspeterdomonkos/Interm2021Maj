-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:
CREATE DATABASE halozat DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

-- 12. feladat:
INSERT INTO `megallok`(`id`, `nev`) VALUES ('198','Kőbányai garázs');

-- 13. feladat:
UPDATE `jaratok` SET `elsoAjtos` = '0' WHERE `jaratok`.`id` = 20;

-- 14. feladat:
SELECT jaratSzam FROM jaratok WHERE elsoAjtos = 1;

-- 15. feladat:
SELECT nev FROM megallok WHERE nev LIKE('%sétány') ORDER BY nev ASC;

-- 16. feladat:
SELECT halozat.sorszam, megallok.nev AS 'megallo' FROM jaratok INNER JOIN halozat ON halozat.jarat = jaratok.id INNER JOIN megallok ON halozat.megallo = megallok.id WHERE jaratok.jaratSzam LIKE('CITY') AND halozat.irany LIKE 'A' ORDER BY halozat.sorszam ASC;

-- 17. feladat:
SELECT megallok.nev AS 'megallo', COUNT(jaratok.id) AS 'jaratokSzama' FROM jaratok INNER JOIN halozat ON halozat.jarat = jaratok.id INNER JOIN megallok ON halozat.megallo = megallok.id GROUP BY megallok.nev ASC HAVING COUNT(jaratok.id)>2;


