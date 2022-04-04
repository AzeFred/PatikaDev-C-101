using System;
using System.Collections.Generic;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations userOperations = new Operations();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Kart  Ekle");
            Console.WriteLine("(2) Kart Güncelle");
            Console.WriteLine("(3) Kart Sil");
            Console.WriteLine("(4) Kart Taşı");
            Console.WriteLine("(5) Kartları Listele");
            Console.WriteLine("(6) Çıkış");
            Console.Write("İslemlerden birini seçiniz (1-2-3-4-5-6)");
                //
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
                {
                    userOperations.CardAdd();
                    Console.WriteLine("**********************************************");
                    userOperations.CardList();
                }
            else if (input == 2)
                {
                    userOperations.CardUpdate();
                    Console.WriteLine("**********************************************");
                    userOperations.CardList();
                }
            else if (input == 3)
                {
                    userOperations.CardDelete();
                    Console.WriteLine("**********************************************");
                    userOperations.CardList();
                }
            else if (input == 4)
                {
                    userOperations.CardTransfer();
                    Console.WriteLine("**********************************************");
                    userOperations.CardList();
                }
            else if (input == 5)
                {
                    userOperations.CardList();
                    Console.WriteLine("**********************************************");
                }
            }
        }
    }

    class Operations
    {
        private AllBoard todo = new AllBoard("TODO LİNE");
        private AllBoard progress = new AllBoard("IN PROGRES LİNE");
        private AllBoard done = new AllBoard("DONE LİNE");
        Dictionary<int, string> users = new Dictionary<int, string>();
        public Operations()
        {
            //
            users[1] = "Developer";
            users[2] = "Designer";
            users[3] = "Artist";
            users[4] = "Manager";
            //
            todo.board.Add(new Board("Title1", "Content1", 1, users[1]));
            progress.board.Add(new Board("Title2", "Content2", 2, users[2]));
            done.board.Add(new Board("Title3", "Content3", 3, users[3]));

        }
        public void CardTransfer()
        {
            Console.WriteLine("Öncelikle Taşıma istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();
            Console.Write("Lütfen Taşıncak  (Todo)-1 (Progres)-2 (Done)-3 tercih yapınız: ");
            int board_no = Convert.ToInt32(Console.ReadLine());
            var vtodo = todo.GetBoard(title);
            var vprogress = progress.GetBoard(title);
            var vdone = done.GetBoard(title);
            var value = new Board();
            bool evaluation = (board_no == 1) | (board_no == 2) | (board_no == 3);
            if (vtodo != null)
            {
                value = vtodo;
                if (evaluation)
                {
                    todo.board.Remove(vtodo);
                }
            }
            else if (vprogress != null)
            {
                value = vprogress;
                if (evaluation)
                {
                    progress.board.Remove(vprogress);
                }
            }
            else if (vdone != null)
            {
                value = vdone;
                if (evaluation)
                {
                    done.board.Remove(vdone);
                }
            }
            else
            {
                Console.WriteLine("Baslik  Bulunamadı");
            }
            if (evaluation)
            {
                if (board_no == 1)
                {
                    todo.board.Add(value);
                }
                else if (board_no == 2)
                {
                    progress.board.Add(value);
                }
                else if (board_no == 3)
                {
                    done.board.Add(value);
                }
            }

        }
        public void CardList()
        {
            todo.PrintToScreen();
            progress.PrintToScreen();
            done.PrintToScreen();
        }
        public void CardUpdate()
        {
            Console.WriteLine("Öncelikle Güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write(" Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();
            var vtodo = todo.GetBoard(title);
            var vprogress = progress.GetBoard(title);
            var vdone = done.GetBoard(title);

            if (vtodo != null)
            {
                UpdateInfo(vtodo);
            }
            else if (vprogress != null)
            {
                UpdateInfo(vprogress);
            }
            else if (vdone != null)
            {
                UpdateInfo(vdone);
            }
            else
            {
                Console.WriteLine("Baslık Bulunamadı");
            }
        }
        public void UpdateInfo(Board brd)
        {
            Console.Write("Başlık Giriniz                                  :");
            string title = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            string content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz     ->  (1),(2),(3),(4)            :");
            int kisi = Convert.ToInt32(Console.ReadLine());
            brd.Baslik = title;
            brd.Iceirk = content;
            brd.Buyukluk = size;
            brd.Atanan_kisi = users[kisi];
            Console.WriteLine("Güncellenmiş Veri");
            brd.PrintScreen();
        }

        public void CardAdd()
        {

            Console.Write("Başlık Giriniz                                  :");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int buyukluk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz     ->  (1),(2),(3),(4)            :");
            int kisi = Convert.ToInt32(Console.ReadLine());
            //
            todo.board.Add(new Board(baslik, icerik, buyukluk, users[kisi]));
            //
        }
        public void CardSearch()
        {
            Console.WriteLine("Öncelikle aramak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write(" Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            if (todo.SearchBoard(baslik) | progress.SearchBoard(baslik) | done.SearchBoard(baslik))
            {

            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı.");
            }
            Console.WriteLine("**************************************");
        }
        public void CardDelete()
        {

            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            while (true)
            {
                Console.Write(" Lütfen kart başlığını yazınız: ");
                string baslik = Console.ReadLine();
                if (todo.BoardDelete(baslik) | progress.BoardDelete(baslik) | done.BoardDelete(baslik))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("*Yeniden denemek için      : (2)");
                    string tercih = Console.ReadLine();
                    if (tercih == "1")
                    {
                        break;
                    }
                    else if (tercih == "2")
                    {
                        break;
                    }

                }
            }
        }
    }


    class AllBoard
    {
        public List<Board> board = new List<Board>();
        public string baslik = "";
        public AllBoard(string baslik)
        {
            this.baslik = baslik;
        }

        public void PrintToScreen()
        {
            Console.WriteLine(baslik);
            Console.WriteLine("**************************************");
            foreach (var v in board)
            {
                v.PrintScreen();
            }
            if (board == null)
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }

        public bool BoardDelete(string arama_metni)
        {
            bool durum = false;
            if (board == null)
            {
                Console.WriteLine("~ BOŞ ~");
                return durum;
            }
            while (true)
            {
                int ind = board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
                if (ind >= 0)
                {
                    board.RemoveAt(ind);
                    durum = true;
                }
                else
                {
                    break;
                }
            }
            return durum;
        }
        public void FastBoardDelete(Board vboard)
        {
            board.Remove(vboard);
        }
        public bool SearchBoard(string arama_metni)
        {
            bool durum = false;
            if (board == null)
            {
                Console.WriteLine("~ BOŞ ~");
                return durum;
            }
            for (int a = 0; a < board.Count; a++)
            {
                int ind = board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
                if (ind >= 0)
                {
                    board[ind].PrintScreen();
                    durum = true;
                }
                else
                {
                    break;
                }
            }
            return durum;
        }
        public Board GetBoard(string arama_metni)
        {
            if (board == null)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            int ind = board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
            if (ind >= 0)
            {
                return board[ind];
            }
            else
            {
                return null;
            }
        }
    }


    class Board
    {
        private string baslik;
        private string icerik;
        private string atanan_kisi;
        private int buyukluk;

        public Board()
        {

        }
        public Board(string baslik1, string icerik1, int buyukluk1, string atanan_kisi1)
        {
            baslik = baslik1;
            icerik = icerik1;
            buyukluk = buyukluk1;
            atanan_kisi = atanan_kisi1;

        }

        public string Baslik { get => baslik; set => baslik = value; }
        public string Iceirk { get => icerik; set => icerik = value; }
        public string Atanan_kisi { get => atanan_kisi; set => atanan_kisi = value; }
        public int Buyukluk { get => buyukluk; set => buyukluk = value; }

        public void PrintScreen()
        {
            Console.WriteLine("Baslik       :   {0}", baslik);
            Console.WriteLine("İçerik       :   {0}", icerik);
            Console.WriteLine("Atanan Kişi  :   {0}", atanan_kisi);
            Console.WriteLine("Büyüklük     :   {0}", (Size)buyukluk);
            Console.WriteLine("-");
        }
    }

    enum Size
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }
