// Decompiled with JetBrains decompiler
// Type: TeamOrganization.StyleEquipThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000807")]
  public class StyleEquipThumb : MonoBehaviour
  {
    [Token(Token = "0x40025F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40025F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x40025F5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject selectEquip;
    [Token(Token = "0x40025F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x40025F7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button ItemChangeButton;
    [Token(Token = "0x40025F8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button ItemRemoveButton;
    [Token(Token = "0x40025F9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject organizingObject;
    [Token(Token = "0x40025FA")]
    [FieldOffset(Offset = "0x50")]
    private Action<int> onSelectAction;
    [Token(Token = "0x40025FB")]
    [FieldOffset(Offset = "0x58")]
    private Action<int> onChangeAction;
    [Token(Token = "0x40025FC")]
    [FieldOffset(Offset = "0x60")]
    private Action<int> onDetailAction;
    [Token(Token = "0x40025FD")]
    [FieldOffset(Offset = "0x68")]
    private Action onRemoveAction;
    [Token(Token = "0x40025FE")]
    [FieldOffset(Offset = "0x70")]
    private bool isSetSlotStyle;
    [Token(Token = "0x40025FF")]
    [FieldOffset(Offset = "0x74")]
    private int itemIndex;

    [Token(Token = "0x170006DE")]
    public StyleThumb StyleThumb
    {
      [Token(Token = "0x6002E15"), Address(RVA = "0x3A8F7E8", Offset = "0x3A8F7E8", VA = "0x3A8F7E8")] get
      {
        return (StyleThumb) null;
      }
    }

    [Token(Token = "0x6002E16")]
    [Address(RVA = "0x3A8F7F0", Offset = "0x3A8F7F0", VA = "0x3A8F7F0")]
    public void Initialize(
      int styleId,
      int idx,
      bool isSetSlotStyle,
      bool isApplyLost,
      Action<int> onChangeAction,
      Action<int> onDetailAction,
      Action<int> onSelectAction,
      Action onRemoveAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E17")]
    [Address(RVA = "0x3A8F8E0", Offset = "0x3A8F8E0", VA = "0x3A8F8E0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002E18")]
    [Address(RVA = "0x3A8F914", Offset = "0x3A8F914", VA = "0x3A8F914")]
    public void OnClickStyleThumb(int index)
    {
    }

    [Token(Token = "0x6002E19")]
    [Address(RVA = "0x3A8F944", Offset = "0x3A8F944", VA = "0x3A8F944")]
    public void SelectOn()
    {
    }

    [Token(Token = "0x6002E1A")]
    [Address(RVA = "0x3A8FAF4", Offset = "0x3A8FAF4", VA = "0x3A8FAF4")]
    public void SelectOff()
    {
    }

    [Token(Token = "0x6002E1B")]
    [Address(RVA = "0x3A8FC34", Offset = "0x3A8FC34", VA = "0x3A8FC34")]
    public void ChangeCanvasOverrideSorting(bool isOn)
    {
    }

    [Token(Token = "0x6002E1C")]
    [Address(RVA = "0x3A8FC54", Offset = "0x3A8FC54", VA = "0x3A8FC54")]
    public void PlaySelectAndEquipween(bool isSelect, bool equip)
    {
    }

    [Token(Token = "0x6002E1D")]
    [Address(RVA = "0x3A8FE00", Offset = "0x3A8FE00", VA = "0x3A8FE00")]
    public void OnChangeButton()
    {
    }

    [Token(Token = "0x6002E1E")]
    [Address(RVA = "0x3A8FE20", Offset = "0x3A8FE20", VA = "0x3A8FE20")]
    public void OnDetailAction()
    {
    }

    [Token(Token = "0x6002E1F")]
    [Address(RVA = "0x3A8FE40", Offset = "0x3A8FE40", VA = "0x3A8FE40")]
    public void OnRemoveAction()
    {
    }

    [Token(Token = "0x6002E20")]
    [Address(RVA = "0x3A8FE5C", Offset = "0x3A8FE5C", VA = "0x3A8FE5C")]
    public StyleEquipThumb()
    {
    }
  }
}
