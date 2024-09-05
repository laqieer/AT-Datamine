// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031FD")]
  public class ItemListData
  {
    [Token(Token = "0x400D56F")]
    [FieldOffset(Offset = "0x10")]
    public readonly ItemTypeEnum ItemType;
    [Token(Token = "0x400D570")]
    [FieldOffset(Offset = "0x14")]
    public readonly PaymentTypeEnum PaymentType;
    [Token(Token = "0x400D571")]
    [FieldOffset(Offset = "0x18")]
    public readonly RarityTypeEnum RarityType;
    [Token(Token = "0x400D572")]
    [FieldOffset(Offset = "0x1C")]
    public readonly RewardTypeEnum RewardType;
    [Token(Token = "0x400D573")]
    [FieldOffset(Offset = "0x20")]
    public readonly int RewardTypeID;
    [Token(Token = "0x400D574")]
    [FieldOffset(Offset = "0x24")]
    public readonly int ID;

    [Token(Token = "0x1700410A")]
    public string Name
    {
      [Token(Token = "0x6013828"), Address(RVA = "0x49BE4A8", Offset = "0x49BE4A8", VA = "0x49BE4A8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6013829"), Address(RVA = "0x49BE4B0", Offset = "0x49BE4B0", VA = "0x49BE4B0")] private set
      {
      }
    }

    [Token(Token = "0x1700410B")]
    public int Amount
    {
      [Token(Token = "0x601382A"), Address(RVA = "0x49BE4B8", Offset = "0x49BE4B8", VA = "0x49BE4B8")] get
      {
        return new int();
      }
      [Token(Token = "0x601382B"), Address(RVA = "0x49BE4C0", Offset = "0x49BE4C0", VA = "0x49BE4C0")] private set
      {
      }
    }

    [Token(Token = "0x1700410C")]
    public int SellPrice
    {
      [Token(Token = "0x601382C"), Address(RVA = "0x49BE4C8", Offset = "0x49BE4C8", VA = "0x49BE4C8")] get
      {
        return new int();
      }
      [Token(Token = "0x601382D"), Address(RVA = "0x49BE4D0", Offset = "0x49BE4D0", VA = "0x49BE4D0")] private set
      {
      }
    }

    [Token(Token = "0x1700410D")]
    public bool CanSell
    {
      [Token(Token = "0x601382E"), Address(RVA = "0x49BE4D8", Offset = "0x49BE4D8", VA = "0x49BE4D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x601382F"), Address(RVA = "0x49BE4E0", Offset = "0x49BE4E0", VA = "0x49BE4E0")] private set
      {
      }
    }

    [Token(Token = "0x1700410E")]
    public int SellNum
    {
      [Token(Token = "0x6013830"), Address(RVA = "0x49BE4EC", Offset = "0x49BE4EC", VA = "0x49BE4EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6013831"), Address(RVA = "0x49BE4F4", Offset = "0x49BE4F4", VA = "0x49BE4F4")] private set
      {
      }
    }

    [Token(Token = "0x1700410F")]
    public string FlavorText
    {
      [Token(Token = "0x6013832"), Address(RVA = "0x49BE4FC", Offset = "0x49BE4FC", VA = "0x49BE4FC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6013833"), Address(RVA = "0x49BE504", Offset = "0x49BE504", VA = "0x49BE504")] private set
      {
      }
    }

    [Token(Token = "0x17004110")]
    public Sprite IconImage
    {
      [Token(Token = "0x6013834"), Address(RVA = "0x49BE50C", Offset = "0x49BE50C", VA = "0x49BE50C")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x6013835"), Address(RVA = "0x49BE514", Offset = "0x49BE514", VA = "0x49BE514")] private set
      {
      }
    }

    [Token(Token = "0x6013836")]
    [Address(RVA = "0x49BE51C", Offset = "0x49BE51C", VA = "0x49BE51C")]
    public ItemListData(
      string name,
      int amount,
      int sellPrice,
      bool canSell,
      string flavorText,
      ItemTypeEnum itemType,
      PaymentTypeEnum paymentType,
      RewardTypeEnum rewardType,
      int rewardTypeId,
      RarityTypeEnum rarityType,
      int id,
      Sprite iconImage)
    {
    }

    [Token(Token = "0x6013837")]
    [Address(RVA = "0x49BDA10", Offset = "0x49BDA10", VA = "0x49BDA10")]
    public void SetAmount(int amount)
    {
    }

    [Token(Token = "0x6013838")]
    [Address(RVA = "0x49BE5C0", Offset = "0x49BE5C0", VA = "0x49BE5C0")]
    public void SetSellNum(int sellNum)
    {
    }

    [Token(Token = "0x6013839")]
    [Address(RVA = "0x49BE5C8", Offset = "0x49BE5C8", VA = "0x49BE5C8", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x601383A")]
    [Address(RVA = "0x49BE7E4", Offset = "0x49BE7E4", VA = "0x49BE7E4", Slot = "0")]
    public override bool Equals(object obj) => new bool();
  }
}
