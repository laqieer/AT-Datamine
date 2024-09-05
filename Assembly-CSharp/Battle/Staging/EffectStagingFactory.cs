// Decompiled with JetBrains decompiler
// Type: Battle.Staging.EffectStagingFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200259E")]
  public class EffectStagingFactory
  {
    [Token(Token = "0x600E853")]
    [Address(RVA = "0x4C3FB40", Offset = "0x4C3FB40", VA = "0x4C3FB40")]
    public static StagingDirector.ISequence Create(
      IDirector mainDirector,
      UnitParameterData target,
      UnitParameterChange changeParam,
      EffectData effect,
      bool cameraMove,
      bool isManyEffect,
      UnitParameterData activator = null)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E854")]
    [Address(RVA = "0x4C3FDDC", Offset = "0x4C3FDDC", VA = "0x4C3FDDC")]
    private static IReadOnlyList<StagingDirector.ISequence> Create(
      IDirector mainDirector,
      UnitParameterData activator,
      IReadOnlyList<(UnitParameterData target, UnitParameterChange changeParam, EffectData effect)> info,
      bool cameraMove)
    {
      return (IReadOnlyList<StagingDirector.ISequence>) null;
    }

    [Token(Token = "0x600E855")]
    [Address(RVA = "0x4C4026C", Offset = "0x4C4026C", VA = "0x4C4026C")]
    public static IReadOnlyList<StagingDirector.ISequence> Create(
      IDirector mainDirector,
      SkillLogic.EffectedTriggerSkillContainer container,
      bool cameraMove)
    {
      return (IReadOnlyList<StagingDirector.ISequence>) null;
    }

    [Token(Token = "0x600E856")]
    [Address(RVA = "0x4C40448", Offset = "0x4C40448", VA = "0x4C40448")]
    public EffectStagingFactory()
    {
    }
  }
}
