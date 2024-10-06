// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ModifierEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027C6")]
  public abstract class ModifierEffectData : EffectData
  {
    [Token(Token = "0x400A976")]
    [FieldOffset(Offset = "0x80")]
    protected Dictionary<int, string> parameterTextMap;
    [Token(Token = "0x400A977")]
    [FieldOffset(Offset = "0x88")]
    protected Dictionary<int, IEffectValue> ModifierDic;

    [Token(Token = "0x600F88E")]
    [Address(RVA = "0x44BB920", Offset = "0x44BB920", VA = "0x44BB920")]
    public List<(int, IEffectValue)> GetModifiers() => (List<(int, IEffectValue)>) null;

    [Token(Token = "0x170035A7")]
    public BattleIconTypeEnum StatusBattleIconType
    {
      [Token(Token = "0x600F88F"), Address(RVA = "0x44BBB58", Offset = "0x44BBB58", VA = "0x44BBB58")] get
      {
        return new BattleIconTypeEnum();
      }
    }

    [Token(Token = "0x170035A8")]
    public BattleEffectValueTypeEnum BaseValueType
    {
      [Token(Token = "0x600F890"), Address(RVA = "0x44BBB78", Offset = "0x44BBB78", VA = "0x44BBB78")] get
      {
        return new BattleEffectValueTypeEnum();
      }
      [Token(Token = "0x600F891"), Address(RVA = "0x44BBB80", Offset = "0x44BBB80", VA = "0x44BBB80")] set
      {
      }
    }

    [Token(Token = "0x170035A9")]
    protected abstract ModifierEffectData.IContextIndexInfo BaseContextInfo { [Token(Token = "0x600F892")] get; }

    [Token(Token = "0x600F893")]
    [Address(RVA = "0x44BAB0C", Offset = "0x44BAB0C", VA = "0x44BAB0C")]
    protected ModifierEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F894")]
    [Address(RVA = "0x44BBB88", Offset = "0x44BBB88", VA = "0x44BBB88", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F895")]
    [Address(RVA = "0x44BBC08", Offset = "0x44BBC08", VA = "0x44BBC08")]
    public IEffectValue GetEffectValue(int key) => (IEffectValue) null;

    [Token(Token = "0x600F896")]
    [Address(RVA = "0x44BBCB8", Offset = "0x44BBCB8", VA = "0x44BBCB8", Slot = "9")]
    public virtual string GetDisplayName(int key = 0) => (string) null;

    [Token(Token = "0x600F897")]
    protected abstract void CreateParameterTextMap();

    [Token(Token = "0x600F898")]
    [Address(RVA = "0x44BAC88", Offset = "0x44BAC88", VA = "0x44BAC88")]
    protected void AddModifierDic(int key, int value)
    {
    }

    [Token(Token = "0x20027C7")]
    protected interface IContextIndexInfo
    {
      [Token(Token = "0x170035AA")]
      int ValueType { [Token(Token = "0x600F899")] get; }
    }
  }
}
