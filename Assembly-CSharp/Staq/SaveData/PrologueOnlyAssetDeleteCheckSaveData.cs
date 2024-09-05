// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PrologueOnlyAssetDeleteCheckSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D3A")]
  public class PrologueOnlyAssetDeleteCheckSaveData
  {
    [Token(Token = "0x4010D49")]
    [FieldOffset(Offset = "0x10")]
    public bool DeleteChecked;
    [Token(Token = "0x4010D4A")]
    [FieldOffset(Offset = "0x11")]
    public bool Deleted;

    [Token(Token = "0x1700506A")]
    public static string Path
    {
      [Token(Token = "0x6018A20"), Address(RVA = "0x2639B5C", Offset = "0x2639B5C", VA = "0x2639B5C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700506B")]
    public bool IgnoreDeleteOnAccountRecreate
    {
      [Token(Token = "0x6018A21"), Address(RVA = "0x2639BAC", Offset = "0x2639BAC", VA = "0x2639BAC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018A22")]
    [Address(RVA = "0x2639BB4", Offset = "0x2639BB4", VA = "0x2639BB4")]
    public PrologueOnlyAssetDeleteCheckSaveData()
    {
    }

    [Token(Token = "0x6018A23")]
    [Address(RVA = "0x2639BE0", Offset = "0x2639BE0", VA = "0x2639BE0")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A24")]
    [Address(RVA = "0x2639BD8", Offset = "0x2639BD8", VA = "0x2639BD8")]
    public void Init()
    {
    }

    [Token(Token = "0x6018A25")]
    [Address(RVA = "0x2639C28", Offset = "0x2639C28", VA = "0x2639C28")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A26")]
    [Address(RVA = "0x2639C58", Offset = "0x2639C58", VA = "0x2639C58")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A27")]
    [Address(RVA = "0x2639C70", Offset = "0x2639C70", VA = "0x2639C70")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A28")]
    [Address(RVA = "0x2639D9C", Offset = "0x2639D9C", VA = "0x2639D9C")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A29")]
    [Address(RVA = "0x2639E84", Offset = "0x2639E84", VA = "0x2639E84")]
    public bool IsDeleted() => new bool();
  }
}
