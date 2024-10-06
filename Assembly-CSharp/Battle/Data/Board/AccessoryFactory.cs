// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.AccessoryFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002753")]
  public static class AccessoryFactory
  {
    [Token(Token = "0x600F552")]
    public static AccessoryData CreateFromUserAccessory<THandler>(
      string manageId,
      Accessory accessory,
      THandler handler)
      where THandler : IAccessoryDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (AccessoryData) null;
    }

    [Token(Token = "0x600F553")]
    public static AccessoryData CreateFromNpc<THandler>(
      string manageId,
      AccessoriesData master,
      int level,
      THandler handler)
      where THandler : IAccessoryDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (AccessoryData) null;
    }

    [Token(Token = "0x600F554")]
    public static AccessoryData CreateFromSchema<THandler>(staq.SaveSchema.AccessoryData schema, THandler handler) where THandler : IAccessoryDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (AccessoryData) null;
    }
  }
}
