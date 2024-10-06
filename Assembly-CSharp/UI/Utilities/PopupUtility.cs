// Decompiled with JetBrains decompiler
// Type: UI.Utilities.PopupUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities
{
  [Token(Token = "0x200088A")]
  public class PopupUtility
  {
    [Token(Token = "0x400283E")]
    public const string CommonUIAssetBundleName = "2dassets_ui_common";
    [Token(Token = "0x400283F")]
    public const string CommonConfirmPopupAssetName = "Com_Popup_ComConfirmation";
    [Token(Token = "0x4002840")]
    public const string AnimationKeyIn = "Popup_In";
    [Token(Token = "0x4002841")]
    public const string AnimationKeyOut = "Popup_Out";

    [Token(Token = "0x60030C4")]
    public static void OpenAnyPopup<T>(
      string assetBundleName,
      string assetName,
      Action onClickOutRange,
      Action<T> onCreatePopup = null,
      string animationKeyIn = "Popup_In")
      where T : PopupBase
    {
    }

    [Token(Token = "0x60030C5")]
    [Address(RVA = "0x3C0FF90", Offset = "0x3C0FF90", VA = "0x3C0FF90")]
    public static void OpenCommonConfirmPopup(
      string title,
      string message,
      Action onClickDecision,
      Action onClickExecute,
      Action onClickCancel,
      Action onClickOutRange)
    {
    }

    [Token(Token = "0x60030C6")]
    [Address(RVA = "0x3C1007C", Offset = "0x3C1007C", VA = "0x3C1007C")]
    public static void OpenCommonConfirmPopupDecisionCancel(
      string title,
      string message,
      Action onClickDecision,
      Action onClickCancel)
    {
    }

    [Token(Token = "0x60030C7")]
    [Address(RVA = "0x3C10158", Offset = "0x3C10158", VA = "0x3C10158")]
    public static void OpenCommonConfirmPopupExecuteCancel(
      string title,
      string message,
      Action onClickExecute,
      Action onClickCancel)
    {
    }

    [Token(Token = "0x60030C8")]
    [Address(RVA = "0x3C10234", Offset = "0x3C10234", VA = "0x3C10234")]
    public static void OpenCommonConfirmPopupExecute(
      string title,
      string message,
      Action onClickExecute)
    {
    }

    [Token(Token = "0x60030C9")]
    [Address(RVA = "0x3C1030C", Offset = "0x3C1030C", VA = "0x3C1030C")]
    public static void OpenCommonConfirmPopupDecision(
      string title,
      string message,
      Action onClickDecision)
    {
    }

    [Token(Token = "0x60030CA")]
    public static void OpenConfirmPopup<T>(
      string assetBundleName,
      string assetName,
      string title,
      string message,
      Action onClickDecision,
      Action onClickExecute,
      Action onClickCancel,
      Action onClickOutRange,
      Action<T> onCreatePopup = null,
      string animationKeyIn = "Popup_In")
      where T : ConfirmationPopup
    {
    }

    [Token(Token = "0x60030CB")]
    public static T CreatePopup<T>(string assetBundleName, string assetName) where T : Component
    {
      return (T) null;
    }

    [Token(Token = "0x60030CC")]
    private static bool GetAsset<T>(
      string assetBundleName,
      string assetName,
      ref T asset,
      ref string errorMessage)
      where T : Component
    {
      return new bool();
    }

    [Token(Token = "0x60030CD")]
    [Address(RVA = "0x3C103E4", Offset = "0x3C103E4", VA = "0x3C103E4")]
    public PopupUtility()
    {
    }
  }
}
