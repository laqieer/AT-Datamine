// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaTutorialStart
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
  [Token(Token = "0x20017B2")]
  public class AreaTutorialStart : FreeMapProcess
  {
    [Token(Token = "0x400689C")]
    [FieldOffset(Offset = "0x38")]
    private StoryFreeActionSettingData settingData;
    [Token(Token = "0x400689D")]
    [FieldOffset(Offset = "0x40")]
    private int playerLabel;

    [Token(Token = "0x600866D")]
    [Address(RVA = "0x4072204", Offset = "0x4072204", VA = "0x4072204")]
    public AreaTutorialStart(
      FreeMapStateManager entity,
      StoryFreeActionSettingData settingData,
      int playerLabel)
    {
    }

    [Token(Token = "0x600866E")]
    [Address(RVA = "0x4072234", Offset = "0x4072234", VA = "0x4072234", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600866F")]
    [Address(RVA = "0x4072268", Offset = "0x4072268", VA = "0x4072268")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6008670")]
    [Address(RVA = "0x40722F8", Offset = "0x40722F8", VA = "0x40722F8")]
    public static (int, string, Vector3, float) GetStartPosition(
      StoryFreeActionSettingData currentSettingData)
    {
      return ();
    }

    [Token(Token = "0x20017B3")]
    private class AreaLoaded : FreeMapProcess
    {
      [Token(Token = "0x6008671")]
      [Address(RVA = "0x40723A8", Offset = "0x40723A8", VA = "0x40723A8")]
      public AreaLoaded(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008672")]
      [Address(RVA = "0x40723B0", Offset = "0x40723B0", VA = "0x40723B0", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
