// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A5")]
  public class FgGIDMissionListView : MonoBehaviour
  {
    [Token(Token = "0x4006E19")]
    [FieldOffset(Offset = "0x18")]
    [Header("ミッションリスト表示用テンプレ")]
    [SerializeField]
    private FgGIDMissionListItemView templateListItemView;
    [Token(Token = "0x4006E1A")]
    [FieldOffset(Offset = "0x20")]
    [Header("リストが空の時に表示するオブジェクト")]
    [SerializeField]
    private GameObject objectEmptyList;
    [Token(Token = "0x4006E1B")]
    [FieldOffset(Offset = "0x28")]
    [Header("一括受け取りボタン")]
    [SerializeField]
    private CommonButton buttonBalkReceive;
    [Token(Token = "0x4006E1C")]
    [FieldOffset(Offset = "0x30")]
    private List<FgGIDMissionListItemView> listItems;
    [Token(Token = "0x4006E1D")]
    [FieldOffset(Offset = "0x38")]
    private IFgGIDMissionListPresenter presenter;

    [Token(Token = "0x1700178C")]
    public IFgGIDMissionListPresenter Presenter
    {
      [Token(Token = "0x6009251"), Address(RVA = "0x4D0C554", Offset = "0x4D0C554", VA = "0x4D0C554")] set
      {
      }
    }

    [Token(Token = "0x6009252")]
    [Address(RVA = "0x4D0FF2C", Offset = "0x4D0FF2C", VA = "0x4D0FF2C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009253")]
    [Address(RVA = "0x4D0F054", Offset = "0x4D0F054", VA = "0x4D0F054")]
    public void InitializeListItem(int count)
    {
    }

    [Token(Token = "0x6009254")]
    [Address(RVA = "0x4D10010", Offset = "0x4D10010", VA = "0x4D10010")]
    private void OnBalkReceiveButtonClicked()
    {
    }

    [Token(Token = "0x6009255")]
    [Address(RVA = "0x4D0FFE0", Offset = "0x4D0FFE0", VA = "0x4D0FFE0")]
    private void SetEmptyListActive(bool isActive)
    {
    }

    [Token(Token = "0x6009256")]
    [Address(RVA = "0x4D0F034", Offset = "0x4D0F034", VA = "0x4D0F034")]
    public void SetBalkReceiveButtonInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6009257")]
    [Address(RVA = "0x4D100B4", Offset = "0x4D100B4", VA = "0x4D100B4")]
    public FgGIDMissionListView()
    {
    }
  }
}
