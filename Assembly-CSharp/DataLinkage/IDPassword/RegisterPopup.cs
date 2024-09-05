// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.RegisterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FB3")]
  public class RegisterPopup : PopupBase
  {
    [Token(Token = "0x4008768")]
    private const string ResourcesPath = "UI/Common/Prefab/Com_Popup_Base_M_PasswordSetting";
    [Token(Token = "0x4008769")]
    private const char AsteriskChar = '＊';
    [Token(Token = "0x400876A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TMP_InputField inputFieldPassword;
    [Token(Token = "0x400876B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Toggle toggleShowPassword;
    [Token(Token = "0x400876C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton buttonDecide;
    [Token(Token = "0x400876D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton buttonCancel;
    [Token(Token = "0x400876E")]
    [FieldOffset(Offset = "0xA8")]
    public Action OnClickPasswordEdit;
    [Token(Token = "0x400876F")]
    [FieldOffset(Offset = "0xB0")]
    private IRegisterPopupPresenter presenter;

    [Token(Token = "0x170026EE")]
    public string Password
    {
      [Token(Token = "0x600BC26"), Address(RVA = "0x1E513FC", Offset = "0x1E513FC", VA = "0x1E513FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170026EF")]
    public IRegisterPopupPresenter Presenter
    {
      [Token(Token = "0x600BC27"), Address(RVA = "0x1E51358", Offset = "0x1E51358", VA = "0x1E51358")] set
      {
      }
    }

    [Token(Token = "0x600BC28")]
    [Address(RVA = "0x1E50F58", Offset = "0x1E50F58", VA = "0x1E50F58")]
    public static void Create(Transform parent, Action<RegisterPopup> onCreate)
    {
    }

    [Token(Token = "0x600BC29")]
    public static IEnumerator LoadResourceAsync<T>(string path, Action<T> onComplete) where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BC2A")]
    [Address(RVA = "0x1E51420", Offset = "0x1E51420", VA = "0x1E51420")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BC2B")]
    [Address(RVA = "0x1E5161C", Offset = "0x1E5161C", VA = "0x1E5161C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BC2C")]
    [Address(RVA = "0x1E516C4", Offset = "0x1E516C4", VA = "0x1E516C4")]
    private void SetTextSilent(TMP_InputField inputField, string text)
    {
    }

    [Token(Token = "0x600BC2D")]
    [Address(RVA = "0x1E51718", Offset = "0x1E51718", VA = "0x1E51718")]
    public void Initialize(string defaultPassword)
    {
    }

    [Token(Token = "0x600BC2E")]
    [Address(RVA = "0x1E51828", Offset = "0x1E51828", VA = "0x1E51828")]
    private void OnShowPasswordToggleChanged(bool isShow)
    {
    }

    [Token(Token = "0x600BC2F")]
    [Address(RVA = "0x1E5173C", Offset = "0x1E5173C", VA = "0x1E5173C")]
    private void UpdateButtonStatus()
    {
    }

    [Token(Token = "0x600BC30")]
    [Address(RVA = "0x1E51898", Offset = "0x1E51898", VA = "0x1E51898")]
    public void SetPassword(string password)
    {
    }

    [Token(Token = "0x600BC31")]
    [Address(RVA = "0x1E518D4", Offset = "0x1E518D4", VA = "0x1E518D4")]
    private void OnDecideButtonClicked()
    {
    }

    [Token(Token = "0x600BC32")]
    [Address(RVA = "0x1E51978", Offset = "0x1E51978", VA = "0x1E51978")]
    private void OnCancelButtonClicked()
    {
    }

    [Token(Token = "0x600BC33")]
    [Address(RVA = "0x1E51A1C", Offset = "0x1E51A1C", VA = "0x1E51A1C")]
    public RegisterPopup()
    {
    }
  }
}
