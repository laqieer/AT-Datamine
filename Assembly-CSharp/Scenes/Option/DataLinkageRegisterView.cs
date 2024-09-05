// Decompiled with JetBrains decompiler
// Type: Scenes.Option.DataLinkageRegisterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Option
{
  [Token(Token = "0x2002A6B")]
  public class DataLinkageRegisterView : MonoBehaviour
  {
    [Token(Token = "0x400B492")]
    [FieldOffset(Offset = "0x18")]
    [Header("データ連携用のテンプレートオブジェクト")]
    [SerializeField]
    private DataLinkageListItem templateContentDataLink;
    [Token(Token = "0x400B493")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("ID-Password 連携")]
    private DataLinkageIDPasswordListItem contentIDPWDataLink;
    [Token(Token = "0x400B494")]
    [FieldOffset(Offset = "0x28")]
    [Space]
    [Header("ボタン類")]
    [SerializeField]
    private Button buttonNotes;
    [Token(Token = "0x400B496")]
    [FieldOffset(Offset = "0x38")]
    private DataLinkagePresenter presenter;

    [Token(Token = "0x1700399E")]
    public bool IsIniitalized
    {
      [Token(Token = "0x60109BC"), Address(RVA = "0x4C32DFC", Offset = "0x4C32DFC", VA = "0x4C32DFC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60109BD"), Address(RVA = "0x4C32E04", Offset = "0x4C32E04", VA = "0x4C32E04")] private set
      {
      }
    }

    [Token(Token = "0x60109BE")]
    [Address(RVA = "0x4C32E10", Offset = "0x4C32E10", VA = "0x4C32E10")]
    public void Initaialize()
    {
    }

    [Token(Token = "0x60109BF")]
    [Address(RVA = "0x4C3300C", Offset = "0x4C3300C", VA = "0x4C3300C")]
    public void SyncDataLinkageConnectList()
    {
    }

    [Token(Token = "0x60109C0")]
    [Address(RVA = "0x4C3302C", Offset = "0x4C3302C", VA = "0x4C3302C")]
    public IEnumerator SyncDataLinkageConnectListAsync() => (IEnumerator) null;

    [Token(Token = "0x60109C1")]
    [Address(RVA = "0x4C330BC", Offset = "0x4C330BC", VA = "0x4C330BC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60109C2")]
    [Address(RVA = "0x4C32F44", Offset = "0x4C32F44", VA = "0x4C32F44")]
    private DataLinkageListItem CreateDataLinkObject() => (DataLinkageListItem) null;

    [Token(Token = "0x60109C3")]
    [Address(RVA = "0x4C330E0", Offset = "0x4C330E0", VA = "0x4C330E0")]
    private void OnClickNoteButton()
    {
    }

    [Token(Token = "0x60109C4")]
    [Address(RVA = "0x4C331B4", Offset = "0x4C331B4", VA = "0x4C331B4")]
    public DataLinkageRegisterView()
    {
    }
  }
}
