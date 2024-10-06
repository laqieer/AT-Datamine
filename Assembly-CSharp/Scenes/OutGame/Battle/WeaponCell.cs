// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.WeaponCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x20037AE")]
  public class WeaponCell : MonoBehaviour
  {
    [Token(Token = "0x400F367")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string levelupAnimName;
    [Token(Token = "0x400F368")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string lostAnimName;
    [Token(Token = "0x400F369")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string signatureGetAnimName;
    [Token(Token = "0x400F36A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F36B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text maxDurability;
    [Token(Token = "0x400F36C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text afterDurability;
    [Token(Token = "0x400F36D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI level;
    [Token(Token = "0x400F36E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x400F36F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject lost;
    [Token(Token = "0x400F370")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] durabilityObjects;
    [Token(Token = "0x400F371")]
    [FieldOffset(Offset = "0x68")]
    private int tempLevel;
    [Token(Token = "0x400F372")]
    [FieldOffset(Offset = "0x70")]
    private WeaponExpData weaponExp;

    [Token(Token = "0x6015EBD")]
    [Address(RVA = "0x2328264", Offset = "0x2328264", VA = "0x2328264")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015EBE")]
    [Address(RVA = "0x23282BC", Offset = "0x23282BC", VA = "0x23282BC")]
    public void Show(ResultData.WeaponDifference diffWeapon)
    {
    }

    [Token(Token = "0x6015EBF")]
    [Address(RVA = "0x2328298", Offset = "0x2328298", VA = "0x2328298")]
    public void Hide()
    {
    }

    [Token(Token = "0x6015EC0")]
    [Address(RVA = "0x2328620", Offset = "0x2328620", VA = "0x2328620")]
    public void SetExp(int exp)
    {
    }

    [Token(Token = "0x6015EC1")]
    [Address(RVA = "0x23285AC", Offset = "0x23285AC", VA = "0x23285AC")]
    private void SetActiveDurabilityObjects(bool isActive)
    {
    }

    [Token(Token = "0x6015EC2")]
    [Address(RVA = "0x23287A8", Offset = "0x23287A8", VA = "0x23287A8")]
    public WeaponCell()
    {
    }
  }
}
