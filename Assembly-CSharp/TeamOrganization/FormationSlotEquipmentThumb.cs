// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotEquipmentThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200081A")]
  public class FormationSlotEquipmentThumb : MonoBehaviour, IFormationSlotEquipmentThumb
  {
    [Token(Token = "0x4002658")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002659")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x400265A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400265B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400265C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400265D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] offObjs;
    [Token(Token = "0x400265E")]
    protected const string TweenEquipmentNormal = "LostIcon_In";
    [Token(Token = "0x400265F")]
    protected const string TweenEquipmentCaution = "LostIcon_Out";
    [Token(Token = "0x4002660")]
    [FieldOffset(Offset = "0x48")]
    private Action onClick;
    [Token(Token = "0x4002661")]
    [FieldOffset(Offset = "0x50")]
    private Action onLongPress;
    [Token(Token = "0x4002662")]
    [FieldOffset(Offset = "0x58")]
    private EquipmentSlotThumbModel model;
    [Token(Token = "0x4002663")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002E74")]
    [Address(RVA = "0x3A94BAC", Offset = "0x3A94BAC", VA = "0x3A94BAC", Slot = "4")]
    public void Initialize(
      CommonButton button,
      CommonButton lockButton,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E75")]
    [Address(RVA = "0x3A94D48", Offset = "0x3A94D48", VA = "0x3A94D48", Slot = "5")]
    public void SetAction(Action onClick = null, Action onLongPress = null)
    {
    }

    [Token(Token = "0x6002E76")]
    [Address(RVA = "0x3A94D50", Offset = "0x3A94D50", VA = "0x3A94D50", Slot = "6")]
    public void UpdateView(EquipmentSlotThumbModel model)
    {
    }

    [Token(Token = "0x6002E77")]
    [Address(RVA = "0x3A94D8C", Offset = "0x3A94D8C", VA = "0x3A94D8C")]
    private void Empty()
    {
    }

    [Token(Token = "0x6002E78")]
    [Address(RVA = "0x3A94DB0", Offset = "0x3A94DB0", VA = "0x3A94DB0")]
    private void Default()
    {
    }

    [Token(Token = "0x6002E79")]
    [Address(RVA = "0x3A95200", Offset = "0x3A95200", VA = "0x3A95200")]
    public void ShowThumbnail(AssetCachedSpawner spawner, WeaponData weaponData)
    {
    }

    [Token(Token = "0x6002E7A")]
    [Address(RVA = "0x3A9546C", Offset = "0x3A9546C", VA = "0x3A9546C")]
    public void SetIconImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002E7B")]
    [Address(RVA = "0x3A95504", Offset = "0x3A95504", VA = "0x3A95504")]
    public void PlayGrayOut(bool isGrayOut)
    {
    }

    [Token(Token = "0x6002E7C")]
    [Address(RVA = "0x3A955A0", Offset = "0x3A955A0", VA = "0x3A955A0")]
    public void PlaySelect(bool isSelect)
    {
    }

    [Token(Token = "0x6002E7D")]
    [Address(RVA = "0x3A95578", Offset = "0x3A95578", VA = "0x3A95578")]
    private void PlayTween(bool isIn, string inAnim, string outAnim, bool stop = true)
    {
    }

    [Token(Token = "0x6002E7E")]
    [Address(RVA = "0x3A9500C", Offset = "0x3A9500C", VA = "0x3A9500C")]
    private (string, string) GetThumbAssetName() => ();

    [Token(Token = "0x6002E7F")]
    [Address(RVA = "0x3A95614", Offset = "0x3A95614", VA = "0x3A95614")]
    public FormationSlotEquipmentThumb()
    {
    }
  }
}
