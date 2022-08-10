create database ZMD_EMLAK;
Use ZMD_EMLAK;
create table kullanicilar(
ad nvarchar(50),
soyad nvarchar(50),
tel_no nvarchar(11),
tc_kimlik nvarchar(11),
e_posta nvarchar(50),
kul_no nvarchar(50),
konut_no nvarchar(50),
);
create table filtrele
(
id int,
fiyat int,
metrekare int,
emlakTipi nvarchar(50),
isitma nvarchar,
satilik nvarchar(50),
kiralik nvarchar(50)

);

create table evOzellikleri(
ilan_no int,
fiyat int,
emlak_tipi nvarchar(50),
metrekare int,
oda_salon  nvarchar(50),
dask  nvarchar(50),
il  nvarchar(50),
ilce  nvarchar(50),
adres  nvarchar(200),
emlak_sahibi int,
aidat int,
banyo  nvarchar(50),
binadaki_kat  nvarchar(50),
bina_yasi  nvarchar(50),
bulundugu_kat  nvarchar(50),
kullaným_durumu nvarchar(50),
tapu_durumu nvarchar(50),
balkon_sayisi nvarchar(50),
isitma  nvarchar(50),
aciklama nvarchar(50),

);
