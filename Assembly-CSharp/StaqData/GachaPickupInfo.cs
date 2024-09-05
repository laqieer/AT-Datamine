// Decompiled with JetBrains decompiler
// Type: StaqData.GachaPickupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200212C")]
  public class GachaPickupInfo
  {
    [Token(Token = "0x17002C59")]
    public int Id
    {
      [Token(Token = "0x600CB1A"), Address(RVA = "0x1BA8668", Offset = "0x1BA8668", VA = "0x1BA8668")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB1B"), Address(RVA = "0x1BA8670", Offset = "0x1BA8670", VA = "0x1BA8670")] set
      {
      }
    }

    [Token(Token = "0x17002C5A")]
    public int GroupId
    {
      [Token(Token = "0x600CB1C"), Address(RVA = "0x1BA8678", Offset = "0x1BA8678", VA = "0x1BA8678")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB1D"), Address(RVA = "0x1BA8680", Offset = "0x1BA8680", VA = "0x1BA8680")] set
      {
      }
    }

    [Token(Token = "0x17002C5B")]
    public int BackgroundResourceId
    {
      [Token(Token = "0x600CB1E"), Address(RVA = "0x1BA8688", Offset = "0x1BA8688", VA = "0x1BA8688")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB1F"), Address(RVA = "0x1BA8690", Offset = "0x1BA8690", VA = "0x1BA8690")] set
      {
      }
    }

    [Token(Token = "0x17002C5C")]
    public int ViewPriority
    {
      [Token(Token = "0x600CB20"), Address(RVA = "0x1BA8698", Offset = "0x1BA8698", VA = "0x1BA8698")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB21"), Address(RVA = "0x1BA86A0", Offset = "0x1BA86A0", VA = "0x1BA86A0")] set
      {
      }
    }

    [Token(Token = "0x17002C5D")]
    public int RewardTypeId
    {
      [Token(Token = "0x600CB22"), Address(RVA = "0x1BA86A8", Offset = "0x1BA86A8", VA = "0x1BA86A8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB23"), Address(RVA = "0x1BA86B0", Offset = "0x1BA86B0", VA = "0x1BA86B0")] set
      {
      }
    }

    [Token(Token = "0x17002C5E")]
    public int RewardId
    {
      [Token(Token = "0x600CB24"), Address(RVA = "0x1BA86B8", Offset = "0x1BA86B8", VA = "0x1BA86B8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB25"), Address(RVA = "0x1BA86C0", Offset = "0x1BA86C0", VA = "0x1BA86C0")] set
      {
      }
    }

    [Token(Token = "0x17002C5F")]
    public int RewardQuantity
    {
      [Token(Token = "0x600CB26"), Address(RVA = "0x1BA86C8", Offset = "0x1BA86C8", VA = "0x1BA86C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB27"), Address(RVA = "0x1BA86D0", Offset = "0x1BA86D0", VA = "0x1BA86D0")] set
      {
      }
    }

    [Token(Token = "0x600CB28")]
    [Address(RVA = "0x1BA86D8", Offset = "0x1BA86D8", VA = "0x1BA86D8")]
    public static GachaPickupInfo CreateFromServerData(G0000GachaNewEntityType serverData)
    {
      return (GachaPickupInfo) null;
    }

    [Token(Token = "0x600CB29")]
    [Address(RVA = "0x1BA4EC8", Offset = "0x1BA4EC8", VA = "0x1BA4EC8")]
    public static List<GachaPickupInfo> CreateFromServerData(
      IEnumerable<G0000GachaNewEntityType> serverData)
    {
      return (List<GachaPickupInfo>) null;
    }

    [Token(Token = "0x600CB2A")]
    [Address(RVA = "0x1BA875C", Offset = "0x1BA875C", VA = "0x1BA875C")]
    public GachaPickupInfo()
    {
    }
  }
}
