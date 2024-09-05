// Decompiled with JetBrains decompiler
// Type: StaqData.AmountManagement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FE2")]
  public class AmountManagement : AmountManagement.IReadOnlyEntity
  {
    [Token(Token = "0x1700272E")]
    public int Value
    {
      [Token(Token = "0x600BD5E"), Address(RVA = "0x1E58000", Offset = "0x1E58000", VA = "0x1E58000", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD5F"), Address(RVA = "0x1E58008", Offset = "0x1E58008", VA = "0x1E58008")] private set
      {
      }
    }

    [Token(Token = "0x600BD60")]
    [Address(RVA = "0x1E58010", Offset = "0x1E58010", VA = "0x1E58010")]
    public void Update(int value)
    {
    }

    [Token(Token = "0x600BD61")]
    [Address(RVA = "0x1E58018", Offset = "0x1E58018", VA = "0x1E58018", Slot = "5")]
    public bool IsEnough(int decrease) => new bool();

    [Token(Token = "0x600BD62")]
    [Address(RVA = "0x1E5802C", Offset = "0x1E5802C", VA = "0x1E5802C")]
    public AmountManagement()
    {
    }

    [Token(Token = "0x2001FE3")]
    public interface IReadOnlyEntity
    {
      [Token(Token = "0x1700272F")]
      int Value { [Token(Token = "0x600BD63")] get; }

      [Token(Token = "0x600BD64")]
      bool IsEnough(int decrease);
    }
  }
}
