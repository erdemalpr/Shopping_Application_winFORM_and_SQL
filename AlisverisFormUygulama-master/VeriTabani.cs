using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;



namespace form_deneme
{
    public class VeriTabani
    {
        
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VJ0O2QUL\\SQLEXPRESS;Initial Catalog=ProjeVeriTabani;Integrated Security=True");

        public ArrayList arama_liste = new ArrayList();       //istediğin ürünü bulma
        public ArrayList urunbilgi_listesi = new ArrayList(); //tüm ürün bilgileri 
        public ArrayList sahip_ilanlar = new ArrayList();     //ilan sahibinin ilanları 0-1-2-3-4 / 5-6-7-8-9 
        public ArrayList favori_listesi = new ArrayList();    //favori bilgileri
        public ArrayList aramasonuc_listesi = new ArrayList();
        public ArrayList panel_saticilist = new ArrayList();


        public int veri_kayit(string isim, string soyisim, string e_posta, string sifre)
        {
            try
            {
                con.Open();
                string sorgu = "insert into Kullanici_Bilgileri(Isim,Soyisim,E_posta,Sifre) values(@isim,@soyisim,@eposta,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@isim", isim);
                komut.Parameters.AddWithValue("@soyisim", soyisim);
                komut.Parameters.AddWithValue("@eposta", e_posta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch
            {
                con.Close();
                return 0;
            }
            finally
            {
                con.Close();
            }

        }

        public int Eposta_sorgulama(string e_posta)
        {
            try
            {
                con.Open(); //E posta sorgulama, aynı
                string sorgu = "select * from Kullanici_Bilgileri where E_posta=@posta";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@posta", e_posta);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    
                    return 1;
                }
                else
                {
                    
                    return 0;
                }
            }
            catch (Exception)
            {
                
                return 0;
            }
            finally
            {
                con.Close();
            }

        }
        public string Kullanici_Sorgulama(string kullanici_adi, string e_posta, string sifre)
        {
            try
            {
                con.Open(); //Isim ve epostayla kullanıcı giriş yapabilecek tek şart şifrenin eşleşmesi
                string sorgu = "select * from Kullanici_Bilgileri where (Isim=@isim or E_posta=@posta) and Sifre=@sifre";
                SqlCommand komut = new SqlCommand(sorgu, con);
                SqlDataReader dr;
                komut.Parameters.AddWithValue("@isim", kullanici_adi);
                komut.Parameters.AddWithValue("@posta", e_posta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                dr = komut.ExecuteReader();
                if (dr.Read()) //Eğer sorgudan bir veriye ulaşırsak
                {
                    
                    return dr["ID"].ToString();          //Kullanıcı Adı ve Şifreyi İlerde
                                                          //Kullanmak için return ediyoruz
                }
                else
                {
                    
                    return string.Empty;
                }
                
            }
            catch (Exception)
            {
                
                return string.Empty;
            }
            finally
            {
                con.Close();
            }
            

        }
        public string mesaj_gonderme(string gonderilecek_kimse, string mesaj, string gonderen_kimse)
        {
            try
            {
                con.Open(); //İlan sahibine metin ve göndericinin adını gönderiyoruz
                string sorgu = "update IlanBilgileri set IlanMesaj=@msj,MesajGonderici=@dgr2 where IlanSahibi=@dgr";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@msj", mesaj);
                komut.Parameters.AddWithValue("@dgr", gonderilecek_kimse);
                komut.Parameters.AddWithValue("@dgr2", gonderen_kimse);
                komut.ExecuteNonQuery();
                
                return "basarili";
  
            }
            catch (Exception)
            {
               
                return String.Empty;
            }
            finally
            {
                con.Close();
            }
        }

        /*
        public string mesaj_alma(string urun_ismi, string satici_ismi)
        {
            try
            {
                con.Open();
                string sorgu = "select MesajGonderici,IlanMesaj,IlanSahibi from  IlanBilgileri where Baslik=@bslk";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@bslk", urun_ismi);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["IlanSahibi"].ToString().Contains(satici_ismi))
                    {
                        liste.Add(dr["MesajGonderici"]);
                        liste.Add(dr["IlanMesaj"]);
                        return "tebrikler";
                    }
                    else
                    {
                       
                        return string.Empty;
                    }

                }
                else
                {
                   
                    return string.Empty;
                }
            }
            catch (Exception)
            {
              
                return string.Empty;
            }
            finally
            {
                con.Close();
            }

        }
        */
        /*
        public string arama_bulma(string urun_ismi)
        {

            try
            {
                con.Open();
                string sorgu = "select * from IlanBilgileri where Baslik=@bslk";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@bslk", urun_ismi);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    while (dr.Read())
                    {
                        arama_liste.Add(dr["Uzanti_Resim1"]);
                        arama_liste.Add(dr["Uzanti_Resim2"]);
                        arama_liste.Add(dr["Baslik"]);
                        arama_liste.Add(dr["Alt_Baslik"]);
                        arama_liste.Add(dr["Genel_Ozellikler"]);
                        arama_liste.Add(dr["Fiyat"]);
                    }
                    return "islem basarili";
                }
                else
                {
                    return String.Empty;
                }


            }
            catch (Exception)
            {
                return String.Empty;
            }
            finally
            {
                con.Close();
            }

        }
        */

        public int Eposta_kontrol(string e_posta) //Gönderilen epostada @ ve .com uzantısının olma zorunluluğu
        {
            int flag = 0;
            if (e_posta.Contains("@") && e_posta.Contains(".com") && e_posta.Length > 13)
            {
                flag = 1;
            }
            return flag;
        }

        public int Sifre_kontrol(string sifre)  //Gönderilen şifrede karakter ve tam sayı kontrolü
        {
            int flag = 0;
            int flag2 = 0;

            foreach (char x in sifre)
            {
                if (char.IsNumber(x))  //Rakam varsa ilk flag 1 olacak
                {
                    flag = 1;
                }
                else if (!char.IsNumber(x))
                {
                    flag2 = 1;   //Karakter varsa ikinci flag 1 olacak
                }
            }
            int flag_toplam = flag + flag2;

            if (flag_toplam == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Ilan_Kayit(string kategori, string uzanti1, string uzanti2, string baslik, string fiyat, string genel_ozellikler, string ilan_sahibi,string telefon_numarasi)
        {
            try
            {
                con.Open();
                string sorgu = "insert into IlanBilgileri(Kategori,Uzanti_Resim1,Uzanti_Resim2,Baslik,Genel_Ozellikler,Fiyat,IlanSahibi,Telefon_Numarasi) values(@0,@1,@2,@3,@4,@5,@6,@7)";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@0", kategori);
                komut.Parameters.AddWithValue("@1", uzanti1);
                komut.Parameters.AddWithValue("@2", uzanti2);
                komut.Parameters.AddWithValue("@3", baslik);
                komut.Parameters.AddWithValue("@4", genel_ozellikler);
                komut.Parameters.AddWithValue("@5", fiyat);
                komut.Parameters.AddWithValue("@6", ilan_sahibi);
                komut.Parameters.AddWithValue("@7", telefon_numarasi);
             
                komut.ExecuteNonQuery();
                return 1;
                
            }
            catch (Exception )
            {         
                return 0;
            }
            finally
            {
                con.Close();
            }
        }


        public string ID_Isimalma(string ID)
        {
            try
            {
                con.Open();
                string sorgu = "select Isim,Soyisim from Kullanici_Bilgileri where ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", ID);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {  
                    return dr["Isim"] + " " + dr["Soyisim"];
                    
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                return String.Empty;
            }
            finally
            {
                con.Close();
            }
        }


        public void ilan_bilgileri()
        {
            try
            {
                con.Open();
                string sorgu = "select * from IlanBilgileri";
                SqlCommand komut = new SqlCommand(sorgu, con);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    urunbilgi_listesi.Add(dr["Uzanti_Resim1"]);
                    urunbilgi_listesi.Add(dr["Uzanti_Resim2"]);
                    urunbilgi_listesi.Add(dr["Baslik"]);
                    urunbilgi_listesi.Add(dr["Genel_Ozellikler"]);
                    urunbilgi_listesi.Add(dr["Fiyat"]);
                }
      
            }
            catch (Exception)
            {
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        public string Ilan_SahibiSorgulama(string ad_soyad)
        {
            try
            {
                con.Open();
                string sorgu = "select * from IlanBilgileri where IlanSahibi=@shb";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@shb", ad_soyad);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    sahip_ilanlar.Add(dr["Uzanti_Resim1"]);
                    sahip_ilanlar.Add(dr["Uzanti_Resim2"]);
                    sahip_ilanlar.Add(dr["Baslik"]);
                    sahip_ilanlar.Add(dr["Genel_Ozellikler"]);
                    sahip_ilanlar.Add(dr["Fiyat"]);
                    
                }
                return "basarili";

            }
            catch (Exception)
            {
                return String.Empty;
            }
            finally
            {
                con.Close();
            }
        }

        public string ilan_silme(string baslik,string isim_soyisim)
        {
            try
            {
                con.Open();
                string sorgu = "delete IlanBilgileri where Baslik=@bslk and IlanSahibi=@shb";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@bslk",baslik);
                komut.Parameters.AddWithValue("@shb", isim_soyisim);
                komut.ExecuteNonQuery();
                return "basarili";
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                con.Close();

            }
        }
        public int rakam_kontrol(string sayi)
        {
            int flag = 0;
            foreach(char x in sayi)
            {
                if (!char.IsNumber(x))
                {
                    flag = 1;
                    break;
                }
            }
            return flag;

        }

        public string favori_kayit(string uzanti_resim,string baslik,string genel_ozellikler,string fiyat,string ilan_sahibi)
        {
            try
            {
                con.Open();
                string sorgu = "insert into Favoriler(Uzanti_Resim1,Baslik,Genel_Ozellikler,Fiyat,IlanSahibi) values(@1,@2,@3,@4,@5)";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@1", uzanti_resim);
                komut.Parameters.AddWithValue("@2", baslik);
                komut.Parameters.AddWithValue("@3", genel_ozellikler);
                komut.Parameters.AddWithValue("@4", fiyat);
                komut.Parameters.AddWithValue("@5", ilan_sahibi);
                komut.ExecuteNonQuery();
                return "islem basarili";
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                con.Close();
            }

        }
        public string favori_verileri(string ilan_sahibi)
        {
            try
            {
                con.Open();
                string sorgu = "select * from Favoriler where IlanSahibi=@shb";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@shb", ilan_sahibi);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    favori_listesi.Add(dr["Uzanti_Resim1"]);
                    favori_listesi.Add(dr["Baslik"]);
                    favori_listesi.Add(dr["Genel_Ozellikler"]);
                    favori_listesi.Add(dr["Fiyat"]);    
                }
                return "islem_basarili";
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                con.Close();
            }
        }
        public string  favori_silme(string ilan_sahibi,string baslik)
        {
            try
            {
                con.Open();
                string sorgu = "delete Favoriler where IlanSahibi=@shb and Baslik=@bslk";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@shb",ilan_sahibi);
                komut.Parameters.AddWithValue("@bslk", baslik);
                komut.ExecuteNonQuery();
                return "islem basarili";
            }
            catch (Exception)
            {
                return String.Empty;
            }
            finally
            {
                con.Close();
            }
        }

        public string sorgu_verileri(string Baslik)
        {
            try
            {
                con.Open();
                string sorgu = "select * from IlanBilgileri where (Baslik=@bslk)";
                SqlCommand komut = new SqlCommand(sorgu,con);
                komut.Parameters.AddWithValue("@bslk", Baslik);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read()){

                    aramasonuc_listesi.Add(dr["Uzanti_Resim1"]);
                    aramasonuc_listesi.Add(dr["Uzanti_Resim2"]);
                    aramasonuc_listesi.Add(dr["Baslik"]);
                    aramasonuc_listesi.Add(dr["Genel_Ozellikler"]);
                    aramasonuc_listesi.Add(dr["Fiyat"]);
                }
                return "tebrikler";
                
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                con.Close();
            }
        }

        public string saticipanel_bilgileri(string Baslik,string Genel_bilgiler)
        {
            try
            {
                con.Open();
                string sorgu = "select * from IlanBilgileri where Baslik=@bslk and Genel_Ozellikler=@gnl";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@bslk", Baslik);
                komut.Parameters.AddWithValue("@gnl", Genel_bilgiler);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    panel_saticilist.Add(dr["IlanSahibi"]);
                    panel_saticilist.Add(dr["Telefon_Numarasi"]);
                }
                return "islem_basarili";
            }
            catch (Exception)
            {
                return string.Empty;  
            }
            finally
            {
                con.Close();
            }
        }
      

       


    }
}
