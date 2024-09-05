// Decompiled with JetBrains decompiler
// Type: Battle.UI.ItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023DD")]
  public sealed class ItemList : MonoBehaviour
  {
    [Token(Token = "0x4009914")]
    private const int InvalidSelectIndex = -1;
    [Token(Token = "0x4009915")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4009916")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4009917")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemListItem itemBase;
    [Token(Token = "0x4009918")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4009919")]
    [FieldOffset(Offset = "0x38")]
    [Header("予測表示時UI")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400991A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400991B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject rootObj;
    [Token(Token = "0x400991C")]
    [FieldOffset(Offset = "0x50")]
    [Header("Tween")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400991D")]
    [FieldOffset(Offset = "0x58")]
    [Header("Toaster")]
    [SerializeField]
    private ToasterUI toaster;
    [Token(Token = "0x400991E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400991F")]
    private const string OpenTween = "ExecutionCommand_In";
    [Token(Token = "0x4009920")]
    private const string CloseTween = "ExecutionCommand_Out";
    [Token(Token = "0x4009921")]
    [FieldOffset(Offset = "0x68")]
    private bool isViewConfirm;
    [Token(Token = "0x4009922")]
    [FieldOffset(Offset = "0x70")]
    private List<ItemListItem> enableItems;
    [Token(Token = "0x4009923")]
    [FieldOffset(Offset = "0x78")]
    public UnityAction<int> OnSelectItemAt;
    [Token(Token = "0x4009925")]
    [FieldOffset(Offset = "0x88")]
    private Action onConfirmCallback;
    [Token(Token = "0x4009926")]
    [FieldOffset(Offset = "0x90")]
    private bool isTimelinePlaying;
    [Token(Token = "0x4009927")]
    [FieldOffset(Offset = "0x98")]
    private IDirector mainDirector;

    [Token(Token = "0x17002F54")]
    public int LastSelectAt
    {
      [Token(Token = "0x600DBC3"), Address(RVA = "0x2150EF0", Offset = "0x2150EF0", VA = "0x2150EF0")] get
      {
        return new int();
      }
      [Token(Token = "0x600DBC4"), Address(RVA = "0x2150EF8", Offset = "0x2150EF8", VA = "0x2150EF8")] private set
      {
      }
    }

    [Token(Token = "0x600DBC5")]
    [Address(RVA = "0x2150F00", Offset = "0x2150F00", VA = "0x2150F00")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600DBC6")]
    [Address(RVA = "0x2150F04", Offset = "0x2150F04", VA = "0x2150F04")]
    public IEnumerator InitializeCoroutine(IDirector director) => (IEnumerator) null;

    [Token(Token = "0x600DBC7")]
    [Address(RVA = "0x2150FA0", Offset = "0x2150FA0", VA = "0x2150FA0")]
    public void SetItem(ItemParameterData[] items)
    {
    }

    [Token(Token = "0x600DBC8")]
    [Address(RVA = "0x21512DC", Offset = "0x21512DC", VA = "0x21512DC")]
    public void Show(ItemParameterData[] items)
    {
    }

    [Token(Token = "0x600DBC9")]
    [Address(RVA = "0x215179C", Offset = "0x215179C", VA = "0x215179C")]
    private IEnumerator WaitShow() => (IEnumerator) null;

    [Token(Token = "0x600DBCA")]
    [Address(RVA = "0x215182C", Offset = "0x215182C", VA = "0x215182C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DBCB")]
    [Address(RVA = "0x21518D4", Offset = "0x21518D4", VA = "0x21518D4")]
    public void Finish()
    {
    }

    [Token(Token = "0x600DBCC")]
    [Address(RVA = "0x215186C", Offset = "0x215186C", VA = "0x215186C")]
    private IEnumerator WaitHide() => (IEnumerator) null;

    [Token(Token = "0x600DBCD")]
    [Address(RVA = "0x2151B68", Offset = "0x2151B68", VA = "0x2151B68")]
    public void ShowConfirm(Action onConfirmCallback)
    {
    }

    [Token(Token = "0x600DBCE")]
    [Address(RVA = "0x2151CD8", Offset = "0x2151CD8", VA = "0x2151CD8")]
    public void HideConfirm()
    {
    }

    [Token(Token = "0x600DBCF")]
    [Address(RVA = "0x2150FAC", Offset = "0x2150FAC", VA = "0x2150FAC")]
    private void CreateItems(ItemParameterData[] items)
    {
    }

    [Token(Token = "0x600DBD0")]
    [Address(RVA = "0x2151EC0", Offset = "0x2151EC0", VA = "0x2151EC0")]
    private void OnSelect(ItemListItem item)
    {
    }

    [Token(Token = "0x600DBD1")]
    [Address(RVA = "0x2151B20", Offset = "0x2151B20", VA = "0x2151B20")]
    private void Dispatch(int selectAt)
    {
    }

    [Token(Token = "0x600DBD2")]
    [Address(RVA = "0x21520A8", Offset = "0x21520A8", VA = "0x21520A8")]
    public void OnConfirm()
    {
    }

    [Token(Token = "0x600DBD3")]
    [Address(RVA = "0x21520C4", Offset = "0x21520C4", VA = "0x21520C4")]
    public void OnCancel()
    {
    }

    [Token(Token = "0x600DBD4")]
    [Address(RVA = "0x21520EC", Offset = "0x21520EC", VA = "0x21520EC")]
    private void ToasterOnClickBG(ToasterUI toaster)
    {
    }

    [Token(Token = "0x600DBD5")]
    [Address(RVA = "0x2151654", Offset = "0x2151654", VA = "0x2151654")]
    private void AllHideSelectItem()
    {
    }

    [Token(Token = "0x600DBD6")]
    [Address(RVA = "0x2152214", Offset = "0x2152214", VA = "0x2152214")]
    public ItemList()
    {
    }
  }
}
