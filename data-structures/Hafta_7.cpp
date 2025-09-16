//derste yazdığımız kod
#include <iostream>
using namespace std;

//10 elemanlı bir kuyruk yapımız olsun
#define BOYUT 10

class CircularQueue//ismi DaireselKuyruk da verebiliriz. 
//Geçen hafta Stack demiştik bu hafta da ingilizce olsun madem
{
private:
	int		Kuyruk[BOYUT]; //Kuyruk elemanlarının tutulacağı dizi
	int		KB; //Kuyruğun ilk elemanının indis değerini tutan değişken
	int		KS; //Kuyruğun son elemanının indis değerini tutan değişken
	int		ES; //eleman sayısı
public:
	CircularQueue();
	bool	Ekle(int yeniEleman); //Kuyruğa eleman ekleme (Enqueue) Geçen Push() demiştik
	bool	Cikar(int& hucre); //Kuyruktan eleman çıkarma (Dequeue) Geçen Pop() demiştik
	bool	Bosmu(); //IsEmty() demiştik geçen hafta
	void  	Yazdir(); //writeAll() Display() demiştik geçen hafta
};
CircularQueue::CircularQueue()//kurucu(Yapıcı) fonksiyon
{
		KS	= -1;
		KB	= -1;
		ES	= 0;
}

bool CircularQueue::Ekle(int yeniEleman)
{
	//Eğer dizi dolmuşsa fonksiyon hemen geri döner.
	if(ES>=BOYUT) //dizi dolu ve ekleme yapamazsın
		return false; //Kuyruğa ekleme işlemi gerçekleşmedi

	//Eğer kuyruk boş ise  ilk olarak KB arttırılmalıdır
	if(KB==-1)
	{
		KB++;
	}

	//Eğer kuyruk dizinin son elemanı ise kuyruğu başa sar
	if(KS==BOYUT-1) 
		KS = 0;  //kuyruk sonunu 0 yapalım, çünkü zaten KB=0 değil
	else   // kuyruk sonu herhangibir yeri gösteriyorsa 1 artırmak yeterli
		KS++;

	Kuyruk[KS] = yeniEleman;
	//Kuyruktaki eleman sayısını 1 arttır, çünkü ekleme yaptık
	ES++;
	return true; //Kuyruğa ekleme işlemi gerçekleşti demektir.
}

bool CircularQueue::Cikar(int& hucre)
{
	//Eğer kuyruk boş ise 0 döndür çünkü eleman çıkarma işlemi yapamayız
	if(ES==0)
		return false;
    //bu satıra geldiğimize göre kuyrukta eleman var
	hucre = Kuyruk[KB]; //Kuyruğun başındaki elemanı parametreye ata

	//Kuyruğun başı dizinin son elemanı ise KB değişkenini dizinin başı yap
	if(KB==BOYUT-1)
		KB = 0;
	else //son eleman değilse KB 1 artacak
		KB++;

	//silme işlemi yaptığımıza göre Kuyruktaki eleman sayısını bir azalt
	ES--;
		
	//Eğer kuyrukta eleman kalmadıysa değişkenleri başlangıç durumuna getir
	if(ES<=0) // "=="" de olur. 
	 
		KS=KB=-1;

	return true; //çıkarma işlemi yaptık demektir
}
bool CircularQueue::Bosmu()
{
	if(ES==0)
		return true; //demekki boş
	return false; //else koyabiliriz/koymayabiliriz
}
void CircularQueue::Yazdir() 
{
   if(KS>=0) //demekki kuyrukta eleman var
   {
      cout<<"Kuyruktaki elemanlar:";
      
      if(KS>KB)
      for(int i=KB; i<=KS; i++)
         cout<<Kuyruk[i]<<" ";
      
      else //demekki KB>KS
      {
        for(int i=KB; i<BOYUT; i++)
             cout<<Kuyruk[i]<<" ";
        for(int i=0; i<=KS; i++)
            cout<<Kuyruk[i]<<" ";
      }
         cout<<endl;
   
   } 
   else //demekki kuyrukta eleman yok
      cout<<"Kuyruk bos"<<endl;
}
int main()
{
	CircularQueue K;
	//kuyruğa 10 eleman ekleyelim 
	for(int i=0;i<10;i++)
	    K.Ekle(i);
    K.Yazdir(); //kuyruktaki elemanları yazdıralım
    
    //kuyruktan 6 eleman silelim
    int temp;
    for(int i=0;i<6;i++)
    {
		  K.Cikar(temp);
    }
    K.Yazdir(); //kuyruktaki elemanları yazdıralım
    
    //burada kuyruğa 10 eleman eklendikten 
    //sonra 6sı silinmiş ve 3 daha eklenmiştir.
    //dikkat edilirse KB>KS durumu oluşur 
        
    K.Ekle(43);
    K.Ekle(44);
    K.Ekle(45);
    
		K.Yazdir();

}