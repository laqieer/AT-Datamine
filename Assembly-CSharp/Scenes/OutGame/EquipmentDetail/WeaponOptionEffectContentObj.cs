// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponOptionEffectContentObj
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036C3")]
  public class WeaponOptionEffectContentObj : MonoBehaviour
  {
    [Token(Token = "0x400EEA6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image _optionEffectIcon;
    [Token(Token = "0x400EEA7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _optionEffectName;
    [Token(Token = "0x400EEA8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _optionEffectSign;
    [Token(Token = "0x400EEA9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _optionEffectValue;

    [Token(Token = "0x60158EB")]
    [Address(RVA = "0x1A62764", Offset = "0x1A62764", VA = "0x1A62764")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60158EC")]
    [Address(RVA = "0x1A6278C", Offset = "0x1A6278C", VA = "0x1A6278C")]
    public void SetNameValue(string name, float value)
    {
    }

    [Token(Token = "0x60158ED")]
    [Address(RVA = "0x1A62934", Offset = "0x1A62934", VA = "0x1A62934")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x60158EE")]
    [Address(RVA = "0x1A62A20", Offset = "0x1A62A20", VA = "0x1A62A20")]
    public WeaponOptionEffectContentObj()
    {
    }
  }
}
