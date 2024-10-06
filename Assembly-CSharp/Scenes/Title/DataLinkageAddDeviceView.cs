// Decompiled with JetBrains decompiler
// Type: Scenes.Title.DataLinkageAddDeviceView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028CA")]
  public class DataLinkageAddDeviceView : MonoBehaviour
  {
    [Token(Token = "0x400ADF4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("データ連携用のテンプレートオブジェクト")]
    private DataLinkageListItem templateListItem;
    [Token(Token = "0x400ADF5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("ボタン類")]
    [Space]
    private Button buttonNotes;
    [Token(Token = "0x400ADF6")]
    [FieldOffset(Offset = "0x28")]
    private DataLinkagePresenter presenter;

    [Token(Token = "0x60100C0")]
    [Address(RVA = "0x4168F08", Offset = "0x4168F08", VA = "0x4168F08")]
    public void Initaialize()
    {
    }

    [Token(Token = "0x60100C1")]
    [Address(RVA = "0x41690F8", Offset = "0x41690F8", VA = "0x41690F8")]
    public void SyncDataLinkageConnectList(Action onSuccess, Action onError)
    {
    }

    [Token(Token = "0x60100C2")]
    [Address(RVA = "0x4169114", Offset = "0x4169114", VA = "0x4169114")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60100C3")]
    [Address(RVA = "0x4169030", Offset = "0x4169030", VA = "0x4169030")]
    private DataLinkageListItem CreateDataLinkObject() => (DataLinkageListItem) null;

    [Token(Token = "0x60100C4")]
    [Address(RVA = "0x4169138", Offset = "0x4169138", VA = "0x4169138")]
    private void OnClickNoteButton()
    {
    }

    [Token(Token = "0x60100C5")]
    [Address(RVA = "0x416920C", Offset = "0x416920C", VA = "0x416920C")]
    public DataLinkageAddDeviceView()
    {
    }
  }
}
