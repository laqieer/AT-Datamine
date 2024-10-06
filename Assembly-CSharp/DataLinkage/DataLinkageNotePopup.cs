// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageNotePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F77")]
  public class DataLinkageNotePopup
  {
    [Token(Token = "0x40086B6")]
    private const string ResourcesPath = "UI/Common/Prefab/Com_Popup_Base_M_Text_Notes_Btn_002";
    [Token(Token = "0x40086B7")]
    [FieldOffset(Offset = "0x10")]
    private CommonPopup asset;
    [Token(Token = "0x40086B8")]
    [FieldOffset(Offset = "0x18")]
    private PopupBase instance;
    [Token(Token = "0x40086B9")]
    [FieldOffset(Offset = "0x20")]
    private IDataLinkageNotePopupPresenter presenter;

    [Token(Token = "0x170026BC")]
    public IDataLinkageNotePopupPresenter Presenter
    {
      [Token(Token = "0x600BAD2"), Address(RVA = "0x1E4981C", Offset = "0x1E4981C", VA = "0x1E4981C")] set
      {
      }
    }

    [Token(Token = "0x600BAD3")]
    [Address(RVA = "0x1E498C0", Offset = "0x1E498C0", VA = "0x1E498C0")]
    public static void Create(Action<DataLinkageNotePopup> onCreate)
    {
    }

    [Token(Token = "0x600BAD4")]
    private static IEnumerator LoadResourceAsync<T>(string path, Action<T> onComplete) where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BAD5")]
    [Address(RVA = "0x1E49A04", Offset = "0x1E49A04", VA = "0x1E49A04")]
    private DataLinkageNotePopup(CommonPopup asset)
    {
    }

    [Token(Token = "0x600BAD6")]
    [Address(RVA = "0x1E49A2C", Offset = "0x1E49A2C", VA = "0x1E49A2C")]
    public void OpenConfirmationOfConsent()
    {
    }

    [Token(Token = "0x600BAD7")]
    [Address(RVA = "0x1E49E9C", Offset = "0x1E49E9C", VA = "0x1E49E9C")]
    public void OpenCloseOnly()
    {
    }

    [Token(Token = "0x600BAD8")]
    [Address(RVA = "0x1E496FC", Offset = "0x1E496FC", VA = "0x1E496FC")]
    public void Close()
    {
    }
  }
}
