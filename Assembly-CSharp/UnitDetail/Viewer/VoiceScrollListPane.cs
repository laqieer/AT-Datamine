// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.VoiceScrollListPane
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
  [Token(Token = "0x20004C6")]
  public class VoiceScrollListPane : UIScrollGridPane
  {
    [Token(Token = "0x4001942")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ViewerScrollListCell item;
    [Token(Token = "0x4001943")]
    [FieldOffset(Offset = "0x90")]
    private IReadOnlyList<UnitViewerUtility.VoiceInfo> voiceList;
    [Token(Token = "0x4001944")]
    [FieldOffset(Offset = "0x98")]
    private UnitViewerStateHandler stateHandler;

    [Token(Token = "0x6001B0A")]
    [Address(RVA = "0x2C2B528", Offset = "0x2C2B528", VA = "0x2C2B528")]
    public void Initialize(UnitViewerStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001B0B")]
    [Address(RVA = "0x2C2B530", Offset = "0x2C2B530", VA = "0x2C2B530", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001B0C")]
    [Address(RVA = "0x2C297EC", Offset = "0x2C297EC", VA = "0x2C297EC")]
    public void AttachData(
      IReadOnlyList<UnitViewerUtility.VoiceInfo> voiceList)
    {
    }

    [Token(Token = "0x6001B0D")]
    [Address(RVA = "0x2C2B53C", Offset = "0x2C2B53C", VA = "0x2C2B53C", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6001B0E")]
    [Address(RVA = "0x2C2B5CC", Offset = "0x2C2B5CC", VA = "0x2C2B5CC")]
    private void OnModifyVoiceItem(ViewerScrollListCell item, int index)
    {
    }

    [Token(Token = "0x6001B0F")]
    [Address(RVA = "0x2C2B7B4", Offset = "0x2C2B7B4", VA = "0x2C2B7B4")]
    public VoiceScrollListPane()
    {
    }
  }
}
