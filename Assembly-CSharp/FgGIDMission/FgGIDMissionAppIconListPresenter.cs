// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionAppIconListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001995")]
  public class FgGIDMissionAppIconListPresenter : IFgGIDMissionAppIconListPresenter
  {
    [Token(Token = "0x4006DD9")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDMissionAppIconListView view;
    [Token(Token = "0x4006DDA")]
    [FieldOffset(Offset = "0x18")]
    private List<FgGIDAppData> appDatas;
    [Token(Token = "0x4006DDB")]
    [FieldOffset(Offset = "0x20")]
    private FgGIDMissionDataManager manager;
    [Token(Token = "0x4006DDC")]
    [FieldOffset(Offset = "0x28")]
    private FgGIDMissionLoader loader;

    [Token(Token = "0x6009201")]
    [Address(RVA = "0x4D0C5FC", Offset = "0x4D0C5FC", VA = "0x4D0C5FC")]
    public FgGIDMissionAppIconListPresenter(
      FgGIDMissionAppIconListView view,
      FgGIDMissionDataManager manager,
      FgGIDMissionLoader loader)
    {
    }

    [Token(Token = "0x6009202")]
    [Address(RVA = "0x4D0E0F0", Offset = "0x4D0E0F0", VA = "0x4D0E0F0", Slot = "6")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6009203")]
    [Address(RVA = "0x4D0E3F4", Offset = "0x4D0E3F4", VA = "0x4D0E3F4", Slot = "4")]
    public void AssignListItemPresenter(FgGIDMissionAppIconView view, int index)
    {
    }

    [Token(Token = "0x6009204")]
    [Address(RVA = "0x4D0E594", Offset = "0x4D0E594", VA = "0x4D0E594", Slot = "5")]
    public void AssignBlankListItemPresenter(FgGIDMissionAppIconView view, int index)
    {
    }
  }
}
