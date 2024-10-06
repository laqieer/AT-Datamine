// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaLoad
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Instance;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017AB")]
  public class AreaLoad : FreeMapProcess
  {
    [Token(Token = "0x4006888")]
    [FieldOffset(Offset = "0x38")]
    protected FreeMapCommonElement commonElement;
    [Token(Token = "0x4006889")]
    [FieldOffset(Offset = "0x40")]
    protected MovableMobManager movableMobManager;
    [Token(Token = "0x400688A")]
    [FieldOffset(Offset = "0x48")]
    private AreaLoad.LoadParam loadParam;
    [Token(Token = "0x400688B")]
    [FieldOffset(Offset = "0x70")]
    private bool loadedPlayer;
    [Token(Token = "0x400688C")]
    [FieldOffset(Offset = "0x71")]
    private bool loadedArea;
    [Token(Token = "0x400688D")]
    [FieldOffset(Offset = "0x72")]
    private bool loadedMinimap;
    [Token(Token = "0x400688E")]
    [FieldOffset(Offset = "0x73")]
    private bool createTransitionIcon;

    [Token(Token = "0x600864A")]
    [Address(RVA = "0x406F728", Offset = "0x406F728", VA = "0x406F728")]
    public AreaLoad(FreeMapStateManager entity, AreaLoad.LoadParam param)
    {
    }

    [Token(Token = "0x600864B")]
    [Address(RVA = "0x4070ACC", Offset = "0x4070ACC", VA = "0x4070ACC")]
    public AreaLoad(
      FreeMapStateManager entity,
      AreaLoad.LoadParam param,
      bool createTransitionIcon)
    {
    }

    [Token(Token = "0x600864C")]
    [Address(RVA = "0x4070B3C", Offset = "0x4070B3C", VA = "0x4070B3C", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600864D")]
    [Address(RVA = "0x4070BCC", Offset = "0x4070BCC", VA = "0x4070BCC")]
    private IEnumerator WaitAllTask() => (IEnumerator) null;

    [Token(Token = "0x600864E")]
    [Address(RVA = "0x4070C34", Offset = "0x4070C34", VA = "0x4070C34")]
    private void EnterFreeAction(AreaLoad.LoadParam loadParam, Canvas mainCanvas)
    {
    }

    [Token(Token = "0x600864F")]
    [Address(RVA = "0x40712BC", Offset = "0x40712BC", VA = "0x40712BC")]
    private void OnPlayerCreated(FreeMapPlayerInstance playerInstance)
    {
    }

    [Token(Token = "0x6008650")]
    [Address(RVA = "0x40712F8", Offset = "0x40712F8", VA = "0x40712F8")]
    private void OnLoadedArea()
    {
    }

    [Token(Token = "0x6008651")]
    [Address(RVA = "0x40714D0", Offset = "0x40714D0", VA = "0x40714D0")]
    private void OnLoadedMinimap()
    {
    }

    [Token(Token = "0x6008652")]
    [Address(RVA = "0x40711A0", Offset = "0x40711A0", VA = "0x40711A0")]
    private void MobSetting(int areaID)
    {
    }

    [Token(Token = "0x6008653")]
    [Address(RVA = "0x4071484", Offset = "0x4071484", VA = "0x4071484")]
    private void InteractEnableUI()
    {
    }

    [Token(Token = "0x6008654")]
    [Address(RVA = "0x40714DC", Offset = "0x40714DC", VA = "0x40714DC")]
    private void InteractDisableUI()
    {
    }

    [Token(Token = "0x20017AC")]
    public struct LoadParam
    {
      [Token(Token = "0x400688F")]
      [FieldOffset(Offset = "0x0")]
      public int toAreaID;
      [Token(Token = "0x4006890")]
      [FieldOffset(Offset = "0x8")]
      public string toStartAnchorName;
      [Token(Token = "0x4006891")]
      [FieldOffset(Offset = "0x10")]
      public Vector3 offset;
      [Token(Token = "0x4006892")]
      [FieldOffset(Offset = "0x1C")]
      public float rotationY;
      [Token(Token = "0x4006893")]
      [FieldOffset(Offset = "0x20")]
      public int characterSwitchPatternID;
    }
  }
}
