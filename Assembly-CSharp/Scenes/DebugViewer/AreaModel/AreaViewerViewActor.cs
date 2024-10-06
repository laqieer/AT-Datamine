// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerViewActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F93")]
  internal class AreaViewerViewActor : AreaViewerViewBase
  {
    [Token(Token = "0x400CB93")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 offset;
    [Token(Token = "0x400CB94")]
    [FieldOffset(Offset = "0x34")]
    private float angle;
    [Token(Token = "0x400CB95")]
    [FieldOffset(Offset = "0x38")]
    private bool isTracking;
    [Token(Token = "0x400CB96")]
    [FieldOffset(Offset = "0x40")]
    public EventHandler<bool> OnChangeTracking;
    [Token(Token = "0x400CB97")]
    [FieldOffset(Offset = "0x48")]
    public EventHandler<Vector3> OnChangeOffset;
    [Token(Token = "0x400CB98")]
    [FieldOffset(Offset = "0x50")]
    public EventHandler<float> OnChangeAngle;

    [Token(Token = "0x60129AA")]
    [Address(RVA = "0x42920E4", Offset = "0x42920E4", VA = "0x42920E4", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x60129AB")]
    [Address(RVA = "0x429232C", Offset = "0x429232C", VA = "0x429232C")]
    public void SetOffset(Vector3 offset)
    {
    }

    [Token(Token = "0x60129AC")]
    [Address(RVA = "0x4292338", Offset = "0x4292338", VA = "0x4292338")]
    public void SetAngle(float angle)
    {
    }

    [Token(Token = "0x60129AD")]
    [Address(RVA = "0x4292340", Offset = "0x4292340", VA = "0x4292340")]
    public void SetTracking(bool active)
    {
    }

    [Token(Token = "0x60129AE")]
    [Address(RVA = "0x429234C", Offset = "0x429234C", VA = "0x429234C")]
    public AreaViewerViewActor()
    {
    }
  }
}
