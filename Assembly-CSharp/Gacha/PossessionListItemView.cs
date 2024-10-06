// Decompiled with JetBrains decompiler
// Type: Gacha.PossessionListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001554")]
  internal class PossessionListItemView : MonoBehaviour
  {
    [Token(Token = "0x40061FB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x40061FC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject periodRoot;
    [Token(Token = "0x40061FD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textPeriod;
    [Token(Token = "0x40061FE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text textPossessionNum;
    [Token(Token = "0x40061FF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI textItemName;
    [Token(Token = "0x4006200")]
    [FieldOffset(Offset = "0x40")]
    private IPossessionListItemPresenter presenter;

    [Token(Token = "0x1700128E")]
    public IPossessionListItemPresenter Presenter
    {
      [Token(Token = "0x60078C6"), Address(RVA = "0x44FDF48", Offset = "0x44FDF48", VA = "0x44FDF48")] set
      {
      }
    }

    [Token(Token = "0x60078C7")]
    [Address(RVA = "0x44FDFEC", Offset = "0x44FDFEC", VA = "0x44FDFEC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60078C8")]
    [Address(RVA = "0x44FDE98", Offset = "0x44FDE98", VA = "0x44FDE98")]
    public void SetItemIcon(ItemUtility.Parameter parameter)
    {
    }

    [Token(Token = "0x60078C9")]
    [Address(RVA = "0x44FE0C8", Offset = "0x44FE0C8", VA = "0x44FE0C8")]
    private IEnumerator LoadItemIcon(ItemUtility.Parameter parameter) => (IEnumerator) null;

    [Token(Token = "0x60078CA")]
    [Address(RVA = "0x44FDED4", Offset = "0x44FDED4", VA = "0x44FDED4")]
    public void SetPeriodTextActive(bool isActive)
    {
    }

    [Token(Token = "0x60078CB")]
    [Address(RVA = "0x44FDE74", Offset = "0x44FDE74", VA = "0x44FDE74")]
    public void SetItemName(string text)
    {
    }

    [Token(Token = "0x60078CC")]
    [Address(RVA = "0x44FDF04", Offset = "0x44FDF04", VA = "0x44FDF04")]
    public void SetPeriodText(string text)
    {
    }

    [Token(Token = "0x60078CD")]
    [Address(RVA = "0x44FDE50", Offset = "0x44FDE50", VA = "0x44FDE50")]
    public void SetPossessionNumText(string text)
    {
    }

    [Token(Token = "0x60078CE")]
    [Address(RVA = "0x44FE174", Offset = "0x44FE174", VA = "0x44FE174")]
    public PossessionListItemView()
    {
    }
  }
}
