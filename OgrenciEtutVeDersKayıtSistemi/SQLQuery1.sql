select ID,DERSAD as 'DERS ADI',(TBLOGRETMEN.AD+' '+TBLOGRETMEN.SOYAD) as '??RETMEN',
(TBLOGRENCI.AD+' '+TBLOGRENCI.SOYAD) as '??RENC?',TARIH,SAAT,DURUM from TBLETUT inner join TBLDERSLER
on
TBLETUT.DERSID=TBLDERSLER.DERSID inner join TBLOGRETMEN
	on
TBLETUT.OGRETMENID=TBLOGRETMEN.OGRTID inner join TBLOGRENCI
on 
TBLETUT.OGRENCIID=TBLOGRENCI.OGRID