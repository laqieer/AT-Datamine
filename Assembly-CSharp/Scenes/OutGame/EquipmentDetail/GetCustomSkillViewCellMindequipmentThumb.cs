// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.GetCustomSkillViewCellMindequipmentThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036CC")]
  public class GetCustomSkillViewCellMindequipmentThumb : MonoBehaviour
  {
    [Token(Token = "0x400EEDA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400EEDB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LongPressButton baseButton;
    [Token(Token = "0x400EEDC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LongPressButton thumbButton;
    [Token(Token = "0x400EEDD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400EEDE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400EEDF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400EEE0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400EEE1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] unused;
    [Token(Token = "0x400EEE2")]
    [FieldOffset(Offset = "0x58")]
    private bool isInitialized;
    [Token(Token = "0x400EEE3")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400EEE4")]
    [FieldOffset(Offset = "0x60")]
    private MindEquipment mindequipmentData;

    [Token(Token = "0x601591C")]
    [Address(RVA = "0x1A63C10", Offset = "0x1A63C10", VA = "0x1A63C10")]
    public void Initialized(int ID)
    {
    }

    [Token(Token = "0x601591D")]
    [Address(RVA = "0x1A646E0", Offset = "0x1A646E0", VA = "0x1A646E0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601591E")]
    [Address(RVA = "0x1A64710", Offset = "0x1A64710", VA = "0x1A64710")]
    private IEnumerator LoadWaitthumb() => (IEnumerator) null;

    [Token(Token = "0x601591F")]
    [Address(RVA = "0x1A647A0", Offset = "0x1A647A0", VA = "0x1A647A0")]
    public GetCustomSkillViewCellMindequipmentThumb()
    {
    }
  }
}
