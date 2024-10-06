// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContainerLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200371A")]
  public class ContainerLost : MonoBehaviour
  {
    [Token(Token = "0x400F09D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _costText;
    [Token(Token = "0x400F09E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _timeText;
    [Token(Token = "0x400F09F")]
    [FieldOffset(Offset = "0x28")]
    private TimeSpan lostRecoveryTimeDispLimit;

    [Token(Token = "0x6015B3C")]
    [Address(RVA = "0x1D89A08", Offset = "0x1D89A08", VA = "0x1D89A08")]
    public void SetCost(int cost, bool isEnough = true)
    {
    }

    [Token(Token = "0x6015B3D")]
    [Address(RVA = "0x1D89AFC", Offset = "0x1D89AFC", VA = "0x1D89AFC")]
    public void SetRecoveryTime(in TimeSpan timeSpan)
    {
    }

    [Token(Token = "0x6015B3E")]
    [Address(RVA = "0x1D89D98", Offset = "0x1D89D98", VA = "0x1D89D98")]
    public ContainerLost()
    {
    }
  }
}
