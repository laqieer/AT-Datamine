// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.State.SubState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView.State
{
  [Token(Token = "0x2000488")]
  public abstract class SubState : 
    StateMachineState<UnitEquipmentModify>,
    InventoryUIScrollGridPane.IEventHandler,
    InventoryUIScrollGridPane.IInventoryUISelectEvent,
    ItemEasyDataUI.IItemSelectLongTapEvent,
    WeaponsEquipDetailUI.IEvent
  {
    [Token(Token = "0x6001952")]
    protected abstract StateHandler.SubStateIndex GetSubStateIndex();

    [Token(Token = "0x17000314")]
    public virtual bool IsLockedPanelChange
    {
      [Token(Token = "0x6001953"), Address(RVA = "0x2C210EC", Offset = "0x2C210EC", VA = "0x2C210EC", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001954")]
    [Address(RVA = "0x2C210F4", Offset = "0x2C210F4", VA = "0x2C210F4", Slot = "4")]
    protected override void OnInitialize(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001955")]
    [Address(RVA = "0x2C2114C", Offset = "0x2C2114C", VA = "0x2C2114C", Slot = "8")]
    public override int GetStateType() => new int();

    [Token(Token = "0x6001956")]
    public abstract void OnBack();

    [Token(Token = "0x6001957")]
    [Address(RVA = "0x2C2115C", Offset = "0x2C2115C", VA = "0x2C2115C", Slot = "18")]
    public virtual void OnSelectBelongingsItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001958")]
    [Address(RVA = "0x2C21160", Offset = "0x2C21160", VA = "0x2C21160", Slot = "19")]
    public virtual void OnSelectEquippedItem(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x6001959")]
    [Address(RVA = "0x2C21164", Offset = "0x2C21164", VA = "0x2C21164", Slot = "20")]
    public virtual void OnUpdateEquipItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x600195A")]
    [Address(RVA = "0x2C21168", Offset = "0x2C21168", VA = "0x2C21168")]
    protected void PlayEquipmentAlert(ItemUnEquipableStatus.UnEquipableMessage message)
    {
    }

    [Token(Token = "0x600195B")]
    [Address(RVA = "0x2C21198", Offset = "0x2C21198", VA = "0x2C21198")]
    protected void Exchange()
    {
    }

    [Token(Token = "0x600195C")]
    [Address(RVA = "0x2C211B4", Offset = "0x2C211B4", VA = "0x2C211B4")]
    protected void SelectEquippedItem(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x600195D")]
    [Address(RVA = "0x2C211F0", Offset = "0x2C211F0", VA = "0x2C211F0")]
    private void UIApplyOnSelectItem(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x600195E")]
    [Address(RVA = "0x2C21248", Offset = "0x2C21248", VA = "0x2C21248")]
    private void FilteringInBelongingItems(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x600195F")]
    [Address(RVA = "0x2C212E0", Offset = "0x2C212E0", VA = "0x2C212E0")]
    private void InventoryUpdateOnEquipment(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x6001960")]
    [Address(RVA = "0x2C2135C", Offset = "0x2C2135C", VA = "0x2C2135C")]
    protected bool OnBelongingItemSelect(ItemEasyDataUI selectItem) => new bool();

    [Token(Token = "0x6001961")]
    [Address(RVA = "0x2C21334", Offset = "0x2C21334", VA = "0x2C21334")]
    protected void InventoryOpen()
    {
    }

    [Token(Token = "0x6001962")]
    [Address(RVA = "0x2C21510", Offset = "0x2C21510", VA = "0x2C21510")]
    protected void InventoryOpen(ItemDetailData item)
    {
    }

    [Token(Token = "0x6001963")]
    [Address(RVA = "0x2C21658", Offset = "0x2C21658", VA = "0x2C21658")]
    protected void InventoryClose()
    {
    }

    [Token(Token = "0x6001964")]
    [Address(RVA = "0x2C2150C", Offset = "0x2C2150C", VA = "0x2C2150C")]
    private void OnInventoryOpen()
    {
    }

    [Token(Token = "0x6001965")]
    [Address(RVA = "0x2C21694", Offset = "0x2C21694", VA = "0x2C21694")]
    private void OnInventoryClose()
    {
    }

    [Token(Token = "0x6001966")]
    [Address(RVA = "0x2C216B0", Offset = "0x2C216B0", VA = "0x2C216B0", Slot = "11")]
    private void UnitEquipmentView\u002EUI\u002EInventoryUIScrollGridPane\u002EIInventoryUISelectEvent\u002EDetatch(
      ItemEasyDataUI item)
    {
    }

    [Token(Token = "0x6001967")]
    [Address(RVA = "0x2C216EC", Offset = "0x2C216EC", VA = "0x2C216EC")]
    private void RemoveItem()
    {
    }

    [Token(Token = "0x6001968")]
    [Address(RVA = "0x2C21708", Offset = "0x2C21708", VA = "0x2C21708", Slot = "12")]
    private void UnitEquipmentView\u002EUI\u002EInventoryUIScrollGridPane\u002EIInventoryUISelectEvent\u002ESelect(
      ItemEasyDataUI item)
    {
    }

    [Token(Token = "0x6001969")]
    [Address(RVA = "0x2C21718", Offset = "0x2C21718", VA = "0x2C21718", Slot = "21")]
    protected virtual void OnSelectInventoryItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x600196A")]
    [Address(RVA = "0x2C2171C", Offset = "0x2C2171C", VA = "0x2C2171C", Slot = "9")]
    private void UnitEquipmentView\u002EUI\u002EInventoryUIScrollGridPane\u002EIEventHandler\u002EOnEnableItem(
      InventoryUIScrollGridItem item,
      int index)
    {
    }

    [Token(Token = "0x600196B")]
    [Address(RVA = "0x2C2177C", Offset = "0x2C2177C", VA = "0x2C2177C", Slot = "10")]
    private void UnitEquipmentView\u002EUI\u002EInventoryUIScrollGridPane\u002EIEventHandler\u002EOnModifyItem(
      InventoryUIScrollGridItem item,
      int index)
    {
    }

    [Token(Token = "0x600196C")]
    [Address(RVA = "0x2C21720", Offset = "0x2C21720", VA = "0x2C21720")]
    protected void UpdateItem(InventoryUIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x600196D")]
    [Address(RVA = "0x2C21780", Offset = "0x2C21780", VA = "0x2C21780")]
    private void ModifyItem(InventoryUIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x600196E")]
    [Address(RVA = "0x2C2187C", Offset = "0x2C2187C", VA = "0x2C2187C", Slot = "13")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectLongTapEvent\u002EOnLongTap(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x600196F")]
    [Address(RVA = "0x2C2188C", Offset = "0x2C2188C", VA = "0x2C2188C", Slot = "22")]
    public virtual void OnItemUILongTap(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001970")]
    [Address(RVA = "0x2C218E4", Offset = "0x2C218E4", VA = "0x2C218E4")]
    protected void ShowItemDetailUI(ItemDetailData itemData)
    {
    }

    [Token(Token = "0x6001971")]
    [Address(RVA = "0x2C21954", Offset = "0x2C21954", VA = "0x2C21954", Slot = "14")]
    private void UnitEquipmentView\u002EUI\u002EWeaponsEquipDetailUI\u002EIEvent\u002EOnClose()
    {
    }

    [Token(Token = "0x6001972")]
    [Address(RVA = "0x2C2197C", Offset = "0x2C2197C", VA = "0x2C2197C")]
    protected SubState()
    {
    }
  }
}
