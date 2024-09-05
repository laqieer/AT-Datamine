// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001999")]
  public class FgGIDMissionListItemPresenter : IFgGIDMissionListItemPresenter
  {
    [Token(Token = "0x4006DE1")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDMissionListItemView view;
    [Token(Token = "0x4006DE2")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDAppData appData;
    [Token(Token = "0x4006DE3")]
    [FieldOffset(Offset = "0x20")]
    private FgGIDMissionData missionData;
    [Token(Token = "0x4006DE4")]
    [FieldOffset(Offset = "0x28")]
    private FgGIDMissionLoader loader;
    [Token(Token = "0x4006DE5")]
    [FieldOffset(Offset = "0x30")]
    public Action<FgGIDMissionData> ReceiveButtonClickEvent;
    [Token(Token = "0x4006DE6")]
    [FieldOffset(Offset = "0x38")]
    public Action<FgGIDMissionData> ChallengeButtonClickEvent;

    [Token(Token = "0x600920E")]
    [Address(RVA = "0x4D0E8C4", Offset = "0x4D0E8C4", VA = "0x4D0E8C4")]
    public FgGIDMissionListItemPresenter(
      FgGIDMissionListItemView view,
      FgGIDAppData appData,
      FgGIDMissionData missionData,
      FgGIDMissionLoader loader)
    {
    }

    [Token(Token = "0x600920F")]
    [Address(RVA = "0x4D0E904", Offset = "0x4D0E904", VA = "0x4D0E904", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6009210")]
    [Address(RVA = "0x4D0EC60", Offset = "0x4D0EC60", VA = "0x4D0EC60", Slot = "5")]
    public void ReceiveButtonClicked()
    {
    }

    [Token(Token = "0x6009211")]
    [Address(RVA = "0x4D0EC80", Offset = "0x4D0EC80", VA = "0x4D0EC80", Slot = "6")]
    public void ChallengeButtonClicked()
    {
    }
  }
}
