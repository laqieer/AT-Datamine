// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListCommuRankGaugeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E9A")]
  public class KizunaListCommuRankGaugeIcon : MonoBehaviour
  {
    [Token(Token = "0x400C7C1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI kizunaRankNumText;
    [Token(Token = "0x400C7C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject kizunaCanRankUpIcon;
    [Token(Token = "0x400C7C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider gaugeSlider;

    [Token(Token = "0x6012316")]
    [Address(RVA = "0x4594388", Offset = "0x4594388", VA = "0x4594388")]
    public void SetActive(bool value)
    {
    }

    [Token(Token = "0x6012317")]
    [Address(RVA = "0x45943B0", Offset = "0x45943B0", VA = "0x45943B0")]
    public void SetRank(int rank)
    {
    }

    [Token(Token = "0x6012318")]
    [Address(RVA = "0x45943F8", Offset = "0x45943F8", VA = "0x45943F8")]
    public void SetGaugeValue(float value)
    {
    }

    [Token(Token = "0x6012319")]
    [Address(RVA = "0x45944A8", Offset = "0x45944A8", VA = "0x45944A8")]
    public KizunaListCommuRankGaugeIcon()
    {
    }
  }
}
