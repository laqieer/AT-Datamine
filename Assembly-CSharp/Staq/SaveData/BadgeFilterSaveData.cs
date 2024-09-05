// Decompiled with JetBrains decompiler
// Type: staq.SaveData.BadgeFilterSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF6")]
  public class BadgeFilterSaveData
  {
    [Token(Token = "0x4010C65")]
    [FieldOffset(Offset = "0x10")]
    public bool IsValidStyle;
    [Token(Token = "0x4010C66")]
    [FieldOffset(Offset = "0x11")]
    public bool IsValidWeapon;
    [Token(Token = "0x4010C67")]
    [FieldOffset(Offset = "0x12")]
    public bool IsValidAccessory;
    [Token(Token = "0x4010C68")]
    [FieldOffset(Offset = "0x13")]
    public bool IsValidMindEquipment;

    [Token(Token = "0x1700500E")]
    private static string Path
    {
      [Token(Token = "0x60187F5"), Address(RVA = "0x2939628", Offset = "0x2939628", VA = "0x2939628")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60187F6")]
    [Address(RVA = "0x2939678", Offset = "0x2939678", VA = "0x2939678")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60187F7")]
    [Address(RVA = "0x29396C0", Offset = "0x29396C0", VA = "0x29396C0")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60187F8")]
    [Address(RVA = "0x29396EC", Offset = "0x29396EC", VA = "0x29396EC")]
    public void Delete()
    {
    }

    [Token(Token = "0x60187F9")]
    [Address(RVA = "0x29398B8", Offset = "0x29398B8", VA = "0x29398B8")]
    public bool IsExist() => new bool();

    [Token(Token = "0x60187FA")]
    [Address(RVA = "0x2939704", Offset = "0x2939704", VA = "0x2939704")]
    public void Load()
    {
    }

    [Token(Token = "0x60187FB")]
    [Address(RVA = "0x29398CC", Offset = "0x29398CC", VA = "0x29398CC")]
    public void Save()
    {
    }

    [Token(Token = "0x60187FC")]
    [Address(RVA = "0x29399B4", Offset = "0x29399B4", VA = "0x29399B4")]
    public void SetStyle(bool isValid)
    {
    }

    [Token(Token = "0x60187FD")]
    [Address(RVA = "0x29399C0", Offset = "0x29399C0", VA = "0x29399C0")]
    public void SetWeapon(bool isValid)
    {
    }

    [Token(Token = "0x60187FE")]
    [Address(RVA = "0x29399CC", Offset = "0x29399CC", VA = "0x29399CC")]
    public void SetAccessory(bool isValid)
    {
    }

    [Token(Token = "0x60187FF")]
    [Address(RVA = "0x29399D8", Offset = "0x29399D8", VA = "0x29399D8")]
    public void SetMindEquipment(bool isValid)
    {
    }

    [Token(Token = "0x6018800")]
    [Address(RVA = "0x29399E4", Offset = "0x29399E4", VA = "0x29399E4")]
    public BadgeFilterSaveData()
    {
    }
  }
}
