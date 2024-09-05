// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContentMasterBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003510")]
  public class ContentMasterBonus : MonoBehaviour
  {
    [Token(Token = "0x400E6E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image imageMainIcon;
    [Token(Token = "0x400E6E3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image imageMiniIcon;
    [Token(Token = "0x400E6E4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textName;
    [Token(Token = "0x400E6E5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("ボタン")]
    [Space]
    private CommonButton buttonDetail;
    [Token(Token = "0x400E6E6")]
    [FieldOffset(Offset = "0x38")]
    [Space]
    [Header("経験値の表示制御")]
    [SerializeField]
    private Text textLevel;
    [Token(Token = "0x400E6E7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text textNextExp;
    [Token(Token = "0x400E6E8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider sliderExp;
    [Token(Token = "0x400E6E9")]
    [FieldOffset(Offset = "0x50")]
    [Space]
    [SerializeField]
    [Header("次のレベルがある時に表示するオブジェクト")]
    private GameObject[] currentLevelObjects;
    [Token(Token = "0x400E6EA")]
    [FieldOffset(Offset = "0x58")]
    [Space]
    [Header("最大レベルの時に表示するオブジェクト")]
    [SerializeField]
    private GameObject[] maxLevelObjects;
    [Token(Token = "0x400E6EB")]
    [FieldOffset(Offset = "0x60")]
    public Action OnClickDetail;

    [Token(Token = "0x6014D09")]
    [Address(RVA = "0x1B39DB4", Offset = "0x1B39DB4", VA = "0x1B39DB4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014D0A")]
    [Address(RVA = "0x1B39E54", Offset = "0x1B39E54", VA = "0x1B39E54")]
    public void Setup(
      int level,
      int currentExperience,
      int nextLevelExperience,
      bool isMaxLevel,
      int nowLevelExperienceFrom)
    {
    }

    [Token(Token = "0x6014D0B")]
    [Address(RVA = "0x1B39F68", Offset = "0x1B39F68", VA = "0x1B39F68")]
    private void SetIsMaxLevel(bool isMaxLevel)
    {
    }

    [Token(Token = "0x6014D0C")]
    [Address(RVA = "0x1B39EE8", Offset = "0x1B39EE8", VA = "0x1B39EE8")]
    private void SetLevel(int level)
    {
    }

    [Token(Token = "0x6014D0D")]
    [Address(RVA = "0x1B39F30", Offset = "0x1B39F30", VA = "0x1B39F30")]
    private void SetNextExperience(int experience)
    {
    }

    [Token(Token = "0x6014D0E")]
    [Address(RVA = "0x1B3A138", Offset = "0x1B3A138", VA = "0x1B3A138")]
    public ContentMasterBonus()
    {
    }
  }
}
