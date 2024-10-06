// Decompiled with JetBrains decompiler
// Type: Battle.Log.SkillLog
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
  [Token(Token = "0x200251D")]
  public class SkillLog : ActionLog
  {
    [Token(Token = "0x4009F6E")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<SkillParameterData> usedSkillParamRef;
    [Token(Token = "0x4009F6F")]
    [FieldOffset(Offset = "0x20")]
    protected WeakReference<UnitParameterData> mainTargetRef;
    [Token(Token = "0x4009F70")]
    [FieldOffset(Offset = "0x28")]
    protected List<EffectLog> effects;

    [Token(Token = "0x17003122")]
    public override LogType LogType
    {
      [Token(Token = "0x600E51F"), Address(RVA = "0x4790AEC", Offset = "0x4790AEC", VA = "0x4790AEC", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003123")]
    public SkillParameterData UsedSkillParam
    {
      [Token(Token = "0x600E520"), Address(RVA = "0x4790AF4", Offset = "0x4790AF4", VA = "0x4790AF4")] get
      {
        return (SkillParameterData) null;
      }
    }

    [Token(Token = "0x17003124")]
    public UnitParameterData MainTarget
    {
      [Token(Token = "0x600E521"), Address(RVA = "0x4790B54", Offset = "0x4790B54", VA = "0x4790B54")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17003125")]
    public IReadOnlyList<EffectLog> Effects
    {
      [Token(Token = "0x600E522"), Address(RVA = "0x4790BB4", Offset = "0x4790BB4", VA = "0x4790BB4")] get
      {
        return (IReadOnlyList<EffectLog>) null;
      }
    }

    [Token(Token = "0x600E523")]
    [Address(RVA = "0x4790BBC", Offset = "0x4790BBC", VA = "0x4790BBC")]
    public SkillLog(
      UnitParameterData unit,
      SkillParameterData usedSkill,
      UnitParameterData mainTarget,
      IReadOnlyList<EffectLog> effects)
    {
    }
  }
}
