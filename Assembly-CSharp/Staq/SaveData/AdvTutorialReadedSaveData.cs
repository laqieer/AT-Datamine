// Decompiled with JetBrains decompiler
// Type: staq.SaveData.AdvTutorialReadedSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF2")]
  public class AdvTutorialReadedSaveData
  {
    [Token(Token = "0x4010C56")]
    [FieldOffset(Offset = "0x11")]
    public bool ReadedBackHome;

    [Token(Token = "0x1700500A")]
    public bool loaded
    {
      [Token(Token = "0x60187D7"), Address(RVA = "0x2938650", Offset = "0x2938650", VA = "0x2938650")] get
      {
        return new bool();
      }
      [Token(Token = "0x60187D8"), Address(RVA = "0x2938658", Offset = "0x2938658", VA = "0x2938658")] private set
      {
      }
    }

    [Token(Token = "0x60187D9")]
    [Address(RVA = "0x2938664", Offset = "0x2938664", VA = "0x2938664")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60187DA")]
    [Address(RVA = "0x29386D4", Offset = "0x29386D4", VA = "0x29386D4")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60187DB")]
    [Address(RVA = "0x2938704", Offset = "0x2938704", VA = "0x2938704")]
    public void Delete()
    {
    }

    [Token(Token = "0x60187DC")]
    [Address(RVA = "0x2938708", Offset = "0x2938708", VA = "0x2938708")]
    public void Load()
    {
    }

    [Token(Token = "0x60187DD")]
    [Address(RVA = "0x2938888", Offset = "0x2938888", VA = "0x2938888")]
    public void Save()
    {
    }

    [Token(Token = "0x60187DE")]
    [Address(RVA = "0x2938990", Offset = "0x2938990", VA = "0x2938990")]
    public AdvTutorialReadedSaveData()
    {
    }
  }
}
