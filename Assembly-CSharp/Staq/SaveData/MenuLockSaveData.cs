// Decompiled with JetBrains decompiler
// Type: staq.SaveData.MenuLockSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D2E")]
  public class MenuLockSaveData
  {
    [Token(Token = "0x4010D1B")]
    [FieldOffset(Offset = "0x17")]
    private bool loaded;

    [Token(Token = "0x17005048")]
    public bool IsEventLock
    {
      [Token(Token = "0x601897B"), Address(RVA = "0x2948290", Offset = "0x2948290", VA = "0x2948290")] get
      {
        return new bool();
      }
      [Token(Token = "0x601897C"), Address(RVA = "0x2948298", Offset = "0x2948298", VA = "0x2948298")] set
      {
      }
    }

    [Token(Token = "0x17005049")]
    public bool IsGuildLock
    {
      [Token(Token = "0x601897D"), Address(RVA = "0x29482A4", Offset = "0x29482A4", VA = "0x29482A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x601897E"), Address(RVA = "0x29482AC", Offset = "0x29482AC", VA = "0x29482AC")] set
      {
      }
    }

    [Token(Token = "0x1700504A")]
    public bool IsArenaLock
    {
      [Token(Token = "0x601897F"), Address(RVA = "0x29482B8", Offset = "0x29482B8", VA = "0x29482B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018980"), Address(RVA = "0x29482C0", Offset = "0x29482C0", VA = "0x29482C0")] set
      {
      }
    }

    [Token(Token = "0x1700504B")]
    public bool IsStoryChartLock
    {
      [Token(Token = "0x6018981"), Address(RVA = "0x29482CC", Offset = "0x29482CC", VA = "0x29482CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018982"), Address(RVA = "0x29482D4", Offset = "0x29482D4", VA = "0x29482D4")] set
      {
      }
    }

    [Token(Token = "0x1700504C")]
    public bool IsStoryShopLock
    {
      [Token(Token = "0x6018983"), Address(RVA = "0x29482E0", Offset = "0x29482E0", VA = "0x29482E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018984"), Address(RVA = "0x29482E8", Offset = "0x29482E8", VA = "0x29482E8")] set
      {
      }
    }

    [Token(Token = "0x1700504D")]
    public bool IsMainLock
    {
      [Token(Token = "0x6018985"), Address(RVA = "0x29482F4", Offset = "0x29482F4", VA = "0x29482F4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018986"), Address(RVA = "0x29482FC", Offset = "0x29482FC", VA = "0x29482FC")] set
      {
      }
    }

    [Token(Token = "0x1700504E")]
    public bool IsMain2Lock
    {
      [Token(Token = "0x6018987"), Address(RVA = "0x2948308", Offset = "0x2948308", VA = "0x2948308")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018988"), Address(RVA = "0x2948310", Offset = "0x2948310", VA = "0x2948310")] set
      {
      }
    }

    [Token(Token = "0x1700504F")]
    private static string Path
    {
      [Token(Token = "0x6018989"), Address(RVA = "0x294831C", Offset = "0x294831C", VA = "0x294831C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601898A")]
    [Address(RVA = "0x294836C", Offset = "0x294836C", VA = "0x294836C")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601898B")]
    [Address(RVA = "0x29483B4", Offset = "0x29483B4", VA = "0x29483B4")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x601898C")]
    [Address(RVA = "0x29483E4", Offset = "0x29483E4", VA = "0x29483E4")]
    public void Delete()
    {
    }

    [Token(Token = "0x601898D")]
    [Address(RVA = "0x2948400", Offset = "0x2948400", VA = "0x2948400")]
    public void Load()
    {
    }

    [Token(Token = "0x601898E")]
    [Address(RVA = "0x29486C0", Offset = "0x29486C0", VA = "0x29486C0")]
    public void Save()
    {
    }

    [Token(Token = "0x601898F")]
    [Address(RVA = "0x29487E0", Offset = "0x29487E0", VA = "0x29487E0")]
    public MenuLockSaveData()
    {
    }
  }
}
