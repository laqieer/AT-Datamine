// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDSimpleCoinView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A6")]
  public class FgGIDSimpleCoinView : MonoBehaviour
  {
    [Token(Token = "0x4006E1E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("FgGコイン今月消失数")]
    private RawImage imageCoinIcon;
    [Token(Token = "0x4006E1F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("FgGコイン所持数")]
    [Space(10f)]
    private TextMeshProUGUI textCoinAmount;
    [Token(Token = "0x4006E20")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(10f)]
    [Header("FgGコイン今月消失数")]
    private TextMeshProUGUI textDisappearCoinAmount;
    [Token(Token = "0x4006E21")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    [Header("詳細ボタン")]
    [SerializeField]
    private Button buttonDetail;
    [Token(Token = "0x4006E22")]
    [FieldOffset(Offset = "0x38")]
    [Space(10f)]
    [Header("FgGIDコインショップボタン")]
    [SerializeField]
    private Button buttonFgGIDCoinShop;
    [Token(Token = "0x4006E23")]
    [FieldOffset(Offset = "0x40")]
    private IFgGIDSimpleCoinPresenter presenter;

    [Token(Token = "0x1700178D")]
    public IFgGIDSimpleCoinPresenter Presenter
    {
      [Token(Token = "0x6009258"), Address(RVA = "0x4D0C470", Offset = "0x4D0C470", VA = "0x4D0C470")] set
      {
      }
    }

    [Token(Token = "0x6009259")]
    [Address(RVA = "0x4D10130", Offset = "0x4D10130", VA = "0x4D10130")]
    private void Awake()
    {
    }

    [Token(Token = "0x600925A")]
    [Address(RVA = "0x4D10240", Offset = "0x4D10240", VA = "0x4D10240")]
    public void SetCoinIcon(Texture texture)
    {
    }

    [Token(Token = "0x600925B")]
    [Address(RVA = "0x4D0F560", Offset = "0x4D0F560", VA = "0x4D0F560")]
    public void SetCoinAmountText(string value)
    {
    }

    [Token(Token = "0x600925C")]
    [Address(RVA = "0x4D0F584", Offset = "0x4D0F584", VA = "0x4D0F584")]
    public void SetDisappearCoinAmountText(string value)
    {
    }

    [Token(Token = "0x600925D")]
    [Address(RVA = "0x4D10290", Offset = "0x4D10290", VA = "0x4D10290")]
    private void OnDetailButtonClicked()
    {
    }

    [Token(Token = "0x600925E")]
    [Address(RVA = "0x4D10330", Offset = "0x4D10330", VA = "0x4D10330")]
    private void OnFgGIDCoinShopButtonClicked()
    {
    }

    [Token(Token = "0x600925F")]
    [Address(RVA = "0x4D103D4", Offset = "0x4D103D4", VA = "0x4D103D4")]
    public FgGIDSimpleCoinView()
    {
    }
  }
}
