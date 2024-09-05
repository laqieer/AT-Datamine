// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.InventoryUIScrollGridPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200043A")]
  public class InventoryUIScrollGridPane : 
    UIScrollGridPane,
    InventoryUIScrollGridItem.IInventoryUIItemEvent
  {
    [Token(Token = "0x40017A5")]
    [FieldOffset(Offset = "0x88")]
    private InventoryUIScrollGridPane.IEventHandler handler;

    [Token(Token = "0x170002C0")]
    public bool IsDisplayRemoveItem
    {
      [Token(Token = "0x60017ED"), Address(RVA = "0x248F2C0", Offset = "0x248F2C0", VA = "0x248F2C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60017EE"), Address(RVA = "0x248F2C8", Offset = "0x248F2C8", VA = "0x248F2C8")] set
      {
      }
    }

    [Token(Token = "0x60017EF")]
    [Address(RVA = "0x248F2D4", Offset = "0x248F2D4", VA = "0x248F2D4")]
    public void Load()
    {
    }

    [Token(Token = "0x60017F0")]
    [Address(RVA = "0x248F440", Offset = "0x248F440", VA = "0x248F440")]
    public void Register(InventoryUIScrollGridPane.IEventHandler handler)
    {
    }

    [Token(Token = "0x60017F1")]
    [Address(RVA = "0x248F448", Offset = "0x248F448", VA = "0x248F448")]
    private bool IsTopIndex(int index) => new bool();

    [Token(Token = "0x60017F2")]
    [Address(RVA = "0x248F454", Offset = "0x248F454", VA = "0x248F454", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x60017F3")]
    [Address(RVA = "0x248F78C", Offset = "0x248F78C", VA = "0x248F78C", Slot = "8")]
    protected override void OnEnableItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x60017F4")]
    [Address(RVA = "0x248F88C", Offset = "0x248F88C", VA = "0x248F88C", Slot = "9")]
    protected override void OnDisableItem(UIScrollGridItem item)
    {
    }

    [Token(Token = "0x60017F5")]
    [Address(RVA = "0x248F688", Offset = "0x248F688", VA = "0x248F688")]
    private void ItemUIHandling(
      InventoryUIScrollGridPane.OnHandling handling,
      UIScrollGridItem item,
      int index)
    {
    }

    [Token(Token = "0x60017F6")]
    [Address(RVA = "0x248F948", Offset = "0x248F948", VA = "0x248F948", Slot = "10")]
    private void UnitEquipmentView\u002EUI\u002EInventoryUIScrollGridItem\u002EIInventoryUIItemEvent\u002EOnSelect(
      InventoryUIScrollGridItem item)
    {
    }

    [Token(Token = "0x60017F7")]
    [Address(RVA = "0x248FA98", Offset = "0x248FA98", VA = "0x248FA98")]
    public InventoryUIScrollGridPane()
    {
    }

    [Token(Token = "0x200043B")]
    public interface IEventHandler : InventoryUIScrollGridPane.IInventoryUISelectEvent
    {
      [Token(Token = "0x60017F8")]
      void OnEnableItem(InventoryUIScrollGridItem item, int index);

      [Token(Token = "0x60017F9")]
      void OnModifyItem(InventoryUIScrollGridItem item, int index);
    }

    [Token(Token = "0x200043C")]
    public interface IInventoryUISelectEvent
    {
      [Token(Token = "0x60017FA")]
      void Detatch(ItemEasyDataUI ui);

      [Token(Token = "0x60017FB")]
      void Select(ItemEasyDataUI ui);
    }

    [Token(Token = "0x200043D")]
    private delegate void OnHandling(InventoryUIScrollGridItem inventoryItem, int index);
  }
}
