// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GuildSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D25")]
  public class GuildSaveData
  {
    [Token(Token = "0x17005039")]
    public bool loaded
    {
      [Token(Token = "0x6018927"), Address(RVA = "0x2945080", Offset = "0x2945080", VA = "0x2945080")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018928"), Address(RVA = "0x2945088", Offset = "0x2945088", VA = "0x2945088")] private set
      {
      }
    }

    [Token(Token = "0x1700503A")]
    public string LastBulletinBoardId
    {
      [Token(Token = "0x6018929"), Address(RVA = "0x2945094", Offset = "0x2945094", VA = "0x2945094")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601892A"), Address(RVA = "0x294509C", Offset = "0x294509C", VA = "0x294509C")] set
      {
      }
    }

    [Token(Token = "0x1700503B")]
    public string LastChatMessageId
    {
      [Token(Token = "0x601892B"), Address(RVA = "0x29450A4", Offset = "0x29450A4", VA = "0x29450A4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601892C"), Address(RVA = "0x29450AC", Offset = "0x29450AC", VA = "0x29450AC")] set
      {
      }
    }

    [Token(Token = "0x1700503C")]
    public static string Path
    {
      [Token(Token = "0x601892D"), Address(RVA = "0x29450B4", Offset = "0x29450B4", VA = "0x29450B4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601892E")]
    [Address(RVA = "0x2945104", Offset = "0x2945104", VA = "0x2945104")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601892F")]
    [Address(RVA = "0x294514C", Offset = "0x294514C", VA = "0x294514C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018930")]
    [Address(RVA = "0x294517C", Offset = "0x294517C", VA = "0x294517C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018931")]
    [Address(RVA = "0x2945198", Offset = "0x2945198", VA = "0x2945198")]
    public void Load()
    {
    }

    [Token(Token = "0x6018932")]
    [Address(RVA = "0x294536C", Offset = "0x294536C", VA = "0x294536C")]
    public void Save()
    {
    }

    [Token(Token = "0x6018933")]
    [Address(RVA = "0x294546C", Offset = "0x294546C", VA = "0x294546C")]
    public GuildSaveData()
    {
    }
  }
}
