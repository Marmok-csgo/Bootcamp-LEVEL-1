using N17_T1;

class Program
{
    static void Main(string[] args)
    {
        var temp = new EmailTemplateService();
        var emalTemp1 = new EmailTemplate("Registration", " Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
        temp.Add(emalTemp1);
        var emalTemp2 = new EmailTemplate("Blocked", " Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");
        temp.Add(emalTemp2);


        temp.GetAccountBlockedTemplate("Firdavs");
        temp.GetRegistrationTemplate("John");

    }
}