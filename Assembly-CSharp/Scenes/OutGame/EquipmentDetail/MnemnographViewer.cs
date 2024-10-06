// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036F4")]
  public class MnemnographViewer : MonoBehaviour
  {
    [Token(Token = "0x400EFE1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400EFE2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400EFE3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup suppression;
    [Token(Token = "0x400EFE4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton memoryButton;
    [Token(Token = "0x400EFE5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton memoryCloseButton;
    [Token(Token = "0x400EFE6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton returnButton;
    [Token(Token = "0x400EFE7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image mnemnographImage;
    [Token(Token = "0x400EFE8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text mnemnographNameText;
    [Token(Token = "0x400EFE9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RarityIcon mnemnographRarity;
    [Token(Token = "0x400EFEA")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400EFEB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text explanationText;
    [Token(Token = "0x400EFEC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform imageRect;
    [Token(Token = "0x400EFED")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private RectTransform moveAreaRect;
    [Token(Token = "0x400EFEE")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private float imageScaleDefault;
    [Token(Token = "0x400EFEF")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private float maxZoomRatio;
    [Token(Token = "0x400EFF0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private float maxPinchZoomRatio;
    [Token(Token = "0x400EFF1")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private float minZoomRatio;
    [Token(Token = "0x400EFF2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private float zoomRatio;
    [Token(Token = "0x400EFF3")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private float minPinchDelta;
    [Token(Token = "0x400EFF4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400EFF5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Canvas mainUICanvas;
    [Token(Token = "0x400EFF6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandler;
    [Token(Token = "0x400EFF7")]
    [FieldOffset(Offset = "0xB0")]
    private bool isHide;
    [Token(Token = "0x400EFF8")]
    [FieldOffset(Offset = "0xB1")]
    private bool isDefault;
    [Token(Token = "0x400EFF9")]
    [FieldOffset(Offset = "0xB4")]
    private int mnemnographID;
    [Token(Token = "0x400EFFA")]
    [FieldOffset(Offset = "0xB8")]
    private bool isMemory;
    [Token(Token = "0x400EFFB")]
    [FieldOffset(Offset = "0xC0")]
    private Action finish;
    [Token(Token = "0x400EFFC")]
    [FieldOffset(Offset = "0xC8")]
    private bool isBackGround;

    [Token(Token = "0x17004797")]
    private RectTransform rectTransform
    {
      [Token(Token = "0x6015A43"), Address(RVA = "0x1D80C20", Offset = "0x1D80C20", VA = "0x1D80C20")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6015A44")]
    [Address(RVA = "0x1D80C80", Offset = "0x1D80C80", VA = "0x1D80C80")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x6015A45")]
    [Address(RVA = "0x1D80CCC", Offset = "0x1D80CCC", VA = "0x1D80CCC")]
    private void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x6015A46")]
    [Address(RVA = "0x1D80C88", Offset = "0x1D80C88", VA = "0x1D80C88")]
    private void ChangeBackgroundStatus(bool state)
    {
    }

    [Token(Token = "0x6015A47")]
    [Address(RVA = "0x1D80CD8", Offset = "0x1D80CD8", VA = "0x1D80CD8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015A48")]
    [Address(RVA = "0x1D7B650", Offset = "0x1D7B650", VA = "0x1D7B650")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      int id,
      Action _finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015A49")]
    [Address(RVA = "0x1D80D20", Offset = "0x1D80D20", VA = "0x1D80D20")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015A4A")]
    [Address(RVA = "0x1D80DC8", Offset = "0x1D80DC8", VA = "0x1D80DC8")]
    private void Finalized()
    {
    }

    [Token(Token = "0x6015A4B")]
    [Address(RVA = "0x1D80DF0", Offset = "0x1D80DF0", VA = "0x1D80DF0")]
    private void SetDefaultScale()
    {
    }

    [Token(Token = "0x6015A4C")]
    [Address(RVA = "0x1D80E44", Offset = "0x1D80E44", VA = "0x1D80E44")]
    private void SetMaxScale()
    {
    }

    [Token(Token = "0x6015A4D")]
    [Address(RVA = "0x1D80E78", Offset = "0x1D80E78", VA = "0x1D80E78")]
    private void SetMinScale()
    {
    }

    [Token(Token = "0x6015A4E")]
    [Address(RVA = "0x1D80EB4", Offset = "0x1D80EB4", VA = "0x1D80EB4")]
    private void OnBackButton()
    {
    }

    [Token(Token = "0x6015A4F")]
    [Address(RVA = "0x1D80FF0", Offset = "0x1D80FF0", VA = "0x1D80FF0")]
    private void OnSingleClick(Vector2 pos)
    {
    }

    [Token(Token = "0x6015A50")]
    [Address(RVA = "0x1D810DC", Offset = "0x1D810DC", VA = "0x1D810DC")]
    private void OnDoubleClick(Vector2 pos)
    {
    }

    [Token(Token = "0x6015A51")]
    [Address(RVA = "0x1D814F8", Offset = "0x1D814F8", VA = "0x1D814F8")]
    private void OnSinglePointerMove(Vector2 pos, Vector2 delta)
    {
    }

    [Token(Token = "0x6015A52")]
    [Address(RVA = "0x1D81628", Offset = "0x1D81628", VA = "0x1D81628")]
    private void OnSinglePointerMoveEnd(Vector2 pos)
    {
    }

    [Token(Token = "0x6015A53")]
    [Address(RVA = "0x1D816B4", Offset = "0x1D816B4", VA = "0x1D816B4")]
    private void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6015A54")]
    [Address(RVA = "0x1D819BC", Offset = "0x1D819BC", VA = "0x1D819BC")]
    private void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6015A55")]
    [Address(RVA = "0x1D81A7C", Offset = "0x1D81A7C", VA = "0x1D81A7C")]
    private void OnPinchEnd(Vector2 center)
    {
    }

    [Token(Token = "0x6015A56")]
    [Address(RVA = "0x1D812C0", Offset = "0x1D812C0", VA = "0x1D812C0")]
    private void ValidatePosition()
    {
    }

    [Token(Token = "0x6015A57")]
    [Address(RVA = "0x1D81778", Offset = "0x1D81778", VA = "0x1D81778")]
    private Vector2 CalcPivot(Vector2 touch) => new Vector2();

    [Token(Token = "0x6015A58")]
    [Address(RVA = "0x1D81870", Offset = "0x1D81870", VA = "0x1D81870")]
    private void ChangePivot(Vector2 pivot)
    {
    }

    [Token(Token = "0x6015A59")]
    [Address(RVA = "0x1D81B60", Offset = "0x1D81B60", VA = "0x1D81B60")]
    public MnemnographViewer()
    {
    }
  }
}
