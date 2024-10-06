// Decompiled with JetBrains decompiler
// Type: Battle.UI.InitialPlacement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002312")]
  public class InitialPlacement : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x4009464")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4009465")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x4009466")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button finishPlacementButton;
    [Token(Token = "0x4009467")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text finishPlacementText;
    [Token(Token = "0x4009468")]
    [FieldOffset(Offset = "0x38")]
    private InitialPlacement.SelectUnitIcon selectUnitIcon;
    [Token(Token = "0x4009469")]
    [FieldOffset(Offset = "0x40")]
    private WorldSpaceCanvasManager WorldSpaceCanvasManager;
    [Token(Token = "0x400946A")]
    [FieldOffset(Offset = "0x48")]
    private bool disposed;

    [Token(Token = "0x600D63C")]
    [Address(RVA = "0x1D1C624", Offset = "0x1D1C624", VA = "0x1D1C624")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D63D")]
    [Address(RVA = "0x1D1C688", Offset = "0x1D1C688", VA = "0x1D1C688")]
    public void Initialize(
      WorldSpaceCanvasManager WorldSpaceCanvasManager,
      BattleConfigAsset config)
    {
    }

    [Token(Token = "0x600D63E")]
    [Address(RVA = "0x1D1C870", Offset = "0x1D1C870", VA = "0x1D1C870")]
    public void Release()
    {
    }

    [Token(Token = "0x600D63F")]
    [Address(RVA = "0x1D1C628", Offset = "0x1D1C628", VA = "0x1D1C628", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D640")]
    [Address(RVA = "0x1D1C9A4", Offset = "0x1D1C9A4", VA = "0x1D1C9A4")]
    public void Show()
    {
    }

    [Token(Token = "0x600D641")]
    [Address(RVA = "0x1D1CA18", Offset = "0x1D1CA18", VA = "0x1D1CA18")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D642")]
    [Address(RVA = "0x1D1CAB0", Offset = "0x1D1CAB0", VA = "0x1D1CAB0")]
    public void SetBackButtonCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x600D643")]
    [Address(RVA = "0x1D1CB00", Offset = "0x1D1CB00", VA = "0x1D1CB00")]
    public void SetFinishPlacementButtonCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x600D644")]
    [Address(RVA = "0x1D1CB50", Offset = "0x1D1CB50", VA = "0x1D1CB50")]
    public void SetFinishPlacementButtonText(string text)
    {
    }

    [Token(Token = "0x600D645")]
    [Address(RVA = "0x1D1CB74", Offset = "0x1D1CB74", VA = "0x1D1CB74")]
    public void ShowSelectUnitArrow()
    {
    }

    [Token(Token = "0x600D646")]
    [Address(RVA = "0x1D1CBAC", Offset = "0x1D1CBAC", VA = "0x1D1CBAC")]
    public void UpdateUnitArrowPosition(Vector3 position)
    {
    }

    [Token(Token = "0x600D647")]
    [Address(RVA = "0x1D1CA98", Offset = "0x1D1CA98", VA = "0x1D1CA98")]
    public void HideSelectUnitArrow()
    {
    }

    [Token(Token = "0x600D648")]
    [Address(RVA = "0x1D1CC48", Offset = "0x1D1CC48", VA = "0x1D1CC48")]
    public InitialPlacement()
    {
    }

    [Token(Token = "0x2002313")]
    public class SelectUnitIcon : IDisposable
    {
      [Token(Token = "0x400946B")]
      [FieldOffset(Offset = "0x10")]
      private GameObject selectArrowObject;
      [Token(Token = "0x400946C")]
      [FieldOffset(Offset = "0x18")]
      private bool disposed;

      [Token(Token = "0x17002E3B")]
      public Transform SelectArrow
      {
        [Token(Token = "0x600D649"), Address(RVA = "0x1D1C854", Offset = "0x1D1C854", VA = "0x1D1C854")] get
        {
          return (Transform) null;
        }
      }

      [Token(Token = "0x600D64A")]
      [Address(RVA = "0x1D1C75C", Offset = "0x1D1C75C", VA = "0x1D1C75C")]
      public void Initialize()
      {
      }

      [Token(Token = "0x600D64B")]
      [Address(RVA = "0x1D1C934", Offset = "0x1D1C934", VA = "0x1D1C934", Slot = "4")]
      public void Dispose()
      {
      }

      [Token(Token = "0x600D64C")]
      [Address(RVA = "0x1D1CB8C", Offset = "0x1D1CB8C", VA = "0x1D1CB8C")]
      public void Show()
      {
      }

      [Token(Token = "0x600D64D")]
      [Address(RVA = "0x1D1CC28", Offset = "0x1D1CC28", VA = "0x1D1CC28")]
      public void Hide()
      {
      }

      [Token(Token = "0x600D64E")]
      [Address(RVA = "0x1D1CCB0", Offset = "0x1D1CCB0", VA = "0x1D1CCB0")]
      public SelectUnitIcon()
      {
      }
    }
  }
}
