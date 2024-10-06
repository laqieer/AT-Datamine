// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetEditSubMenuView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C1")]
  public class EquipSetEditSubMenuView : MonoBehaviour
  {
    [Token(Token = "0x4002432")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002433")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton buttonClose;
    [Token(Token = "0x4002434")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image emblemImage;
    [Token(Token = "0x4002435")]
    [FieldOffset(Offset = "0x30")]
    private Action onEditResetButtonAction;
    [Token(Token = "0x4002436")]
    [FieldOffset(Offset = "0x38")]
    private Action onEditAllClearButtonAction;

    [Token(Token = "0x17000687")]
    public bool IsOpened
    {
      [Token(Token = "0x6002BE1"), Address(RVA = "0x387499C", Offset = "0x387499C", VA = "0x387499C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BE2"), Address(RVA = "0x38749A4", Offset = "0x38749A4", VA = "0x38749A4")] private set
      {
      }
    }

    [Token(Token = "0x6002BE3")]
    [Address(RVA = "0x38749B0", Offset = "0x38749B0", VA = "0x38749B0")]
    public void Initialize(Action editResetAction, Action editAllClearAction)
    {
    }

    [Token(Token = "0x6002BE4")]
    [Address(RVA = "0x3874B40", Offset = "0x3874B40", VA = "0x3874B40")]
    public void UpdateView(AssetCachedSpawner spawner, StyleData style)
    {
    }

    [Token(Token = "0x6002BE5")]
    [Address(RVA = "0x3874C3C", Offset = "0x3874C3C", VA = "0x3874C3C")]
    public void Open()
    {
    }

    [Token(Token = "0x6002BE6")]
    [Address(RVA = "0x3874CA0", Offset = "0x3874CA0", VA = "0x3874CA0")]
    public void Close()
    {
    }

    [Token(Token = "0x6002BE7")]
    [Address(RVA = "0x3874D00", Offset = "0x3874D00", VA = "0x3874D00")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x6002BE8")]
    [Address(RVA = "0x3874D04", Offset = "0x3874D04", VA = "0x3874D04")]
    public void OnAutoFormationSetButton()
    {
    }

    [Token(Token = "0x6002BE9")]
    [Address(RVA = "0x3874D08", Offset = "0x3874D08", VA = "0x3874D08")]
    public void OnEditResetButton()
    {
    }

    [Token(Token = "0x6002BEA")]
    [Address(RVA = "0x3874D24", Offset = "0x3874D24", VA = "0x3874D24")]
    public void OnEditAllClearButton()
    {
    }

    [Token(Token = "0x6002BEB")]
    [Address(RVA = "0x3874A7C", Offset = "0x3874A7C", VA = "0x3874A7C")]
    public void SetEmblemImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002BEC")]
    [Address(RVA = "0x3874D40", Offset = "0x3874D40", VA = "0x3874D40")]
    public EquipSetEditSubMenuView()
    {
    }
  }
}
