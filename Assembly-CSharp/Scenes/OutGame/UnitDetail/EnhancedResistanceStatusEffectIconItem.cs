// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.EnhancedResistanceStatusEffectIconItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032CE")]
  public class EnhancedResistanceStatusEffectIconItem : MonoBehaviour
  {
    [Token(Token = "0x400DB08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private DuelAbnormalStatusIcon abnormalStatusIcon;
    [Token(Token = "0x400DB09")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SignedValueText signedValueText;
    [Token(Token = "0x400DB0A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DB0B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject iconObj;
    [Token(Token = "0x400DB0C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject lineObj;
    [Token(Token = "0x400DB0D")]
    private const string TweenGroupIdColorNormal = "Color_Normal";
    [Token(Token = "0x400DB0E")]
    private const string TweenGroupIdColorDisable = "Color_Disable";

    [Token(Token = "0x6013F5B")]
    [Address(RVA = "0x2343540", Offset = "0x2343540", VA = "0x2343540")]
    public void Initialize(BattleBadStatusTypeEnum statusType, int value)
    {
    }

    [Token(Token = "0x6013F5C")]
    [Address(RVA = "0x2343740", Offset = "0x2343740", VA = "0x2343740")]
    public IEnumerator SetIconTween(bool isNormal) => (IEnumerator) null;

    [Token(Token = "0x6013F5D")]
    [Address(RVA = "0x23437E4", Offset = "0x23437E4", VA = "0x23437E4")]
    public void Hide()
    {
    }

    [Token(Token = "0x6013F5E")]
    [Address(RVA = "0x234383C", Offset = "0x234383C", VA = "0x234383C")]
    public EnhancedResistanceStatusEffectIconItem()
    {
    }
  }
}
