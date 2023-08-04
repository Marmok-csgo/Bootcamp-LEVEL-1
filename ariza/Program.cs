string application = "{ApplicationDate} {ApplicationNumber} {OrganizationName} rektori " +
    "{Rektor}ga Abituriyent {StudentName} danTel.: {StudentNumber}ARIZAMen joriy yilda " +
    "{OrganizationName}ning {Code}- {EduSpeciality}ta 'lim yo'nalishini {EduForm}ta 'lim" +
    " shakli, {EduLanguage} ta'lim tili bo'yicha {OrderId} - OTM sifatida tanlab, davlat test" +
    " sinovida ishtirok etdim.Davlat test markazi tomonidan e'lon qilingan test natijasiga ko'ra" +
    " {Ball} ball to'pladim va to'lov-kontrakt asosidagi qabul chegarasiga {DifferenceBall} ball" +
    " yetmay qoldi .Shu munosabat bilan, meni qo'shimcha tarzda {EduContractSumType} tabaqalashtirilgan" +
    " to'lov-kontrakt asosida talabalikka qabul qilishingizni hamda menga to`lov shartnomasini taqdim" +
    " etishingizni so'rayman.Men Oliy ta'lim muassasasining ichki tartib qoidalari va kontraktni " +
    "barcha shartlari bilan tanishib chiqdim hamda tasdiqlangan o'quv rejasi bo'yicha belgilangan " +
    "vaqtlarda darslarga qatnashishga, belgilangan muddatlarda to'lov-kontrakt pulini to'lashga va " +
    "to'lov hujjatlarini topshirishga shaxsan o`zim mas'ulligimni tasdiqlayman.Abituriyent:" +
    " {Abiturient}ID raqami: {AbiturientId}";

var date = DateTime.Now;
var changedInfo = application.Replace("{ApplicationDate}", $"{date}")
    .Replace("{ApplicationNumber}", $"{Guid.NewGuid()}")
    .Replace("{OrganizationName}", "Najot Ta'lim")
    .Replace("{Rektor}", "Temurbek Adhamov")
    .Replace("{StudentName}", "Tolibov Firdavs")
    .Replace("{StudentNumber}", "9000860814")
    .Replace("{Code}", "N10")
    .Replace("{EduSpeciality}", "Dotnet Backend")
    .Replace("{EduForm}", "offline")
    .Replace("{EduLanguage}", "uzbek")
    .Replace("{OrderId}", "8832")
    .Replace("{Ball}", "83")
    .Replace("{DifferenceBall}", "13")
    .Replace("{EduContractSumType}", "2000")
    .Replace("{Abiturient}", "Tolibov Firdavs")
    .Replace("{AbiturientId}", "8832");

Console.WriteLine(changedInfo);




