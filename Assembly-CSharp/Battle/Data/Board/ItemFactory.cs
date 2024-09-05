// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ItemFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027EF")]
  public static class ItemFactory
  {
    [Token(Token = "0x600F966")]
    public static ItemData Create<THandler>(int itemId, THandler handler) where THandler : ISkillDataHandler, IEffectHandler, IItemDataHandler, IBadStatusEffectHandler
    {
      return (ItemData) null;
    }

    [Token(Token = "0x600F967")]
    public static ItemData CreateFromSchema<Thandler>(staq.SaveSchema.ItemData schema, Thandler handler) where Thandler : ISkillDataHandler, IEffectHandler, IItemDataHandler, IBadStatusEffectHandler
    {
      return (ItemData) null;
    }

    [Token(Token = "0x600F968")]
    public static ItemParameterData CreateParameter<THandler>(
      int itemId,
      int amount,
      THandler handler,
      ISkillParameterDataHandler skillParamHandler)
      where THandler : ISkillDataHandler, IEffectHandler, IItemDataHandler, IBadStatusEffectHandler
    {
      return (ItemParameterData) null;
    }

    [Token(Token = "0x600F969")]
    public static ItemParameterData CreateParameterFromSchema<THandler>(
      staq.SaveSchema.ItemParameterData schema,
      THandler handler,
      IBoardDataHandler paramHandler)
      where THandler : IBattleDataHandler
    {
      return (ItemParameterData) null;
    }

    [Token(Token = "0x600F96A")]
    public static ItemParameterData Clone<THandler>(ItemParameterData src, THandler handler) where THandler : IUnitParameterDataHandler, ISkillParameterDataHandler
    {
      return (ItemParameterData) null;
    }
  }
}
