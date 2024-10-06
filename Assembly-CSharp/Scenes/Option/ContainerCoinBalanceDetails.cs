// Decompiled with JetBrains decompiler
// Type: Scenes.Option.ContainerCoinBalanceDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Option
{
  [Token(Token = "0x2002A66")]
  public class ContainerCoinBalanceDetails : MonoBehaviour
  {
    [Token(Token = "0x400B47E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI currencyPaidText;
    [Token(Token = "0x400B47F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI currencyFreeText;

    [Token(Token = "0x60109A0")]
    [Address(RVA = "0x4C311C4", Offset = "0x4C311C4", VA = "0x4C311C4")]
    public void SetData(int paidCoin, int freeCoin)
    {
    }

    [Token(Token = "0x60109A1")]
    [Address(RVA = "0x4C3125C", Offset = "0x4C3125C", VA = "0x4C3125C")]
    public ContainerCoinBalanceDetails()
    {
    }
  }
}
