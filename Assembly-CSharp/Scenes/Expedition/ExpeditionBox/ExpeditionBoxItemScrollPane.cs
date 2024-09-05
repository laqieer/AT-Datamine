// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionBox.ExpeditionBoxItemScrollPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Expedition.ExpeditionBox
{
  [Token(Token = "0x2002CFE")]
  public class ExpeditionBoxItemScrollPane : UIScrollGridPane
  {
    [Token(Token = "0x400C0B3")]
    [FieldOffset(Offset = "0x88")]
    private IReadOnlyList<PlayerExpeditionBoxType> itemList;

    [Token(Token = "0x17003C6F")]
    public IReadOnlyList<PlayerExpeditionBoxType> ItemList
    {
      [Token(Token = "0x60119B8"), Address(RVA = "0x46A720C", Offset = "0x46A720C", VA = "0x46A720C")] set
      {
      }
    }

    [Token(Token = "0x60119B9")]
    [Address(RVA = "0x46A72C0", Offset = "0x46A72C0", VA = "0x46A72C0", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x60119BA")]
    [Address(RVA = "0x46A7350", Offset = "0x46A7350", VA = "0x46A7350")]
    protected void OnUpdateCell(ExpeditionBoxItemScrollCell cell, int index)
    {
    }

    [Token(Token = "0x60119BB")]
    [Address(RVA = "0x46A7550", Offset = "0x46A7550", VA = "0x46A7550")]
    public ExpeditionBoxItemScrollPane()
    {
    }
  }
}
