// Decompiled with JetBrains decompiler
// Type: StaqData.RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C4")]
  public class RewardData
  {
    [Token(Token = "0x17002A83")]
    public RewardTypeEnum Type
    {
      [Token(Token = "0x600C679"), Address(RVA = "0x1CD71D0", Offset = "0x1CD71D0", VA = "0x1CD71D0")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x17002A84")]
    public int ID
    {
      [Token(Token = "0x600C67A"), Address(RVA = "0x1CD71D8", Offset = "0x1CD71D8", VA = "0x1CD71D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A85")]
    public int Quantity
    {
      [Token(Token = "0x600C67B"), Address(RVA = "0x1CD71E0", Offset = "0x1CD71E0", VA = "0x1CD71E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C67C")]
    [Address(RVA = "0x1CD71E8", Offset = "0x1CD71E8", VA = "0x1CD71E8")]
    public RewardData(RewardTypeEnum type, int id, int quantity)
    {
    }

    [Token(Token = "0x600C67D")]
    [Address(RVA = "0x1CD7224", Offset = "0x1CD7224", VA = "0x1CD7224")]
    public ItemUtility.Parameter GetParameter() => new ItemUtility.Parameter();
  }
}
