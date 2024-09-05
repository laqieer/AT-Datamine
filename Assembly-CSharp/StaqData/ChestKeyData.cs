// Decompiled with JetBrains decompiler
// Type: StaqData.ChestKeyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020A5")]
  public class ChestKeyData
  {
    [Token(Token = "0x17002A31")]
    public int KeyItemID
    {
      [Token(Token = "0x600C57F"), Address(RVA = "0x1A03C40", Offset = "0x1A03C40", VA = "0x1A03C40")] get
      {
        return new int();
      }
      [Token(Token = "0x600C580"), Address(RVA = "0x1A03C48", Offset = "0x1A03C48", VA = "0x1A03C48")] private set
      {
      }
    }

    [Token(Token = "0x17002A32")]
    public int KeyItemCount
    {
      [Token(Token = "0x600C581"), Address(RVA = "0x1A03C50", Offset = "0x1A03C50", VA = "0x1A03C50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A33")]
    public string KeyItemName
    {
      [Token(Token = "0x600C582"), Address(RVA = "0x1A03C80", Offset = "0x1A03C80", VA = "0x1A03C80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C583"), Address(RVA = "0x1A03C88", Offset = "0x1A03C88", VA = "0x1A03C88")] private set
      {
      }
    }

    [Token(Token = "0x600C584")]
    [Address(RVA = "0x1A03C90", Offset = "0x1A03C90", VA = "0x1A03C90")]
    public ChestKeyData(ExpendablesData data)
    {
    }

    [Token(Token = "0x600C585")]
    [Address(RVA = "0x1A03C68", Offset = "0x1A03C68", VA = "0x1A03C68")]
    private int GetUserCount() => new int();

    [Token(Token = "0x600C586")]
    [Address(RVA = "0x1A03CCC", Offset = "0x1A03CCC", VA = "0x1A03CCC")]
    private Expendable GetUserData() => (Expendable) null;
  }
}
