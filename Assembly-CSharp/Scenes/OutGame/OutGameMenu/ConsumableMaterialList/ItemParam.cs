// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BEC")]
  public class ItemParam
  {
    [Token(Token = "0x17004C7D")]
    public ItemTypeEnum itemType
    {
      [Token(Token = "0x60178DB"), Address(RVA = "0x237A02C", Offset = "0x237A02C", VA = "0x237A02C")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17004C7E")]
    public int itemId
    {
      [Token(Token = "0x60178DC"), Address(RVA = "0x237A034", Offset = "0x237A034", VA = "0x237A034")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004C7F")]
    public int quantity
    {
      [Token(Token = "0x60178DD"), Address(RVA = "0x237A03C", Offset = "0x237A03C", VA = "0x237A03C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60178DE")]
    [Address(RVA = "0x237A044", Offset = "0x237A044", VA = "0x237A044")]
    public ItemParam(ItemTypeEnum itemType, int itemId, int quantity)
    {
    }
  }
}
