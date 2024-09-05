// Decompiled with JetBrains decompiler
// Type: StaqData.BossChallengeTicketItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002011")]
  public sealed class BossChallengeTicketItem : Item
  {
    [Token(Token = "0x4008897")]
    [FieldOffset(Offset = "0x28")]
    private BossChallengeTicketData baseData;

    [Token(Token = "0x170027A3")]
    public BossChallengeTicketData MasterData
    {
      [Token(Token = "0x600BF03"), Address(RVA = "0x2004E30", Offset = "0x2004E30", VA = "0x2004E30")] get
      {
        return (BossChallengeTicketData) null;
      }
    }

    [Token(Token = "0x170027A4")]
    public override string Name
    {
      [Token(Token = "0x600BF04"), Address(RVA = "0x2004EDC", Offset = "0x2004EDC", VA = "0x2004EDC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027A5")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF05"), Address(RVA = "0x2004EF8", Offset = "0x2004EF8", VA = "0x2004EF8", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027A6")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF06"), Address(RVA = "0x2004F14", Offset = "0x2004F14", VA = "0x2004F14", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027A7")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF07"), Address(RVA = "0x2004F30", Offset = "0x2004F30", VA = "0x2004F30", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF08")]
    [Address(RVA = "0x2004F4C", Offset = "0x2004F4C", VA = "0x2004F4C")]
    private BossChallengeTicketItem()
    {
    }

    [Token(Token = "0x600BF09")]
    [Address(RVA = "0x2004F54", Offset = "0x2004F54", VA = "0x2004F54")]
    public void Apply(PlayerBossChallengeTicketType entity)
    {
    }

    [Token(Token = "0x600BF0A")]
    [Address(RVA = "0x2004F70", Offset = "0x2004F70", VA = "0x2004F70")]
    public static BossChallengeTicketItem CreateByServerData(PlayerBossChallengeTicketType entity)
    {
      return (BossChallengeTicketItem) null;
    }
  }
}
