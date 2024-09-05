// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultUnit.ResultEquipCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Effect;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle.ResultUnit
{
  [Token(Token = "0x20037B7")]
  public class ResultEquipCell : MonoBehaviour
  {
    [Token(Token = "0x400F395")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _levelText;
    [Token(Token = "0x400F396")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Slider _expSlider;
    [Token(Token = "0x400F397")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image _thumbBase;
    [Token(Token = "0x400F398")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image _thumbImage;
    [Token(Token = "0x400F399")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TweenWeaponLvUpView _lvUpTween;
    [Token(Token = "0x400F39A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image _frameImage;
    [Token(Token = "0x400F39B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject[] _unopenedNonDispObj;

    [Token(Token = "0x6015EE8")]
    [Address(RVA = "0x2320ACC", Offset = "0x2320ACC", VA = "0x2320ACC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015EE9")]
    [Address(RVA = "0x23298EC", Offset = "0x23298EC", VA = "0x23298EC")]
    public void Show(bool isShow = true)
    {
    }

    [Token(Token = "0x6015EEA")]
    [Address(RVA = "0x2329E44", Offset = "0x2329E44", VA = "0x2329E44")]
    public void Hide()
    {
    }

    [Token(Token = "0x6015EEB")]
    [Address(RVA = "0x2329914", Offset = "0x2329914", VA = "0x2329914")]
    public void ShowEquip(bool isEquiped, bool isOpened)
    {
    }

    [Token(Token = "0x6015EEC")]
    [Address(RVA = "0x2329C90", Offset = "0x2329C90", VA = "0x2329C90")]
    public void SetLevel(int level)
    {
    }

    [Token(Token = "0x6015EED")]
    [Address(RVA = "0x2329D60", Offset = "0x2329D60", VA = "0x2329D60")]
    public void SetExpRate(float exp)
    {
    }

    [Token(Token = "0x6015EEE")]
    [Address(RVA = "0x2329E4C", Offset = "0x2329E4C", VA = "0x2329E4C")]
    public void SetThumbBase(Sprite sprite)
    {
    }

    [Token(Token = "0x6015EEF")]
    [Address(RVA = "0x2329EE0", Offset = "0x2329EE0", VA = "0x2329EE0")]
    public void SetThumbImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6015EF0")]
    [Address(RVA = "0x2329B38", Offset = "0x2329B38", VA = "0x2329B38")]
    public void PlayLvUp()
    {
    }

    [Token(Token = "0x6015EF1")]
    [Address(RVA = "0x2322098", Offset = "0x2322098", VA = "0x2322098")]
    public void ExpSliderAnimation(
      GaugeUpControl gaugeUpControl,
      EquipExpData beforExp,
      EquipExpData afterExp,
      int beforExpNum,
      int afterExpNum,
      int weaponCount,
      bool weapon,
      UITweenGroup tweenGroup)
    {
    }

    [Token(Token = "0x6015EF2")]
    [Address(RVA = "0x2329FD4", Offset = "0x2329FD4", VA = "0x2329FD4")]
    public ResultEquipCell()
    {
    }
  }
}
