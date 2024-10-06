// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PlayerCharacterSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D37")]
  public class PlayerCharacterSaveData
  {
    [Token(Token = "0x4010D3A")]
    [FieldOffset(Offset = "0x10")]
    private string name;
    [Token(Token = "0x4010D3B")]
    [FieldOffset(Offset = "0x18")]
    public int AvatarId;
    [Token(Token = "0x4010D3C")]
    [FieldOffset(Offset = "0x1C")]
    public bool IsAccountRecreate;
    [Token(Token = "0x4010D3D")]
    [FieldOffset(Offset = "0x1D")]
    public bool IsIntroChapterFinished;
    [Token(Token = "0x4010D3E")]
    [FieldOffset(Offset = "0x1E")]
    public bool IsEnteredHomeTutorial;

    [Token(Token = "0x17005065")]
    public string Name
    {
      [Token(Token = "0x60189FA"), Address(RVA = "0x2638940", Offset = "0x2638940", VA = "0x2638940")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60189FB"), Address(RVA = "0x2638994", Offset = "0x2638994", VA = "0x2638994")] set
      {
      }
    }

    [Token(Token = "0x17005066")]
    private static string Path
    {
      [Token(Token = "0x60189FC"), Address(RVA = "0x26389FC", Offset = "0x26389FC", VA = "0x26389FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189FD")]
    [Address(RVA = "0x2638A4C", Offset = "0x2638A4C", VA = "0x2638A4C")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189FE")]
    [Address(RVA = "0x2638A94", Offset = "0x2638A94", VA = "0x2638A94")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189FF")]
    [Address(RVA = "0x2638AC0", Offset = "0x2638AC0", VA = "0x2638AC0")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A00")]
    [Address(RVA = "0x2638AD8", Offset = "0x2638AD8", VA = "0x2638AD8")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A01")]
    [Address(RVA = "0x2638CB8", Offset = "0x2638CB8", VA = "0x2638CB8")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A02")]
    [Address(RVA = "0x2638E04", Offset = "0x2638E04", VA = "0x2638E04")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x6018A03")]
    [Address(RVA = "0x2638E08", Offset = "0x2638E08", VA = "0x2638E08")]
    public void SetAvatarId(int id)
    {
    }

    [Token(Token = "0x6018A04")]
    [Address(RVA = "0x2638E10", Offset = "0x2638E10", VA = "0x2638E10")]
    public void SetIsIntroChapterFinished(bool value)
    {
    }

    [Token(Token = "0x6018A05")]
    [Address(RVA = "0x2638E28", Offset = "0x2638E28", VA = "0x2638E28")]
    public void SetIsEnteredHomeTutorial(bool value)
    {
    }

    [Token(Token = "0x6018A06")]
    [Address(RVA = "0x2638CA4", Offset = "0x2638CA4", VA = "0x2638CA4")]
    public bool IsExist() => new bool();

    [Token(Token = "0x6018A07")]
    [Address(RVA = "0x2638E34", Offset = "0x2638E34", VA = "0x2638E34")]
    public bool IsEnableTutorialSkip() => new bool();

    [Token(Token = "0x6018A08")]
    [Address(RVA = "0x2638EC8", Offset = "0x2638EC8", VA = "0x2638EC8")]
    public PlayerCharacterSaveData()
    {
    }
  }
}
