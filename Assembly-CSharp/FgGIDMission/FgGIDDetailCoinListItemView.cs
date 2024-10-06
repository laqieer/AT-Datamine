// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDDetailCoinListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200199E")]
  public class FgGIDDetailCoinListItemView : MonoBehaviour
  {
    [Token(Token = "0x4006DF1")]
    [FieldOffset(Offset = "0x18")]
    [Header("獲得した月")]
    [SerializeField]
    private TextMeshProUGUI textReceivedMonth;
    [Token(Token = "0x4006DF2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("有効期限")]
    [Space(10f)]
    private TextMeshProUGUI textExpireDateTime;
    [Token(Token = "0x4006DF3")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [Header("コインの数")]
    [SerializeField]
    private TextMeshProUGUI textAmount;
    [Token(Token = "0x4006DF4")]
    [FieldOffset(Offset = "0x30")]
    private IFgGIDDetailCoinListItemPresenter presenter;

    [Token(Token = "0x17001786")]
    public IFgGIDDetailCoinListItemPresenter Presenter
    {
      [Token(Token = "0x6009225"), Address(RVA = "0x4D0E04C", Offset = "0x4D0E04C", VA = "0x4D0E04C")] set
      {
      }
    }

    [Token(Token = "0x6009226")]
    [Address(RVA = "0x4D0DBF8", Offset = "0x4D0DBF8", VA = "0x4D0DBF8")]
    public void SetReceivedMonth(string value)
    {
    }

    [Token(Token = "0x6009227")]
    [Address(RVA = "0x4D0DC1C", Offset = "0x4D0DC1C", VA = "0x4D0DC1C")]
    public void SetExpireDateTime(string value)
    {
    }

    [Token(Token = "0x6009228")]
    [Address(RVA = "0x4D0DC40", Offset = "0x4D0DC40", VA = "0x4D0DC40")]
    public void SetAmountText(string value)
    {
    }

    [Token(Token = "0x6009229")]
    [Address(RVA = "0x4D0F664", Offset = "0x4D0F664", VA = "0x4D0F664")]
    public FgGIDDetailCoinListItemView()
    {
    }
  }
}
