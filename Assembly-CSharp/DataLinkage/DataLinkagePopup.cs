// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkagePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F7A")]
  public class DataLinkagePopup : PopupBase
  {
    [Token(Token = "0x40086C0")]
    private const string ResourcesPath = "UI/Common/Prefab/Container_DataLink";
    [Token(Token = "0x40086C1")]
    [FieldOffset(Offset = "0x88")]
    [Header("ボタン")]
    [SerializeField]
    private Button buttonClose;
    [Token(Token = "0x40086C2")]
    [FieldOffset(Offset = "0x90")]
    public Action onClickClose;

    [Token(Token = "0x600BAE6")]
    [Address(RVA = "0x1E4A4DC", Offset = "0x1E4A4DC", VA = "0x1E4A4DC")]
    public static void Create(Transform parent, Action<DataLinkagePopup> onCreate)
    {
    }

    [Token(Token = "0x600BAE7")]
    private static IEnumerator LoadResourceAsync<T>(string path, Action<T> onComplete) where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BAE8")]
    [Address(RVA = "0x1E4A624", Offset = "0x1E4A624", VA = "0x1E4A624")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BAE9")]
    [Address(RVA = "0x1E4A6B8", Offset = "0x1E4A6B8", VA = "0x1E4A6B8")]
    public DataLinkagePopup()
    {
    }
  }
}
