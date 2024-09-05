// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.EquipmentSaleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032BD")]
  public class EquipmentSaleUtility
  {
    [Token(Token = "0x6013DB5")]
    [Address(RVA = "0x1AE5918", Offset = "0x1AE5918", VA = "0x1AE5918")]
    public static int GetPrice(int lv, ItemTypeEnum type, RarityTypeEnum rarity) => new int();

    [Token(Token = "0x6013DB6")]
    [Address(RVA = "0x1AE5A60", Offset = "0x1AE5A60", VA = "0x1AE5A60")]
    public static RewardTypeEnum GetRewardType(ItemTypeEnum type, RarityTypeEnum rarity)
    {
      return new RewardTypeEnum();
    }

    [Token(Token = "0x6013DB7")]
    [Address(RVA = "0x1AE5BA8", Offset = "0x1AE5BA8", VA = "0x1AE5BA8")]
    public static int GetID(ItemTypeEnum type, RarityTypeEnum rarity) => new int();

    [Token(Token = "0x6013DB8")]
    [Address(RVA = "0x1AE5CF0", Offset = "0x1AE5CF0", VA = "0x1AE5CF0")]
    public EquipmentSaleUtility()
    {
    }
  }
}
