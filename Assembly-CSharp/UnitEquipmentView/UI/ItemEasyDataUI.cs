// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyDataUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UI.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200044B")]
  [Serializable]
  public class ItemEasyDataUI : 
    MonoBehaviour,
    ItemEasyUIEventTrigger.IPointerEventHandler,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IPointerExitHandler,
    TapObserver.IEventListener
  {
    [Token(Token = "0x40017CF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x40017D0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipButton equipButton;
    [Token(Token = "0x40017D1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemEasyDataAnimation uiAnimation;
    [Token(Token = "0x40017D2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x40017D3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x40017D4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI durabilityUI;
    [Token(Token = "0x40017D5")]
    [FieldOffset(Offset = "0x48")]
    private readonly DurabilityFormatter durabilityFormatter;
    [Token(Token = "0x40017D6")]
    [FieldOffset(Offset = "0x50")]
    private ItemEasyDataUI.IItemSelectEvent eventReceiverOnSelect;
    [Token(Token = "0x40017D7")]
    [FieldOffset(Offset = "0x58")]
    private ItemEasyDataUI.IItemSelectLongTapEvent eventReceiverOnLongTap;
    [Token(Token = "0x40017D8")]
    [FieldOffset(Offset = "0x60")]
    private readonly TapObserver tapObserver;

    [Token(Token = "0x170002DC")]
    public ItemEasyDataAnimation UIAnimation
    {
      [Token(Token = "0x6001856"), Address(RVA = "0x24907C4", Offset = "0x24907C4", VA = "0x24907C4")] get
      {
        return (ItemEasyDataAnimation) null;
      }
    }

    [Token(Token = "0x170002DD")]
    public ItemDetailData ItemDetailData
    {
      [Token(Token = "0x6001857"), Address(RVA = "0x24907CC", Offset = "0x24907CC", VA = "0x24907CC")] get
      {
        return new ItemDetailData();
      }
      [Token(Token = "0x6001858"), Address(RVA = "0x24907DC", Offset = "0x24907DC", VA = "0x24907DC")] private set
      {
      }
    }

    [Token(Token = "0x170002DE")]
    public bool IsEmpty
    {
      [Token(Token = "0x6001859"), Address(RVA = "0x248C344", Offset = "0x248C344", VA = "0x248C344")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002DF")]
    public bool DisplayItemDetailData
    {
      [Token(Token = "0x600185A"), Address(RVA = "0x24907F4", Offset = "0x24907F4", VA = "0x24907F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600185B")]
    [Address(RVA = "0x2490814", Offset = "0x2490814", VA = "0x2490814")]
    private void Start()
    {
    }

    [Token(Token = "0x600185C")]
    [Address(RVA = "0x24908D0", Offset = "0x24908D0", VA = "0x24908D0")]
    public void RegisterSelectEventReceiver(ItemEasyDataUI.IItemSelectEvent receiver)
    {
    }

    [Token(Token = "0x600185D")]
    [Address(RVA = "0x24908D8", Offset = "0x24908D8", VA = "0x24908D8")]
    public void RegisterLongTapEventReceiver(ItemEasyDataUI.IItemSelectLongTapEvent receiver)
    {
    }

    [Token(Token = "0x600185E")]
    [Address(RVA = "0x248EA38", Offset = "0x248EA38", VA = "0x248EA38")]
    public void ButtonEnable()
    {
    }

    [Token(Token = "0x600185F")]
    [Address(RVA = "0x248EA6C", Offset = "0x248EA6C", VA = "0x248EA6C")]
    public void ButtonDisable()
    {
    }

    [Token(Token = "0x6001860")]
    [Address(RVA = "0x248E3EC", Offset = "0x248E3EC", VA = "0x248E3EC")]
    public void Set(ItemDetailData detailData)
    {
    }

    [Token(Token = "0x6001861")]
    [Address(RVA = "0x24909E8", Offset = "0x24909E8", VA = "0x24909E8")]
    public void UIReset()
    {
    }

    [Token(Token = "0x6001862")]
    [Address(RVA = "0x248D3AC", Offset = "0x248D3AC", VA = "0x248D3AC")]
    public void Equip()
    {
    }

    [Token(Token = "0x6001863")]
    [Address(RVA = "0x248D458", Offset = "0x248D458", VA = "0x248D458")]
    public void UnEquip()
    {
    }

    [Token(Token = "0x6001864")]
    [Address(RVA = "0x2484C4C", Offset = "0x2484C4C", VA = "0x2484C4C")]
    public void Empty()
    {
    }

    [Token(Token = "0x6001865")]
    [Address(RVA = "0x248F91C", Offset = "0x248F91C", VA = "0x248F91C")]
    public void RemoveBtn()
    {
    }

    [Token(Token = "0x6001866")]
    [Address(RVA = "0x2490BF8", Offset = "0x2490BF8", VA = "0x2490BF8", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001867")]
    [Address(RVA = "0x2490C14", Offset = "0x2490C14", VA = "0x2490C14", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001868")]
    [Address(RVA = "0x2490C38", Offset = "0x2490C38", VA = "0x2490C38", Slot = "6")]
    public void OnPointerExit(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001869")]
    [Address(RVA = "0x2490C54", Offset = "0x2490C54", VA = "0x2490C54")]
    private void Update()
    {
    }

    [Token(Token = "0x600186A")]
    [Address(RVA = "0x2490C70", Offset = "0x2490C70", VA = "0x2490C70")]
    private void OnEquip()
    {
    }

    [Token(Token = "0x600186B")]
    [Address(RVA = "0x2490D20", Offset = "0x2490D20", VA = "0x2490D20", Slot = "7")]
    private void UI\u002EUtilities\u002ETapObserver\u002EIEventListener\u002EOnTap()
    {
    }

    [Token(Token = "0x600186C")]
    [Address(RVA = "0x2490DCC", Offset = "0x2490DCC", VA = "0x2490DCC", Slot = "8")]
    private void UI\u002EUtilities\u002ETapObserver\u002EIEventListener\u002EOnLongTap()
    {
    }

    [Token(Token = "0x600186D")]
    [Address(RVA = "0x2490E78", Offset = "0x2490E78", VA = "0x2490E78")]
    public ItemEasyDataUI()
    {
    }

    [Token(Token = "0x200044C")]
    public interface IItemSelectEvent
    {
      [Token(Token = "0x600186E")]
      void OnSelect(ItemEasyDataUI selectItem);

      [Token(Token = "0x600186F")]
      void OnChangeEquipState(ItemEasyDataUI selectItem);
    }

    [Token(Token = "0x200044D")]
    public interface IItemSelectLongTapEvent
    {
      [Token(Token = "0x6001870")]
      void OnLongTap(ItemEasyDataUI selectItem);
    }
  }
}
