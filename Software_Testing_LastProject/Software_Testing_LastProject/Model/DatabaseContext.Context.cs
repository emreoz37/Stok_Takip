﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Software_Testing_LastProject.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolumler> Bolumlers { get; set; }
        public virtual DbSet<Demirbas_Oda> Demirbas_Oda { get; set; }
        public virtual DbSet<Demirbaslar> Demirbaslars { get; set; }
        public virtual DbSet<Fakulteler> Fakultelers { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kisiler> Kisilers { get; set; }
        public virtual DbSet<Kullanici_Role> Kullanici_Role { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<OdaFakulteBolum> OdaFakulteBolums { get; set; }
        public virtual DbSet<Odalar> Odalars { get; set; }
        public virtual DbSet<Roller> Rollers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Urun_Stok> Urun_Stok { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
        public virtual DbSet<Zimmetler> Zimmetlers { get; set; }
        public virtual DbSet<KisiOda> KisiOdas { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_DemirbasDuzenle(Nullable<int> demirbasNo, Nullable<int> fakutleId, Nullable<int> bolumId, Nullable<int> kategoriId, Nullable<int> demirbasAdedi, string demirbasAciklama)
        {
            var demirbasNoParameter = demirbasNo.HasValue ?
                new ObjectParameter("demirbasNo", demirbasNo) :
                new ObjectParameter("demirbasNo", typeof(int));
    
            var fakutleIdParameter = fakutleId.HasValue ?
                new ObjectParameter("fakutleId", fakutleId) :
                new ObjectParameter("fakutleId", typeof(int));
    
            var bolumIdParameter = bolumId.HasValue ?
                new ObjectParameter("bolumId", bolumId) :
                new ObjectParameter("bolumId", typeof(int));
    
            var kategoriIdParameter = kategoriId.HasValue ?
                new ObjectParameter("kategoriId", kategoriId) :
                new ObjectParameter("kategoriId", typeof(int));
    
            var demirbasAdediParameter = demirbasAdedi.HasValue ?
                new ObjectParameter("demirbasAdedi", demirbasAdedi) :
                new ObjectParameter("demirbasAdedi", typeof(int));
    
            var demirbasAciklamaParameter = demirbasAciklama != null ?
                new ObjectParameter("demirbasAciklama", demirbasAciklama) :
                new ObjectParameter("demirbasAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DemirbasDuzenle", demirbasNoParameter, fakutleIdParameter, bolumIdParameter, kategoriIdParameter, demirbasAdediParameter, demirbasAciklamaParameter);
        }
    
        public virtual int sp_DemirbasEkle(Nullable<int> fakutleId, Nullable<int> bolumId, Nullable<int> kategoriId, Nullable<int> urunId, Nullable<int> demirbasAdedi, string demirbasAciklama)
        {
            var fakutleIdParameter = fakutleId.HasValue ?
                new ObjectParameter("fakutleId", fakutleId) :
                new ObjectParameter("fakutleId", typeof(int));
    
            var bolumIdParameter = bolumId.HasValue ?
                new ObjectParameter("bolumId", bolumId) :
                new ObjectParameter("bolumId", typeof(int));
    
            var kategoriIdParameter = kategoriId.HasValue ?
                new ObjectParameter("kategoriId", kategoriId) :
                new ObjectParameter("kategoriId", typeof(int));
    
            var urunIdParameter = urunId.HasValue ?
                new ObjectParameter("urunId", urunId) :
                new ObjectParameter("urunId", typeof(int));
    
            var demirbasAdediParameter = demirbasAdedi.HasValue ?
                new ObjectParameter("demirbasAdedi", demirbasAdedi) :
                new ObjectParameter("demirbasAdedi", typeof(int));
    
            var demirbasAciklamaParameter = demirbasAciklama != null ?
                new ObjectParameter("demirbasAciklama", demirbasAciklama) :
                new ObjectParameter("demirbasAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DemirbasEkle", fakutleIdParameter, bolumIdParameter, kategoriIdParameter, urunIdParameter, demirbasAdediParameter, demirbasAciklamaParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_OdaDemirbaslariGetir(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OdaDemirbaslariGetir", odaIdParameter);
        }
    
        public virtual int sp_OdaEkle(string odaAdi, Nullable<int> bolumId)
        {
            var odaAdiParameter = odaAdi != null ?
                new ObjectParameter("OdaAdi", odaAdi) :
                new ObjectParameter("OdaAdi", typeof(string));
    
            var bolumIdParameter = bolumId.HasValue ?
                new ObjectParameter("BolumId", bolumId) :
                new ObjectParameter("BolumId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OdaEkle", odaAdiParameter, bolumIdParameter);
        }
    
        public virtual int sp_OdaGuncelle(Nullable<int> odaId, string odaAdi, Nullable<int> bolumId, Nullable<int> kisiId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            var odaAdiParameter = odaAdi != null ?
                new ObjectParameter("OdaAdi", odaAdi) :
                new ObjectParameter("OdaAdi", typeof(string));
    
            var bolumIdParameter = bolumId.HasValue ?
                new ObjectParameter("BolumId", bolumId) :
                new ObjectParameter("BolumId", typeof(int));
    
            var kisiIdParameter = kisiId.HasValue ?
                new ObjectParameter("KisiId", kisiId) :
                new ObjectParameter("KisiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OdaGuncelle", odaIdParameter, odaAdiParameter, bolumIdParameter, kisiIdParameter);
        }
    
        public virtual int sp_OdayaDemirbasEkle(Nullable<int> demirbasId, Nullable<int> odaId, Nullable<int> adet)
        {
            var demirbasIdParameter = demirbasId.HasValue ?
                new ObjectParameter("DemirbasId", demirbasId) :
                new ObjectParameter("DemirbasId", typeof(int));
    
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            var adetParameter = adet.HasValue ?
                new ObjectParameter("Adet", adet) :
                new ObjectParameter("Adet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OdayaDemirbasEkle", demirbasIdParameter, odaIdParameter, adetParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_UrunEkle(Nullable<int> kategoriId, string urunAdi, Nullable<decimal> urunBirimFiyati, Nullable<int> stok, Nullable<System.DateTime> satinAlinmaTarihi)
        {
            var kategoriIdParameter = kategoriId.HasValue ?
                new ObjectParameter("KategoriId", kategoriId) :
                new ObjectParameter("KategoriId", typeof(int));
    
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("UrunAdi", urunAdi) :
                new ObjectParameter("UrunAdi", typeof(string));
    
            var urunBirimFiyatiParameter = urunBirimFiyati.HasValue ?
                new ObjectParameter("UrunBirimFiyati", urunBirimFiyati) :
                new ObjectParameter("UrunBirimFiyati", typeof(decimal));
    
            var stokParameter = stok.HasValue ?
                new ObjectParameter("Stok", stok) :
                new ObjectParameter("Stok", typeof(int));
    
            var satinAlinmaTarihiParameter = satinAlinmaTarihi.HasValue ?
                new ObjectParameter("SatinAlinmaTarihi", satinAlinmaTarihi) :
                new ObjectParameter("SatinAlinmaTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UrunEkle", kategoriIdParameter, urunAdiParameter, urunBirimFiyatiParameter, stokParameter, satinAlinmaTarihiParameter);
        }
    
        public virtual int sp_UrunGuncelle(Nullable<int> urunId, Nullable<int> kategoriId, string urunAdi, Nullable<decimal> urunBirimFiyati, Nullable<int> stok, Nullable<System.DateTime> satinAlinmaTarihi)
        {
            var urunIdParameter = urunId.HasValue ?
                new ObjectParameter("UrunId", urunId) :
                new ObjectParameter("UrunId", typeof(int));
    
            var kategoriIdParameter = kategoriId.HasValue ?
                new ObjectParameter("KategoriId", kategoriId) :
                new ObjectParameter("KategoriId", typeof(int));
    
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("UrunAdi", urunAdi) :
                new ObjectParameter("UrunAdi", typeof(string));
    
            var urunBirimFiyatiParameter = urunBirimFiyati.HasValue ?
                new ObjectParameter("UrunBirimFiyati", urunBirimFiyati) :
                new ObjectParameter("UrunBirimFiyati", typeof(decimal));
    
            var stokParameter = stok.HasValue ?
                new ObjectParameter("Stok", stok) :
                new ObjectParameter("Stok", typeof(int));
    
            var satinAlinmaTarihiParameter = satinAlinmaTarihi.HasValue ?
                new ObjectParameter("SatinAlinmaTarihi", satinAlinmaTarihi) :
                new ObjectParameter("SatinAlinmaTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UrunGuncelle", urunIdParameter, kategoriIdParameter, urunAdiParameter, urunBirimFiyatiParameter, stokParameter, satinAlinmaTarihiParameter);
        }
    
        public virtual ObjectResult<sp_OdaDemirbaslariGetir1_Result> sp_OdaDemirbaslariGetir1(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_OdaDemirbaslariGetir1_Result>("sp_OdaDemirbaslariGetir1", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_odadakiDemirbaslar_Result> sp_odadakiDemirbaslar(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_odadakiDemirbaslar_Result>("sp_odadakiDemirbaslar", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_odadaki_Demirbaslar_Result> sp_odadaki_Demirbaslar(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_odadaki_Demirbaslar_Result>("sp_odadaki_Demirbaslar", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_odadaki_Demirbaslar1_Result> sp_odadaki_Demirbaslar1(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_odadaki_Demirbaslar1_Result>("sp_odadaki_Demirbaslar1", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_Odadaki_Demirbaslar01_Result> sp_Odadaki_Demirbaslar01(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Odadaki_Demirbaslar01_Result>("sp_Odadaki_Demirbaslar01", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_Odadaki_Demirbaslar02_Result> sp_Odadaki_Demirbaslar02(Nullable<int> odaId)
        {
            var odaIdParameter = odaId.HasValue ?
                new ObjectParameter("OdaId", odaId) :
                new ObjectParameter("OdaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Odadaki_Demirbaslar02_Result>("sp_Odadaki_Demirbaslar02", odaIdParameter);
        }
    
        public virtual ObjectResult<sp_kisi_Demirbaslar_Result> sp_kisi_Demirbaslar(Nullable<int> kisiId)
        {
            var kisiIdParameter = kisiId.HasValue ?
                new ObjectParameter("kisiId", kisiId) :
                new ObjectParameter("kisiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_kisi_Demirbaslar_Result>("sp_kisi_Demirbaslar", kisiIdParameter);
        }
    
        public virtual ObjectResult<sp_kisi_Demirbaslar1_Result> sp_kisi_Demirbaslar1(Nullable<int> kisiId)
        {
            var kisiIdParameter = kisiId.HasValue ?
                new ObjectParameter("kisiId", kisiId) :
                new ObjectParameter("kisiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_kisi_Demirbaslar1_Result>("sp_kisi_Demirbaslar1", kisiIdParameter);
        }
    }
}