// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.AddDevicePopup
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
  [Token(Token = "0x2001F95")]
  public class AddDevicePopup : CommonPopup
  {
    [Token(Token = "0x4008701")]
    private const string ResourcesPath = "UI/Common/Prefab/Com_Popup_Base_M_UserCode";
    [Token(Token = "0x4008702")]
    private const char AsteriskChar = '＊';
    [Token(Token = "0x4008703")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private TMP_InputField inputFieldID;
    [Token(Token = "0x4008704")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private TMP_Text displayID;
    [Token(Token = "0x4008705")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private TMP_InputField inputFieldPassword;
    [Token(Token = "0x4008706")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private Toggle toggleShowPassword;
    [Token(Token = "0x4008707")]
    [FieldOffset(Offset = "0x148")]
    public Action OnClickIDEdit;
    [Token(Token = "0x4008708")]
    [FieldOffset(Offset = "0x150")]
    public Action OnClickPasswordEdit;
    [Token(Token = "0x4008709")]
    [FieldOffset(Offset = "0x158")]
    private IAddDevicePopupPresenter presenter;

    [Token(Token = "0x170026D4")]
    public string ID
    {
      [Token(Token = "0x600BB7B"), Address(RVA = "0x1E4D950", Offset = "0x1E4D950", VA = "0x1E4D950")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170026D5")]
    public string Password
    {
      [Token(Token = "0x600BB7C"), Address(RVA = "0x1E4D96C", Offset = "0x1E4D96C", VA = "0x1E4D96C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170026D6")]
    public IAddDevicePopupPresenter Presenter
    {
      [Token(Token = "0x600BB7D"), Address(RVA = "0x1E4D8AC", Offset = "0x1E4D8AC", VA = "0x1E4D8AC")] set
      {
      }
    }

    [Token(Token = "0x600BB7E")]
    [Address(RVA = "0x1E4D554", Offset = "0x1E4D554", VA = "0x1E4D554")]
    public static void Create(Transform parent, Action<AddDevicePopup> onCreate)
    {
    }

    [Token(Token = "0x600BB7F")]
    private static IEnumerator LoadResourceAsync<T>(string path, Action<T> onComplete) where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BB80")]
    [Address(RVA = "0x1E4D990", Offset = "0x1E4D990", VA = "0x1E4D990")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BB81")]
    [Address(RVA = "0x1E4DC00", Offset = "0x1E4DC00", VA = "0x1E4DC00")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BB82")]
    [Address(RVA = "0x1E4DCA8", Offset = "0x1E4DCA8", VA = "0x1E4DCA8")]
    public void Initialize(string defaultId, string defaultPassword)
    {
    }

    [Token(Token = "0x600BB83")]
    [Address(RVA = "0x1E4DCE4", Offset = "0x1E4DCE4", VA = "0x1E4DCE4")]
    private void SetTextSilent(TMP_InputField inputField, string text)
    {
    }

    [Token(Token = "0x600BB84")]
    [Address(RVA = "0x1E4DDE0", Offset = "0x1E4DDE0", VA = "0x1E4DDE0")]
    private void OnShowPasswordToggleChanged(bool isShow)
    {
    }

    [Token(Token = "0x600BB85")]
    [Address(RVA = "0x1E4DD38", Offset = "0x1E4DD38", VA = "0x1E4DD38")]
    private void UpdateButtonStatus()
    {
    }

    [Token(Token = "0x600BB86")]
    [Address(RVA = "0x1E4DEC4", Offset = "0x1E4DEC4", VA = "0x1E4DEC4")]
    public void ButtonSetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x600BB87")]
    [Address(RVA = "0x1E4DF50", Offset = "0x1E4DF50", VA = "0x1E4DF50")]
    public void SetPassword(string password)
    {
    }

    [Token(Token = "0x600BB88")]
    [Address(RVA = "0x1E4DF8C", Offset = "0x1E4DF8C", VA = "0x1E4DF8C")]
    public void SetID(string id)
    {
    }

    [Token(Token = "0x600BB89")]
    [Address(RVA = "0x1E4E098", Offset = "0x1E4E098", VA = "0x1E4E098")]
    private void OnClickDecide()
    {
    }

    [Token(Token = "0x600BB8A")]
    [Address(RVA = "0x1E4E148", Offset = "0x1E4E148", VA = "0x1E4E148")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x600BB8B")]
    [Address(RVA = "0x1E4E1F8", Offset = "0x1E4E1F8", VA = "0x1E4E1F8")]
    public AddDevicePopup()
    {
    }
  }
}
