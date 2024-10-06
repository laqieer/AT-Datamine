// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionAppIconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A2")]
  public class FgGIDMissionAppIconView : MonoBehaviour
  {
    [Token(Token = "0x4006E04")]
    [FieldOffset(Offset = "0x18")]
    [Header("有効状態のオブジェクトの親")]
    [SerializeField]
    private GameObject enabledRoot;
    [Token(Token = "0x4006E05")]
    [FieldOffset(Offset = "0x20")]
    [Header("有効状態のアプリアイコン表示用")]
    [Space(10f)]
    [SerializeField]
    private RawImage enabledAppIcon;
    [Token(Token = "0x4006E06")]
    [FieldOffset(Offset = "0x28")]
    [Header("無効状態のオブジェクトの親")]
    [SerializeField]
    [Space(10f)]
    private GameObject disabledRoot;
    [Token(Token = "0x4006E07")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    [Header("連携状態")]
    [SerializeField]
    private GameObject linkedObjectRoot;
    [Token(Token = "0x4006E08")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject[] notLinkedObjects;
    [Token(Token = "0x4006E09")]
    [FieldOffset(Offset = "0x40")]
    [Space(10f)]
    [Header("選択状態")]
    [SerializeField]
    private GameObject selectedObjectRoot;
    [Token(Token = "0x4006E0A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("ボタン")]
    [Space(10f)]
    private Button buttonIcon;
    [Token(Token = "0x4006E0B")]
    [FieldOffset(Offset = "0x50")]
    private IFgGIDMissionAppIconPresenter presenter;

    [Token(Token = "0x1700178A")]
    public IFgGIDMissionAppIconPresenter Presenter
    {
      [Token(Token = "0x600923A"), Address(RVA = "0x4D0E4F0", Offset = "0x4D0E4F0", VA = "0x4D0E4F0")] set
      {
      }
    }

    [Token(Token = "0x600923B")]
    [Address(RVA = "0x4D0FAAC", Offset = "0x4D0FAAC", VA = "0x4D0FAAC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600923C")]
    [Address(RVA = "0x4D0E5AC", Offset = "0x4D0E5AC", VA = "0x4D0E5AC")]
    public void SetIsEnable(bool isEnable)
    {
    }

    [Token(Token = "0x600923D")]
    [Address(RVA = "0x4D0FB40", Offset = "0x4D0FB40", VA = "0x4D0FB40")]
    public void SetAppIcon(Texture texture)
    {
    }

    [Token(Token = "0x600923E")]
    [Address(RVA = "0x4D0E750", Offset = "0x4D0E750", VA = "0x4D0E750")]
    public void SetLinkStatus(bool isLinked)
    {
    }

    [Token(Token = "0x600923F")]
    [Address(RVA = "0x4D0E8A4", Offset = "0x4D0E8A4", VA = "0x4D0E8A4")]
    public void SetIsSelect(bool isSelect)
    {
    }

    [Token(Token = "0x6009240")]
    [Address(RVA = "0x4D0FB98", Offset = "0x4D0FB98", VA = "0x4D0FB98")]
    private void OnIconClicked()
    {
    }

    [Token(Token = "0x6009241")]
    [Address(RVA = "0x4D0FC3C", Offset = "0x4D0FC3C", VA = "0x4D0FC3C")]
    public FgGIDMissionAppIconView()
    {
    }
  }
}
