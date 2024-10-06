// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017AF")]
  public class AreaStart : FreeMapProcess
  {
    [Token(Token = "0x4006898")]
    [FieldOffset(Offset = "0x38")]
    private StoryFreeActionSettingData settingData;

    [Token(Token = "0x600865F")]
    [Address(RVA = "0x40716B4", Offset = "0x40716B4", VA = "0x40716B4")]
    public AreaStart(FreeMapStateManager entity, StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6008660")]
    [Address(RVA = "0x40716DC", Offset = "0x40716DC", VA = "0x40716DC", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008661")]
    [Address(RVA = "0x4071710", Offset = "0x4071710", VA = "0x4071710")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6008662")]
    [Address(RVA = "0x40717A0", Offset = "0x40717A0", VA = "0x40717A0")]
    public static AreaLoad.LoadParam GetStartAreaLoadParam(
      StoryFreeActionSettingData currentSettingData)
    {
      return new AreaLoad.LoadParam();
    }

    [Token(Token = "0x6008663")]
    [Address(RVA = "0x407190C", Offset = "0x407190C", VA = "0x407190C")]
    public static (int, string, Vector3, float) GetStartPosition(
      StoryFreeActionSettingData currentSettingData)
    {
      return ();
    }

    [Token(Token = "0x6008664")]
    [Address(RVA = "0x4071E40", Offset = "0x4071E40", VA = "0x4071E40")]
    public static bool IsPreLoaded(FreeMapStateManager entity) => new bool();

    [Token(Token = "0x20017B0")]
    private class AreaLoaded : FreeMapProcess
    {
      [Token(Token = "0x6008665")]
      [Address(RVA = "0x4071E84", Offset = "0x4071E84", VA = "0x4071E84")]
      public AreaLoaded(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008666")]
      [Address(RVA = "0x4071E8C", Offset = "0x4071E8C", VA = "0x4071E8C", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
