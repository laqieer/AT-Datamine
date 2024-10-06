// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapActionIconUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Element;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x2001689")]
  public class FreeMapActionIconUI : FreeMapDistanceUIBase, IFreeMapIconButtonHandler
  {
    [Token(Token = "0x4006541")]
    [FieldOffset(Offset = "0x0")]
    protected static readonly UIShowTweenNameList DefaultShowTweenNameList;
    [Token(Token = "0x4006542")]
    [FieldOffset(Offset = "0x8")]
    protected static readonly UIRotationTweenNameList DefaultRotationTweenNameList;
    [Token(Token = "0x4006543")]
    [FieldOffset(Offset = "0x10")]
    protected static readonly DuplicationUIRotationTweenNameList DefaultDuplicationTweenNameList;
    [Token(Token = "0x4006546")]
    [FieldOffset(Offset = "0x68")]
    private FreeMapActionIconUI.DisplayState displayStateCurrent;
    [Token(Token = "0x4006547")]
    [FieldOffset(Offset = "0x70")]
    private readonly FreeMapActionIconUI.DisplayState displayStateShow;
    [Token(Token = "0x4006548")]
    [FieldOffset(Offset = "0x78")]
    private readonly FreeMapActionIconUI.DisplayState displayStateHide;
    [Token(Token = "0x4006549")]
    [FieldOffset(Offset = "0x80")]
    private List<FreeMapActionIconUI.IconDataContainer> iconDatas;
    [Token(Token = "0x400654A")]
    [FieldOffset(Offset = "0x88")]
    protected FreeMapActionIconUIControllElement defaultUIElement;

    [Token(Token = "0x170013A6")]
    public bool IsChangeNearState
    {
      [Token(Token = "0x6007F32"), Address(RVA = "0x21B47DC", Offset = "0x21B47DC", VA = "0x21B47DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007F33"), Address(RVA = "0x21B47E4", Offset = "0x21B47E4", VA = "0x21B47E4")] private set
      {
      }
    }

    [Token(Token = "0x170013A7")]
    public bool IsChangeDefaultState
    {
      [Token(Token = "0x6007F34"), Address(RVA = "0x21B47F0", Offset = "0x21B47F0", VA = "0x21B47F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007F35"), Address(RVA = "0x21B47F8", Offset = "0x21B47F8", VA = "0x21B47F8")] private set
      {
      }
    }

    [Token(Token = "0x170013A8")]
    public FreeMapDistanceUIBase.PlayerDistanceState CurrentDistanceState
    {
      [Token(Token = "0x6007F36"), Address(RVA = "0x21B4804", Offset = "0x21B4804", VA = "0x21B4804")] get
      {
        return new FreeMapDistanceUIBase.PlayerDistanceState();
      }
    }

    [Token(Token = "0x170013A9")]
    public override FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x6007F37"), Address(RVA = "0x21B480C", Offset = "0x21B480C", VA = "0x21B480C", Slot = "6")] get
      {
        return new FreeMapUIDirection();
      }
    }

    [Token(Token = "0x170013AA")]
    public override bool IsValid
    {
      [Token(Token = "0x6007F38"), Address(RVA = "0x21B4828", Offset = "0x21B4828", VA = "0x21B4828", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013AB")]
    public override float CurrentDistance
    {
      [Token(Token = "0x6007F39"), Address(RVA = "0x21B4878", Offset = "0x21B4878", VA = "0x21B4878", Slot = "4")] get
      {
        return new float();
      }
      [Token(Token = "0x6007F3A"), Address(RVA = "0x21B4890", Offset = "0x21B4890", VA = "0x21B4890", Slot = "5")] protected set
      {
      }
    }

    [Token(Token = "0x6007F3B")]
    [Address(RVA = "0x21B4898", Offset = "0x21B4898", VA = "0x21B4898")]
    public void Initialize(UITransformIconAvoidElement avoidElement)
    {
    }

    [Token(Token = "0x6007F3C")]
    [Address(RVA = "0x21B4968", Offset = "0x21B4968", VA = "0x21B4968")]
    public void SetPlayerDistanceState(FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007F3D")]
    [Address(RVA = "0x21B4978", Offset = "0x21B4978", VA = "0x21B4978", Slot = "9")]
    protected override void OnUpdate(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      FreeMapPlayerInstance player,
      bool isUpdateClip)
    {
    }

    [Token(Token = "0x6007F3E")]
    [Address(RVA = "0x21B52BC", Offset = "0x21B52BC", VA = "0x21B52BC", Slot = "16")]
    protected override void UpdatePlayerDistanceState(FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007F3F")]
    [Address(RVA = "0x21B5408", Offset = "0x21B5408", VA = "0x21B5408")]
    public void ShowDuplicationUI()
    {
    }

    [Token(Token = "0x6007F40")]
    [Address(RVA = "0x21B552C", Offset = "0x21B552C", VA = "0x21B552C")]
    public void HideDuplicationUI()
    {
    }

    [Token(Token = "0x6007F41")]
    [Address(RVA = "0x21B55A8", Offset = "0x21B55A8", VA = "0x21B55A8", Slot = "17")]
    protected override void ChangeDefaultDisplayUI()
    {
    }

    [Token(Token = "0x6007F42")]
    [Address(RVA = "0x21B55AC", Offset = "0x21B55AC", VA = "0x21B55AC", Slot = "18")]
    protected override void ChangeNearDisplayUI()
    {
    }

    [Token(Token = "0x6007F43")]
    [Address(RVA = "0x21B55B0", Offset = "0x21B55B0", VA = "0x21B55B0", Slot = "11")]
    public override void HideUI()
    {
    }

    [Token(Token = "0x6007F44")]
    [Address(RVA = "0x21B55E0", Offset = "0x21B55E0", VA = "0x21B55E0", Slot = "10")]
    public override void ShowUI()
    {
    }

    [Token(Token = "0x6007F45")]
    [Address(RVA = "0x21B5638", Offset = "0x21B5638", VA = "0x21B5638", Slot = "19")]
    protected override void ChangeTransparentAlphaUI(float toAlpha)
    {
    }

    [Token(Token = "0x6007F46")]
    [Address(RVA = "0x21B5654", Offset = "0x21B5654", VA = "0x21B5654", Slot = "13")]
    protected override void OnDestroyUI()
    {
    }

    [Token(Token = "0x6007F47")]
    [Address(RVA = "0x21B5820", Offset = "0x21B5820", VA = "0x21B5820", Slot = "15")]
    public override void RemoveUI(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007F48")]
    [Address(RVA = "0x21B5AFC", Offset = "0x21B5AFC", VA = "0x21B5AFC", Slot = "14")]
    public override void ChangeSprite(
      FreeMapUIParamBase targetParam,
      string targetObjectName,
      Sprite sprite)
    {
    }

    [Token(Token = "0x6007F49")]
    [Address(RVA = "0x21B5BD4", Offset = "0x21B5BD4", VA = "0x21B5BD4", Slot = "12")]
    public override void ChangeUI(
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam,
      Sprite sprite,
      UnityAction buttonAction,
      string buttonObjectName)
    {
    }

    [Token(Token = "0x6007F4A")]
    [Address(RVA = "0x21B5CC0", Offset = "0x21B5CC0", VA = "0x21B5CC0", Slot = "21")]
    public void InvokeButtonAction(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007F4B")]
    [Address(RVA = "0x21B5D84", Offset = "0x21B5D84", VA = "0x21B5D84", Slot = "20")]
    public bool IsHoldUIParam(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6007F4C")]
    [Address(RVA = "0x21B5E64", Offset = "0x21B5E64", VA = "0x21B5E64", Slot = "8")]
    public override void SetAsLastSibling()
    {
    }

    [Token(Token = "0x6007F4D")]
    [Address(RVA = "0x21B5F48", Offset = "0x21B5F48", VA = "0x21B5F48")]
    public FreeMapButtonUIControllElement AddElement(
      GameObject iconPrefab,
      FreeMapUIParamBase uiParam,
      FreeMapUITransformHolder holder,
      string buttonObjectName,
      bool statusPurposeMark)
    {
      return (FreeMapButtonUIControllElement) null;
    }

    [Token(Token = "0x6007F4E")]
    [Address(RVA = "0x21B5778", Offset = "0x21B5778", VA = "0x21B5778")]
    private void IterateAllIcons(
      Action<FreeMapActionIconUI.IconDataContainer> action)
    {
    }

    [Token(Token = "0x6007F4F")]
    [Address(RVA = "0x21B5484", Offset = "0x21B5484", VA = "0x21B5484")]
    private void IterateSubIcons(
      Action<FreeMapActionIconUI.IconDataContainer> action)
    {
    }

    [Token(Token = "0x6007F50")]
    [Address(RVA = "0x21B6148", Offset = "0x21B6148", VA = "0x21B6148")]
    private FreeMapActionIconUIControllElement CreateMainElement(
      GameObject iconPrefab,
      FreeMapUITransformHolder holder,
      string buttonObjectName)
    {
      return (FreeMapActionIconUIControllElement) null;
    }

    [Token(Token = "0x6007F51")]
    [Address(RVA = "0x21B6294", Offset = "0x21B6294", VA = "0x21B6294")]
    private FreeMapButtonUIControllElement CreateSubElement(
      GameObject iconPrefab,
      FreeMapUITransformHolder holder,
      string buttonObjectName,
      DuplicationUIAnimationController.DuplicationDirection side)
    {
      return (FreeMapButtonUIControllElement) null;
    }

    [Token(Token = "0x6007F52")]
    [Address(RVA = "0x21B6434", Offset = "0x21B6434", VA = "0x21B6434")]
    public FreeMapActionIconUI()
    {
    }

    [Token(Token = "0x6007F53")]
    [Address(RVA = "0x21B6564", Offset = "0x21B6564", VA = "0x21B6564")]
    static FreeMapActionIconUI()
    {
    }

    [Token(Token = "0x200168A")]
    private class IconDataContainer
    {
      [Token(Token = "0x170013AC")]
      public FreeMapUIParamBase UIParam
      {
        [Token(Token = "0x6007F54"), Address(RVA = "0x21B6774", Offset = "0x21B6774", VA = "0x21B6774")] set
        {
        }
        [Token(Token = "0x6007F55"), Address(RVA = "0x21B677C", Offset = "0x21B677C", VA = "0x21B677C")] get
        {
          return (FreeMapUIParamBase) null;
        }
      }

      [Token(Token = "0x170013AD")]
      public FreeMapButtonUIControllElement ControlElement
      {
        [Token(Token = "0x6007F56"), Address(RVA = "0x21B6784", Offset = "0x21B6784", VA = "0x21B6784")] set
        {
        }
        [Token(Token = "0x6007F57"), Address(RVA = "0x21B678C", Offset = "0x21B678C", VA = "0x21B678C")] get
        {
          return (FreeMapButtonUIControllElement) null;
        }
      }

      [Token(Token = "0x170013AE")]
      public bool StatusPurposeMark
      {
        [Token(Token = "0x6007F58"), Address(RVA = "0x21B6794", Offset = "0x21B6794", VA = "0x21B6794")] set
        {
        }
        [Token(Token = "0x6007F59"), Address(RVA = "0x21B67A0", Offset = "0x21B67A0", VA = "0x21B67A0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6007F5A")]
      [Address(RVA = "0x21B63F4", Offset = "0x21B63F4", VA = "0x21B63F4")]
      public IconDataContainer(
        FreeMapUIParamBase uiParam,
        FreeMapButtonUIControllElement controlElement,
        bool statusPurposeMark)
      {
      }
    }

    [Token(Token = "0x200168B")]
    private abstract class DisplayState
    {
      [Token(Token = "0x6007F5B")]
      public abstract void Apply(FreeMapActionIconUI.IconDataContainer icon);

      [Token(Token = "0x6007F5C")]
      [Address(RVA = "0x21B67A8", Offset = "0x21B67A8", VA = "0x21B67A8")]
      protected DisplayState()
      {
      }
    }

    [Token(Token = "0x200168C")]
    private class DisplayStateShow : FreeMapActionIconUI.DisplayState
    {
      [Token(Token = "0x6007F5D")]
      [Address(RVA = "0x21B67B0", Offset = "0x21B67B0", VA = "0x21B67B0", Slot = "4")]
      public override void Apply(FreeMapActionIconUI.IconDataContainer icon)
      {
      }

      [Token(Token = "0x6007F5E")]
      [Address(RVA = "0x21B653C", Offset = "0x21B653C", VA = "0x21B653C")]
      public DisplayStateShow()
      {
      }
    }

    [Token(Token = "0x200168D")]
    private class DisplayStateHide : FreeMapActionIconUI.DisplayState
    {
      [Token(Token = "0x6007F5F")]
      [Address(RVA = "0x21B67D4", Offset = "0x21B67D4", VA = "0x21B67D4", Slot = "4")]
      public override void Apply(FreeMapActionIconUI.IconDataContainer icon)
      {
      }

      [Token(Token = "0x6007F60")]
      [Address(RVA = "0x21B6544", Offset = "0x21B6544", VA = "0x21B6544")]
      public DisplayStateHide()
      {
      }
    }
  }
}
