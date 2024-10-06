// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.ViewerSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CC")]
  [Serializable]
  public class ViewerSettings
  {
    [Token(Token = "0x4001651")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float doubleTapTime;
    [Token(Token = "0x4001652")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Viewer3DSetting viewer3DSetting;
    [Token(Token = "0x4001653")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Viewer2DSetting viewer2DSetting;
    [Token(Token = "0x4001654")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ViewerDotSetting viewerDotSetting;

    [Token(Token = "0x1700025E")]
    public float DoubleTapTime
    {
      [Token(Token = "0x6001621"), Address(RVA = "0x2485914", Offset = "0x2485914", VA = "0x2485914")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700025F")]
    public Viewer3DSetting Viewer3DSetting
    {
      [Token(Token = "0x6001622"), Address(RVA = "0x248591C", Offset = "0x248591C", VA = "0x248591C")] get
      {
        return (Viewer3DSetting) null;
      }
    }

    [Token(Token = "0x17000260")]
    public Viewer2DSetting Viewer2DSetting
    {
      [Token(Token = "0x6001623"), Address(RVA = "0x2485924", Offset = "0x2485924", VA = "0x2485924")] get
      {
        return (Viewer2DSetting) null;
      }
    }

    [Token(Token = "0x17000261")]
    public ViewerDotSetting ViewerDotSetting
    {
      [Token(Token = "0x6001624"), Address(RVA = "0x248592C", Offset = "0x248592C", VA = "0x248592C")] get
      {
        return (ViewerDotSetting) null;
      }
    }

    [Token(Token = "0x6001625")]
    [Address(RVA = "0x2485934", Offset = "0x2485934", VA = "0x2485934")]
    public ViewerSettings()
    {
    }
  }
}
