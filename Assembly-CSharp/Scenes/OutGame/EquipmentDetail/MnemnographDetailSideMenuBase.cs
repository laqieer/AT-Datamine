// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographDetailSideMenuBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036D1")]
  public abstract class MnemnographDetailSideMenuBase : MonoBehaviour
  {
    [Token(Token = "0x400EEF7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Button minButton;
    [Token(Token = "0x400EEF8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Button minusButton;
    [Token(Token = "0x400EEF9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Button plusButton;
    [Token(Token = "0x400EEFA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Button maxButton;
    [Token(Token = "0x400EEFB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected CommonButton enhanceButton;
    [Token(Token = "0x400EEFC")]
    protected const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400EEFD")]
    [FieldOffset(Offset = "0x40")]
    protected MindEquipment selectMindEquipment;
    [Token(Token = "0x400EEFE")]
    [FieldOffset(Offset = "0x48")]
    protected GameObject thumbnailPrefab;
    [Token(Token = "0x400EEFF")]
    [FieldOffset(Offset = "0x50")]
    public Action<MindEquipment> updateInfo;

    [Token(Token = "0x601593A")]
    protected abstract void OnClickMinButton();

    [Token(Token = "0x601593B")]
    protected abstract void OnClickMinusButton();

    [Token(Token = "0x601593C")]
    protected abstract void OnClickPlusButton();

    [Token(Token = "0x601593D")]
    protected abstract void OnClickMaxButton();

    [Token(Token = "0x601593E")]
    protected abstract void OnClickEnhanceButton();

    [Token(Token = "0x601593F")]
    public abstract void Set(MindEquipment mindEquipment, Action onClickCloseButton);

    [Token(Token = "0x6015940")]
    protected abstract void UpdateInfo(MindEquipment mindEquipment);

    [Token(Token = "0x6015941")]
    protected abstract void InitializedInternal();

    [Token(Token = "0x6015942")]
    protected abstract IEnumerator Connect();

    [Token(Token = "0x6015943")]
    [Address(RVA = "0x1A651F4", Offset = "0x1A651F4", VA = "0x1A651F4")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6015944")]
    [Address(RVA = "0x1A653A0", Offset = "0x1A653A0", VA = "0x1A653A0")]
    protected bool ResponseCodeJudgement(int responseCode) => new bool();

    [Token(Token = "0x6015945")]
    [Address(RVA = "0x1A653D0", Offset = "0x1A653D0", VA = "0x1A653D0")]
    protected void SetButtonInteratable(bool can)
    {
    }

    [Token(Token = "0x6015946")]
    [Address(RVA = "0x1A65458", Offset = "0x1A65458", VA = "0x1A65458")]
    protected MnemnographDetailSideMenuBase()
    {
    }
  }
}
