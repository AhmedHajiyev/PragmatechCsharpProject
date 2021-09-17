## 10 HTTP Request metodu var:
<br>
<ul>
 <li>GET</li>
 <li>POST</li>
 <li>PUT</li>
 <li>HEAD</li>
 <li>DELETE</li>
 <li>CONNECT</li>
 <li>OPTIONS</li>
 <li>TRACE</li>
 <li>PATCH</li>
 <li>SEARCH</li>
</ul>
<hr>

## GET
Bu metodda serverdən məlumat almaq üçün istifadə olunur. GET metoduyla requestlər URL daxilində göndərilə bilir.
Bunun ən vacib faydası clientin bookmark edəbilməsi və eyni sorgunu içərən requestləri daha sonra göndərə bilmələrini təmin etməsi
ve brauzerdə əvvəlki requestlərin “backspace” ilə və yaxud brauzerin tarixçəsindən həmin səhifələr çata bilməsidir.
Lakin təhlükəsizlik baxımından parametrlərin URL daxilində göstərilməsi doğru deyil.
Buna görə təhlükəsizlik lazım olan requestlər GET metodu ilə göndərilməməlidir.

## POST
POST metoduyla serverə data yazdırmaq mümkündür. Bu metodla istənilən parametrləri həm URL daxilində, həm də mesaj bölməsində göndərilə bilər.
Brauzerlərdə geri butonuna basıldığında POST istəyinin mesaj bölməsində yer alan parametrləri təkrar göndərmək istəyib istəmədiyimizi soruşar.
Bunun təməl səbəbi bir funksiyanı səhvən təkrarın qarşısını almaqdır. 

## PUT
Bu metodla servis təminatçınızdakı bir mənbəni yeniləyə bilərsiniz. Yeniləyəcəyiniz mənbənin İD'sini göndərmək məcburidir.

## HEAD
GET metoduyla oxşar funksiyalara sahibdir, ancaq mesaj bölməsi olmaz.

## DELETE
Bu metodla serverdeki hər hansı datanı silmək mümkündür.

## CONNECT
Bir proxy server vasitəsilə başqa bir serverə qoşulmaq və proxy serverdən tunel kimi istifadə etmək üçün istifadə olunur.

## OPTİONS
Bu üsul müəyyən bir qaynaq üçün istifadə edilə bilən HTTP üsulları üçün serverə request göndərmək üçün istifadə olunur.

## TRACE
Diaqnoz məqsədli metoddur.Bu üsulla server sorğu mesajının məzmununu cavab bölməsinə qaytarmalıdır.

## PATCH
Bu metod bir qaynağa istədiyiniz dəyişikliyi etməyə imkan yaradır.

## SEARCH
Bir sıranın daxilindəki qaynaqları sorğulamaq üçün istifadə olunur.
