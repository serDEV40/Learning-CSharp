using System;

namespace Vars{
    class Vars{
        public static void Main(string[] args){

            int bakiye = 1000;

            while(true){
                Console.WriteLine("ABC Bankasına Hoşgeldiniz Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
                Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış Yap\nSeçiminiz:");
                string secim = Console.ReadLine();
                if(secim == "1"){
                    Console.WriteLine("Bakiyeniz Gösteriliyor Bu işlem 1 saniye kadar sürer.");
                    Thread.Sleep(1000);
                    Console.WriteLine($"KALAN BAKİYE: {bakiye}");
                }else if(secim == "2"){
                    Console.Write("Lütfen Yatırmak İstediğiniz Bölmeye Koyunuz: ");
                    int parayatir = Convert.ToInt32(Console.ReadLine());
                    bakiye+=parayatir;
                    Console.WriteLine($"Toplam Bakiye: {bakiye}");
                }else if(secim == "3"){
                    Console.Write("Lütfen Çekmek İstediğiniz Miktarı Giriniz.(10 ve Katları Şeklinde Giriniz): ");
                    int paracek = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Girdiğiniz Miktar: {paracek} çekmek istediğinizden Emin misiniz?");
                    string sec = Console.ReadLine();
                    if("evet" == sec || "Evet" == sec){
                        if(bakiye <= 0){
                            Console.Write("Bakiyenizde 0TL ve Sıfırın altında para olduğu için çekme işlemi başarısız\n");
                        }else if(bakiye > 9){
                            Thread.Sleep(1500);
                            bakiye-=paracek;
                            Console.WriteLine("Para Çekme İşlemi Başarılı.");
                        }
                    }else if("Hayır" == sec || "hayır" == sec){
                        Console.WriteLine("Para Çekme İşlem Onaylanmadı");
                    }
                }else if(secim == "4"){
                    Console.WriteLine("Sistemden Çıkma İşlemi Gerçekleştiriliyor...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Sistemden Başarılı Bir Şekilde Çıkıldı.");
                    break;
                }
            }
        }
    }
}
