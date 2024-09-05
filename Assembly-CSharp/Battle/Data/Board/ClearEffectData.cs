// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ClearEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002788")]
  public class ClearEffectData : EffectData
  {
    [Token(Token = "0x400A899")]
    [FieldOffset(Offset = "0x80")]
    public BattleEffectTypeEnum effType;
    [Token(Token = "0x400A89A")]
    [FieldOffset(Offset = "0x84")]
    public BattleBuffTagEnum buffTag;
    [Token(Token = "0x400A89B")]
    [FieldOffset(Offset = "0x88")]
    public bool isAllEffType;
    [Token(Token = "0x400A89C")]
    [FieldOffset(Offset = "0x89")]
    public bool isAllTag;
    [Token(Token = "0x400A89D")]
    [FieldOffset(Offset = "0x8A")]
    public bool isClearBuffEffect;
    [Token(Token = "0x400A89E")]
    [FieldOffset(Offset = "0x90")]
    private string buffTagText;

    [Token(Token = "0x170034E7")]
    public override string DisplayName
    {
      [Token(Token = "0x600F6C3"), Address(RVA = "0x1ED7D18", Offset = "0x1ED7D18", VA = "0x1ED7D18", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F6C4")]
    [Address(RVA = "0x1ED7D98", Offset = "0x1ED7D98", VA = "0x1ED7D98")]
    public static ClearEffectData Create(EffectSource source) => (ClearEffectData) null;

    [Token(Token = "0x600F6C5")]
    [Address(RVA = "0x1ED7E34", Offset = "0x1ED7E34", VA = "0x1ED7E34")]
    protected ClearEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F6C6")]
    [Address(RVA = "0x1ED801C", Offset = "0x1ED801C", VA = "0x1ED801C", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x600F6C7")]
    [Address(RVA = "0x1ED8078", Offset = "0x1ED8078", VA = "0x1ED8078")]
    public IEnumerable<EffectParameterData> GetSubjectEffectList(UnitParameterData target)
    {
      return (IEnumerable<EffectParameterData>) null;
    }

    [Token(Token = "0x600F6C8")]
    [Address(RVA = "0x1ED82BC", Offset = "0x1ED82BC", VA = "0x1ED82BC", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x2002789")]
    public enum ContextType
    {
      [Token(Token = "0x400A8A0")] BattleEffectTypeEnum,
      [Token(Token = "0x400A8A1")] BuffSkillTag,
    }
  }
}
