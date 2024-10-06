// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipmentSlotThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007BA")]
  public class EquipmentSlotThumb : MonoBehaviour
  {
    [Token(Token = "0x4002412")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002413")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x4002414")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x4002415")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject unmaskMnemonograph;
    [Token(Token = "0x4002416")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x4002417")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image rarityTextImage;
    [Token(Token = "0x4002418")]
    protected const string TweenEquipmentNormal = "LostIcon_In";
    [Token(Token = "0x4002419")]
    protected const string TweenEquipmentCaution = "LostIcon_Out";
    [Token(Token = "0x400241A")]
    [FieldOffset(Offset = "0x48")]
    private Action onClick;
    [Token(Token = "0x400241B")]
    [FieldOffset(Offset = "0x50")]
    private Action onLongPress;
    [Token(Token = "0x400241C")]
    [FieldOffset(Offset = "0x58")]
    private EquipmentSlotThumbModel model;
    [Token(Token = "0x400241D")]
    [FieldOffset(Offset = "0x60")]
    protected AssetCachedSpawner Spawner;

    [Token(Token = "0x6002BBC")]
    [Address(RVA = "0x3873738", Offset = "0x3873738", VA = "0x3873738")]
    public void Initialize(CommonButton button, CommonButton lockButton)
    {
    }

    [Token(Token = "0x6002BBD")]
    [Address(RVA = "0x3873984", Offset = "0x3873984", VA = "0x3873984")]
    public void SetAction(Action onClick = null, Action onLongPress = null)
    {
    }

    [Token(Token = "0x6002BBE")]
    [Address(RVA = "0x387398C", Offset = "0x387398C", VA = "0x387398C")]
    public void UpdateView(EquipmentSlotThumbModel model)
    {
    }

    [Token(Token = "0x6002BBF")]
    [Address(RVA = "0x38739C4", Offset = "0x38739C4", VA = "0x38739C4")]
    private void Empty()
    {
    }

    [Token(Token = "0x6002BC0")]
    [Address(RVA = "0x38739E8", Offset = "0x38739E8", VA = "0x38739E8")]
    private void Default()
    {
    }

    [Token(Token = "0x6002BC1")]
    [Address(RVA = "0x3874284", Offset = "0x3874284", VA = "0x3874284")]
    public void SetIconImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002BC2")]
    [Address(RVA = "0x387435C", Offset = "0x387435C", VA = "0x387435C")]
    private void SetRarityBaseImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002BC3")]
    [Address(RVA = "0x3874434", Offset = "0x3874434", VA = "0x3874434")]
    private void SetRarityImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002BC4")]
    [Address(RVA = "0x38741EC", Offset = "0x38741EC", VA = "0x38741EC")]
    private void SetActiveUnmaskMnemonograph(bool isEnabled)
    {
    }

    [Token(Token = "0x6002BC5")]
    [Address(RVA = "0x3874578", Offset = "0x3874578", VA = "0x3874578")]
    public void PlayGrayOut(bool isGrayOut)
    {
    }

    [Token(Token = "0x6002BC6")]
    [Address(RVA = "0x3874614", Offset = "0x3874614", VA = "0x3874614")]
    public void PlaySelect(bool isSelect)
    {
    }

    [Token(Token = "0x6002BC7")]
    [Address(RVA = "0x3874504", Offset = "0x3874504", VA = "0x3874504")]
    public void PlayFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x6002BC8")]
    [Address(RVA = "0x38745EC", Offset = "0x38745EC", VA = "0x38745EC")]
    private void PlayTween(bool isIn, string inAnim, string outAnim, bool stop = true)
    {
    }

    [Token(Token = "0x6002BC9")]
    [Address(RVA = "0x3873FF8", Offset = "0x3873FF8", VA = "0x3873FF8")]
    private (string, string) GetThumbAssetName() => ();

    [Token(Token = "0x6002BCA")]
    [Address(RVA = "0x3874688", Offset = "0x3874688", VA = "0x3874688")]
    public EquipmentSlotThumb()
    {
    }
  }
}
