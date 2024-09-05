// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.BtnCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000925")]
  public class BtnCoin : MonoBehaviour
  {
    [Token(Token = "0x4002A8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton _button;
    [Token(Token = "0x4002A8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _coinNum;

    [Token(Token = "0x600337E")]
    [Address(RVA = "0x3628DD4", Offset = "0x3628DD4", VA = "0x3628DD4")]
    public void SetCoinNum(int coinNum)
    {
    }

    [Token(Token = "0x600337F")]
    [Address(RVA = "0x3628E20", Offset = "0x3628E20", VA = "0x3628E20")]
    public void SetOnClickEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6003380")]
    [Address(RVA = "0x3628E70", Offset = "0x3628E70", VA = "0x3628E70")]
    public BtnCoin()
    {
    }
  }
}
