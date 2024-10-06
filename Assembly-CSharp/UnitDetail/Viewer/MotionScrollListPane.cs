// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.MotionScrollListPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004AC")]
  public class MotionScrollListPane : UIScrollGridPane
  {
    [Token(Token = "0x40018AD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ViewerScrollListCell item;
    [Token(Token = "0x40018AE")]
    [FieldOffset(Offset = "0x90")]
    private IReadOnlyList<UnitViewerUtility.MotionInfo> motionList;
    [Token(Token = "0x40018AF")]
    [FieldOffset(Offset = "0x98")]
    private UnitViewerStateHandler stateHandler;

    [Token(Token = "0x6001A3E")]
    [Address(RVA = "0x2C256A0", Offset = "0x2C256A0", VA = "0x2C256A0")]
    public void Initialize(UnitViewerStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001A3F")]
    [Address(RVA = "0x2C256A8", Offset = "0x2C256A8", VA = "0x2C256A8", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001A40")]
    [Address(RVA = "0x2C256B4", Offset = "0x2C256B4", VA = "0x2C256B4")]
    public void AttachData(
      IReadOnlyList<UnitViewerUtility.MotionInfo> motionList)
    {
    }

    [Token(Token = "0x6001A41")]
    [Address(RVA = "0x2C25768", Offset = "0x2C25768", VA = "0x2C25768", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6001A42")]
    [Address(RVA = "0x2C257F8", Offset = "0x2C257F8", VA = "0x2C257F8")]
    private void OnModifyMotionItem(ViewerScrollListCell item, int index)
    {
    }

    [Token(Token = "0x6001A43")]
    [Address(RVA = "0x2C25A1C", Offset = "0x2C25A1C", VA = "0x2C25A1C")]
    public MotionScrollListPane()
    {
    }
  }
}
