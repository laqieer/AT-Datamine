// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.ItemRewardPopupContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BFC")]
  public class ItemRewardPopupContent : MonoBehaviour
  {
    [Token(Token = "0x4003665")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x4003666")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform thumbParent;
    [Token(Token = "0x4003667")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float delayNextIconIn;

    [Token(Token = "0x170009F4")]
    public float Delay
    {
      [Token(Token = "0x60044BC"), Address(RVA = "0x364BD34", Offset = "0x364BD34", VA = "0x364BD34")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60044BD")]
    [Address(RVA = "0x3649F2C", Offset = "0x3649F2C", VA = "0x3649F2C")]
    public void SetData(
      AssetCachedSpawner assetCachedSpawner,
      DisplayItemRewardInfoData info,
      bool numDisplay,
      Action onClick)
    {
    }

    [Token(Token = "0x60044BE")]
    [Address(RVA = "0x364B7C4", Offset = "0x364B7C4", VA = "0x364B7C4")]
    public void PlayInTween()
    {
    }

    [Token(Token = "0x60044BF")]
    [Address(RVA = "0x364BFB4", Offset = "0x364BFB4", VA = "0x364BFB4")]
    public ItemRewardPopupContent()
    {
    }
  }
}
