// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.WeaponProficiency.WeaponProficiencyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.WeaponProficiency
{
  [Token(Token = "0x20032DA")]
  public class WeaponProficiencyItem : MonoBehaviour
  {
    [Token(Token = "0x400DB47")]
    [FieldOffset(Offset = "0x18")]
    private string[] weaponTypeTextList;
    [Token(Token = "0x400DB48")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400DB49")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image weaponTypeImage;
    [Token(Token = "0x400DB4A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text weaponTypeText;
    [Token(Token = "0x400DB4B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider stockSlider;
    [Token(Token = "0x400DB4C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x400DB4D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text stockText;
    [Token(Token = "0x400DB4E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text nextExpText;
    [Token(Token = "0x400DB4F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text beforeProficiency;
    [Token(Token = "0x400DB50")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text afterProficiency;
    [Token(Token = "0x400DB51")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Color afterProficiencyColor;
    [Token(Token = "0x400DB52")]
    [FieldOffset(Offset = "0x78")]
    private WeaponTypeEnum weaponType;
    [Token(Token = "0x400DB53")]
    [FieldOffset(Offset = "0x80")]
    private StaqData.WeaponProficiency.LevelData levelData;
    [Token(Token = "0x400DB54")]
    [FieldOffset(Offset = "0x88")]
    private ProficiencyTypeEnum tmpProficiencyTypeEnum;
    [Token(Token = "0x400DB55")]
    [FieldOffset(Offset = "0x8C")]
    private ProficiencyTypeEnum maxProficiencyType;
    [Token(Token = "0x400DB56")]
    [FieldOffset(Offset = "0x90")]
    private int nowStock;
    [Token(Token = "0x400DB57")]
    [FieldOffset(Offset = "0x94")]
    private int caluclateStock;
    [Token(Token = "0x400DB58")]
    [FieldOffset(Offset = "0x98")]
    private int tmpStock;
    [Token(Token = "0x400DB5A")]
    [FieldOffset(Offset = "0xA8")]
    private int connectExp;
    [Token(Token = "0x400DB5B")]
    [FieldOffset(Offset = "0xAC")]
    private int sliderValue;
    [Token(Token = "0x400DB5C")]
    [FieldOffset(Offset = "0xB0")]
    private int nowProficiencyExp;

    [Token(Token = "0x17004306")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6013F9B"), Address(RVA = "0x23454EC", Offset = "0x23454EC", VA = "0x23454EC")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004307")]
    public Action OnValueChangeAction
    {
      [Token(Token = "0x6013F9C"), Address(RVA = "0x23454F4", Offset = "0x23454F4", VA = "0x23454F4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013F9D"), Address(RVA = "0x23454FC", Offset = "0x23454FC", VA = "0x23454FC")] set
      {
      }
    }

    [Token(Token = "0x6013F9E")]
    [Address(RVA = "0x2345504", Offset = "0x2345504", VA = "0x2345504")]
    public void Initialize(
      WeaponTypeEnum weaponType,
      StaqData.WeaponProficiency.LevelData levelData,
      int stock)
    {
    }

    [Token(Token = "0x6013F9F")]
    [Address(RVA = "0x2345868", Offset = "0x2345868", VA = "0x2345868")]
    public void OnValueChange(float val)
    {
    }

    [Token(Token = "0x6013FA0")]
    [Address(RVA = "0x2345B38", Offset = "0x2345B38", VA = "0x2345B38")]
    public void AddValueChange()
    {
    }

    [Token(Token = "0x6013FA1")]
    [Address(RVA = "0x2345B7C", Offset = "0x2345B7C", VA = "0x2345B7C")]
    public void SubValueChange()
    {
    }

    [Token(Token = "0x6013FA2")]
    [Address(RVA = "0x2345BB8", Offset = "0x2345BB8", VA = "0x2345BB8")]
    public void MaxValueChange()
    {
    }

    [Token(Token = "0x6013FA3")]
    [Address(RVA = "0x2345944", Offset = "0x2345944", VA = "0x2345944")]
    private void SliderUpdate()
    {
    }

    [Token(Token = "0x6013FA4")]
    [Address(RVA = "0x2345A60", Offset = "0x2345A60", VA = "0x2345A60")]
    private void Caluclate(int dir, int addExp = 1)
    {
    }

    [Token(Token = "0x6013FA5")]
    [Address(RVA = "0x2345C04", Offset = "0x2345C04", VA = "0x2345C04")]
    private void UpdateUI(int addExp)
    {
    }

    [Token(Token = "0x6013FA6")]
    [Address(RVA = "0x2345F7C", Offset = "0x2345F7C", VA = "0x2345F7C")]
    public bool IsAddUse() => new bool();

    [Token(Token = "0x6013FA7")]
    [Address(RVA = "0x2345F8C", Offset = "0x2345F8C", VA = "0x2345F8C")]
    public void Clear()
    {
    }

    [Token(Token = "0x6013FA8")]
    [Address(RVA = "0x2345FC0", Offset = "0x2345FC0", VA = "0x2345FC0")]
    public WeaponProficiencyItem()
    {
    }
  }
}
