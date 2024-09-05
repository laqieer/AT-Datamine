// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDDetailCoinView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200199F")]
  public class FgGIDDetailCoinView : MonoBehaviour
  {
    [Token(Token = "0x4006DF5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("FgGコインの合計所持数")]
    private TextMeshProUGUI textTotalCoinAmount;
    [Token(Token = "0x4006DF6")]
    [FieldOffset(Offset = "0x20")]
    [Header("コイン未所持の時に表示するオブジェクト")]
    [SerializeField]
    private GameObject emptyList;
    [Token(Token = "0x4006DF7")]
    [FieldOffset(Offset = "0x28")]
    [Header("FgGコインの詳細リスト表示用テンプレ")]
    [SerializeField]
    private FgGIDDetailCoinListItemView templateListItemView;
    [Token(Token = "0x4006DF8")]
    [FieldOffset(Offset = "0x30")]
    private List<FgGIDDetailCoinListItemView> listItems;
    [Token(Token = "0x4006DF9")]
    [FieldOffset(Offset = "0x38")]
    private IFgGIDDetailCoinPresenter presenter;

    [Token(Token = "0x17001787")]
    public IFgGIDDetailCoinPresenter Presenter
    {
      [Token(Token = "0x600922A"), Address(RVA = "0x4D0CC70", Offset = "0x4D0CC70", VA = "0x4D0CC70")] set
      {
      }
    }

    [Token(Token = "0x600922B")]
    [Address(RVA = "0x4D0DD18", Offset = "0x4D0DD18", VA = "0x4D0DD18")]
    public void InitializeListItem(int count)
    {
    }

    [Token(Token = "0x600922C")]
    [Address(RVA = "0x4D0F66C", Offset = "0x4D0F66C", VA = "0x4D0F66C")]
    private void SetEmptyListActive(bool isActive)
    {
    }

    [Token(Token = "0x600922D")]
    [Address(RVA = "0x4D0DCF4", Offset = "0x4D0DCF4", VA = "0x4D0DCF4")]
    public void SetTotalCoinAmount(string value)
    {
    }

    [Token(Token = "0x600922E")]
    [Address(RVA = "0x4D0F68C", Offset = "0x4D0F68C", VA = "0x4D0F68C")]
    public FgGIDDetailCoinView()
    {
    }
  }
}
