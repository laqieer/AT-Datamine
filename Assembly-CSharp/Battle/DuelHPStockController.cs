// Decompiled with JetBrains decompiler
// Type: Battle.DuelHPStockController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002285")]
  public class DuelHPStockController : MonoBehaviour
  {
    [Token(Token = "0x400918A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject dispAlly;
    [Token(Token = "0x400918B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject dispGuest;
    [Token(Token = "0x400918C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject dispEnemy;
    [Token(Token = "0x400918D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject dispAnotherForce;
    [Token(Token = "0x400918E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text countText;
    [Token(Token = "0x400918F")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ShowFrontKey;
    [Token(Token = "0x4009190")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string HideFrontKey;
    [Token(Token = "0x4009191")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string ShowBackKey;
    [Token(Token = "0x4009192")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string HideBackKey;
    [Token(Token = "0x4009193")]
    [FieldOffset(Offset = "0x40")]
    private UITweenGroup _tweenGroup;

    [Token(Token = "0x600D26C")]
    [Address(RVA = "0x1961070", Offset = "0x1961070", VA = "0x1961070")]
    public void Initialize(UITweenGroup tweenGroup)
    {
    }

    [Token(Token = "0x600D26D")]
    [Address(RVA = "0x1961078", Offset = "0x1961078", VA = "0x1961078")]
    public void ShowFront()
    {
    }

    [Token(Token = "0x600D26E")]
    [Address(RVA = "0x19610EC", Offset = "0x19610EC", VA = "0x19610EC")]
    public void ShowBack()
    {
    }

    [Token(Token = "0x600D26F")]
    [Address(RVA = "0x1961160", Offset = "0x1961160", VA = "0x1961160")]
    public void HideFront()
    {
    }

    [Token(Token = "0x600D270")]
    [Address(RVA = "0x19611D4", Offset = "0x19611D4", VA = "0x19611D4")]
    public void HideBack()
    {
    }

    [Token(Token = "0x600D271")]
    [Address(RVA = "0x1961248", Offset = "0x1961248", VA = "0x1961248")]
    public void SetCountText(int num)
    {
    }

    [Token(Token = "0x600D272")]
    [Address(RVA = "0x1961290", Offset = "0x1961290", VA = "0x1961290")]
    public void TurnColorByForceType(ForceTypeEnum forceTypeEnum)
    {
    }

    [Token(Token = "0x600D273")]
    [Address(RVA = "0x1961360", Offset = "0x1961360", VA = "0x1961360")]
    public DuelHPStockController()
    {
    }

    [Token(Token = "0x600D274")]
    [Address(RVA = "0x1961368", Offset = "0x1961368", VA = "0x1961368")]
    static DuelHPStockController()
    {
    }
  }
}
