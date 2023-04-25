CREATE TABLE public.talabalar
(
    id serial PRIMARY KEY,
    FIO character varying NOT NULL,
    guruh int NOT NULL
);
INSERT INTO talabalar (fio, guruh) VALUES ('Abdirimov Baxodir', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Abdrimova Muxlisa', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Bahromova Xurshida', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Boltaboyeva Surayyo', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Haytboyeva Mehriniso', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Ismailjonov Bahodirjon', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Ismoilov Nodirbek', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Jaloladdinov Fazliddin', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Jumanazarov Ruslanbek', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Kadambayev Yunus', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Kanjaboyeva Shakarjon', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Karimova Yulduzxon', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Mamatkarimov Ibrohim', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Masharipov Mirjalol', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Matsalayev Azizbek', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Narbayev Norboy', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Qazaqov Sherzod', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Quryozov Jaloladdin', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Safarboyeva Nazokat', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Salayeva Gulshanoy', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Sapayeva Feruza', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Shavkatov Shohjahon', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Shomurotov Shahzod', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Siddiqov Habibullo', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Xolmatova Gulmira', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Yangiboyev Asadbek', 211);
INSERT INTO talabalar (fio, guruh) VALUES ('Allaberganova Ulfatoy', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Imomaddinov Ozodbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Isayev Hosilbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Ismoilov Tolibjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Jaxongirboyev G`ulomjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Jumaboyev Sobirjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Jumaniyozova Hulkarxon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Madrimov Mansurbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Matnazarova Sarvinoz', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Matyoqubova Rozigul', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Nurillayev Jumaboy', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Ollaberganova Zaynabbegim', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Omonboyeva Iroda', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Qurbanbayev Tolibjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Sobirov Gulomjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Saparbayeva Mohinur', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Shonazarov Farruxbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Sobirov Oxunjon', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Sultanbayev Sarvarbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Sultonov Daston', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Xudayberganov Sherifboy', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Yangiboyev Izzatbek', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Yuldashev Davlat', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('Yuldasheva Aziza', 212);
INSERT INTO talabalar (fio, guruh) VALUES ('G`aybullayeva Nafisa', 212);
CREATE TABLE public.fanlar
(
    id serial PRIMARY KEY,
    nomi character varying NOT NULL
);
INSERT INTO fanlar (nomi) VALUES ('Falsafa (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Algoritmik tillar va dasturlash (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Algoritmlar va berilganlar strukturasi (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Berilganlar bazasi (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Sonli usullar (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Sun`iy intellekt va neyronto`rli texnologiyalar (Ma`ruza)');
INSERT INTO fanlar (nomi) VALUES ('Axborot soati (Semenar)');
INSERT INTO fanlar (nomi) VALUES ('Algoritmik tillar va dasturlash (Amaliyot)');
INSERT INTO fanlar (nomi) VALUES ('Algoritmlar va berilganlar strukturasi (Amaliyot)');
INSERT INTO fanlar (nomi) VALUES ('Berilganlar bazasi (Amaliyot)');
INSERT INTO fanlar (nomi) VALUES ('Sonli usullar (Amaliyot)');
INSERT INTO fanlar (nomi) VALUES ('Sun`iy intellekt va neyronto`rli texnologiyalar (Amaliyot)'); 
CREATE TABLE public.davomat
(
    id serial PRIMARY KEY,
    talaba_id serial NOT NULL,
	fan_id serial NOT NULL,
	davomat bool NOT NULL,
    sana date not null
);
create table dars_jadvali(
    id serial primary key,
    guruh int not null,
    hafta_kuni int not null,
    fan_id int not null
);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 1, 10);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 1, 5);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 2, 1);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 2, 7);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 2, 12);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 3, 11);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 3, 4);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 4, 6);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 4, 8);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 5, 12);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 5, 3);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 6, 3);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(211, 6, 2);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 1, 11);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 1, 5);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 2, 1);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 2, 12);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 3, 10);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 3, 4);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 4, 6);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 4, 12);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 5, 7);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 5, 3);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 5, 9);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 6, 8);
insert into dars_jadvali(guruh, hafta_kuni, fan_id) values(212, 6, 2);