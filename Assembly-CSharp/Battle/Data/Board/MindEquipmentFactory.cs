// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.MindEquipmentFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F4")]
  public static class MindEquipmentFactory
  {
    [Token(Token = "0x600F9A6")]
    public static MindEquipmentData CreateFromUserMindEquipment<THandler>(
      int id,
      MindEquipment mindEquipment,
      THandler handler)
      where THandler : IMindEquipmentDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (MindEquipmentData) null;
    }

    [Token(Token = "0x600F9A7")]
    public static MindEquipmentData CreateFromNpc<THandler>(
      int id,
      GameCore.MasterData.MindEquipmentData master,
      int level,
      THandler handler)
      where THandler : IMindEquipmentDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (MindEquipmentData) null;
    }

    [Token(Token = "0x600F9A8")]
    public static MindEquipmentData CreateFromSchema<THandler>(
      staq.SaveSchema.MindEquipmentData schema,
      THandler handler)
      where THandler : IMindEquipmentDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (MindEquipmentData) null;
    }

    [Token(Token = "0x600F9A9")]
    [Address(RVA = "0x44C3028", Offset = "0x44C3028", VA = "0x44C3028")]
    public static Sprite LoadIconImage(MindEquipmentData mindEquipment) => (Sprite) null;

    [Token(Token = "0x600F9AA")]
    [Address(RVA = "0x44C30CC", Offset = "0x44C30CC", VA = "0x44C30CC")]
    public static Sprite LoadThumbImage(MindEquipmentData mindEquipment) => (Sprite) null;

    [Token(Token = "0x600F9AB")]
    [Address(RVA = "0x44C3170", Offset = "0x44C3170", VA = "0x44C3170")]
    public static Sprite LoadRarityBase(RarityTypeEnum rarity) => (Sprite) null;

    [Token(Token = "0x600F9AC")]
    [Address(RVA = "0x44C325C", Offset = "0x44C325C", VA = "0x44C325C")]
    public static Sprite LoadRarityImage(RarityTypeEnum rarity) => (Sprite) null;
  }
}
