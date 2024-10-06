// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardBulkReleasePopupCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003310")]
  public class AbilityBoardBulkReleasePopupCreator
  {
    [Token(Token = "0x400DC9E")]
    [FieldOffset(Offset = "0x10")]
    private AbilityBoardBulkReleasePopup bulkReleasePopup;
    [Token(Token = "0x400DC9F")]
    [FieldOffset(Offset = "0x18")]
    private IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DCA0")]
    [FieldOffset(Offset = "0x20")]
    private IItemDetailController itemDetailController;
    [Token(Token = "0x400DCA1")]
    [FieldOffset(Offset = "0x28")]
    private Style style;
    [Token(Token = "0x400DCA2")]
    [FieldOffset(Offset = "0x30")]
    private Action<List<AbilityBoardReleaseNodeData>> onNodeUnlockAction;

    [Token(Token = "0x6014110")]
    [Address(RVA = "0x20BC1D8", Offset = "0x20BC1D8", VA = "0x20BC1D8")]
    public AbilityBoardBulkReleasePopupCreator(
      Style style,
      IAbilityBoardIconLoader iconLoader,
      IItemDetailController itemDetailController,
      Action<List<AbilityBoardReleaseNodeData>> onNodeUnlockAction)
    {
    }

    [Token(Token = "0x6014111")]
    [Address(RVA = "0x20BC218", Offset = "0x20BC218", VA = "0x20BC218")]
    public void Show(List<AbilityBoardReleaseNodeData> data, Action onClose = null)
    {
    }

    [Token(Token = "0x6014112")]
    [Address(RVA = "0x20BC434", Offset = "0x20BC434", VA = "0x20BC434")]
    public void Close()
    {
    }

    [Token(Token = "0x6014113")]
    [Address(RVA = "0x20BC21C", Offset = "0x20BC21C", VA = "0x20BC21C")]
    private void Create(List<AbilityBoardReleaseNodeData> data, Action onClose = null)
    {
    }
  }
}
