// Decompiled with JetBrains decompiler
// Type: Battle.Log.SkillEffectLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200251B")]
  public class SkillEffectLog : EffectLog
  {
    [Token(Token = "0x4009F67")]
    [FieldOffset(Offset = "0x28")]
    private WeakReference<EffectData> skillEffectRef;

    [Token(Token = "0x1700311E")]
    public EffectData SkillEffect
    {
      [Token(Token = "0x600E517"), Address(RVA = "0x479097C", Offset = "0x479097C", VA = "0x479097C")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x1700311F")]
    public bool IsHit
    {
      [Token(Token = "0x600E518"), Address(RVA = "0x47909DC", Offset = "0x47909DC", VA = "0x47909DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E519"), Address(RVA = "0x47909E4", Offset = "0x47909E4", VA = "0x47909E4")] private set
      {
      }
    }

    [Token(Token = "0x17003120")]
    public bool IsCritical
    {
      [Token(Token = "0x600E51A"), Address(RVA = "0x47909F0", Offset = "0x47909F0", VA = "0x47909F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E51B"), Address(RVA = "0x47909F8", Offset = "0x47909F8", VA = "0x47909F8")] private set
      {
      }
    }

    [Token(Token = "0x17003121")]
    public bool IsWeakness
    {
      [Token(Token = "0x600E51C"), Address(RVA = "0x4790A04", Offset = "0x4790A04", VA = "0x4790A04")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E51D"), Address(RVA = "0x4790A0C", Offset = "0x4790A0C", VA = "0x4790A0C")] private set
      {
      }
    }

    [Token(Token = "0x600E51E")]
    [Address(RVA = "0x4790A18", Offset = "0x4790A18", VA = "0x4790A18")]
    public SkillEffectLog(
      EffectData skillEffect,
      SkillEffectLogFlags flags,
      UnitParameterData target,
      UnitParameterChange begin,
      UnitParameterChange end)
    {
    }
  }
}
