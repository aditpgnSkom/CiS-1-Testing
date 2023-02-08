Console.WriteLine("Masukkan Nama Anda : ");
string nama = Console.ReadLine();
Console.WriteLine("Masukkan Nilai MTK : ");
int mtk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Masukkan Nilai Bio : ");
int bio = Convert.ToInt32(Console.ReadLine());
string hasil = (mtk > bio) ? "Nilai MTK lebih besar" : "Nilai Bio lebih besar";
Console.WriteLine($"Nama anda {nama}, Nilai Bio anda {bio} dan Nilai Mtk anda {mtk}, jadi {hasil}.");