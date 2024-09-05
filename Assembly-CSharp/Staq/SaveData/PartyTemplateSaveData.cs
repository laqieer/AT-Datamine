// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PartyTemplateSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D33")]
  public class PartyTemplateSaveData
  {
    [Token(Token = "0x4010D30")]
    [FieldOffset(Offset = "0x14")]
    public int TemplateId;

    [Token(Token = "0x17005058")]
    public bool loaded
    {
      [Token(Token = "0x60189C9"), Address(RVA = "0x2636BE0", Offset = "0x2636BE0", VA = "0x2636BE0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60189CA"), Address(RVA = "0x2636BE8", Offset = "0x2636BE8", VA = "0x2636BE8")] private set
      {
      }
    }

    [Token(Token = "0x17005059")]
    public static string Path
    {
      [Token(Token = "0x60189CB"), Address(RVA = "0x2636BF4", Offset = "0x2636BF4", VA = "0x2636BF4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189CC")]
    [Address(RVA = "0x2636C44", Offset = "0x2636C44", VA = "0x2636C44")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189CD")]
    [Address(RVA = "0x2636C8C", Offset = "0x2636C8C", VA = "0x2636C8C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189CE")]
    [Address(RVA = "0x2636CBC", Offset = "0x2636CBC", VA = "0x2636CBC")]
    public void Delete()
    {
    }

    [Token(Token = "0x60189CF")]
    [Address(RVA = "0x2636CD8", Offset = "0x2636CD8", VA = "0x2636CD8")]
    public void Load()
    {
    }

    [Token(Token = "0x60189D0")]
    [Address(RVA = "0x2636E54", Offset = "0x2636E54", VA = "0x2636E54")]
    public void Save()
    {
    }

    [Token(Token = "0x60189D1")]
    [Address(RVA = "0x2636F14", Offset = "0x2636F14", VA = "0x2636F14")]
    public PartyTemplateSaveData()
    {
    }
  }
}
