// Decompiled with JetBrains decompiler
// Type: StaqData.Wallet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002118")]
  public class Wallet
  {
    [Token(Token = "0x4008C7B")]
    [FieldOffset(Offset = "0x10")]
    private AmountManagement moneyEntity;

    [Token(Token = "0x17002C12")]
    public AmountManagement.IReadOnlyEntity Money
    {
      [Token(Token = "0x600CA5F"), Address(RVA = "0x1BA3B84", Offset = "0x1BA3B84", VA = "0x1BA3B84")] get
      {
        return (AmountManagement.IReadOnlyEntity) null;
      }
    }

    [Token(Token = "0x600CA60")]
    [Address(RVA = "0x1BA3B8C", Offset = "0x1BA3B8C", VA = "0x1BA3B8C")]
    public void Apply(PlayerType entity)
    {
    }

    [Token(Token = "0x600CA61")]
    [Address(RVA = "0x1BA3B90", Offset = "0x1BA3B90", VA = "0x1BA3B90")]
    public Wallet()
    {
    }
  }
}
