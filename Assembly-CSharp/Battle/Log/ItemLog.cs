// Decompiled with JetBrains decompiler
// Type: Battle.Log.ItemLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002510")]
  public class ItemLog : ActionLog
  {
    [Token(Token = "0x4009F48")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<ItemParameterData> usedItemParamRef;
    [Token(Token = "0x4009F49")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<UnitParameterData> mainTargetRef;
    [Token(Token = "0x4009F4A")]
    [FieldOffset(Offset = "0x28")]
    private List<EffectLog> effects;

    [Token(Token = "0x17003104")]
    public override LogType LogType
    {
      [Token(Token = "0x600E4BC"), Address(RVA = "0x478911C", Offset = "0x478911C", VA = "0x478911C", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003105")]
    public ItemParameterData UsedItemParam
    {
      [Token(Token = "0x600E4BD"), Address(RVA = "0x4789124", Offset = "0x4789124", VA = "0x4789124")] get
      {
        return (ItemParameterData) null;
      }
    }

    [Token(Token = "0x17003106")]
    public UnitParameterData MainTarget
    {
      [Token(Token = "0x600E4BE"), Address(RVA = "0x4789184", Offset = "0x4789184", VA = "0x4789184")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17003107")]
    public IReadOnlyList<EffectLog> Effects
    {
      [Token(Token = "0x600E4BF"), Address(RVA = "0x47891E4", Offset = "0x47891E4", VA = "0x47891E4")] get
      {
        return (IReadOnlyList<EffectLog>) null;
      }
    }

    [Token(Token = "0x600E4C0")]
    [Address(RVA = "0x47891EC", Offset = "0x47891EC", VA = "0x47891EC")]
    public ItemLog(
      UnitParameterData unit,
      ItemParameterData usedItem,
      UnitParameterData mainTarget,
      IReadOnlyList<SkillEffectLog> effects)
    {
    }
  }
}
