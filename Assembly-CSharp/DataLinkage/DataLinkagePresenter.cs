// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkagePresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage.FgGID;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F7D")]
  public class DataLinkagePresenter
  {
    [Token(Token = "0x40086CA")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x40086CB")]
    [FieldOffset(Offset = "0x18")]
    private PlayerDataModel playerData;

    [Token(Token = "0x600BAF3")]
    [Address(RVA = "0x1E4A790", Offset = "0x1E4A790", VA = "0x1E4A790")]
    public void Release()
    {
    }

    [Token(Token = "0x600BAF4")]
    [Address(RVA = "0x1E4A7B0", Offset = "0x1E4A7B0", VA = "0x1E4A7B0")]
    public DataLinkagePresenter(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x600BAF5")]
    [Address(RVA = "0x1E4AA6C", Offset = "0x1E4AA6C", VA = "0x1E4AA6C")]
    public void RequestConnectList(Action onSuccess, Action onError)
    {
    }

    [Token(Token = "0x600BAF6")]
    [Address(RVA = "0x1E4AB84", Offset = "0x1E4AB84", VA = "0x1E4AB84")]
    public void AssignIDPasswordRegisterPresenter(DataLinkageIDPasswordListItem view)
    {
    }

    [Token(Token = "0x600BAF7")]
    [Address(RVA = "0x1E4AC78", Offset = "0x1E4AC78", VA = "0x1E4AC78")]
    public void AssignIDPasswordAddDevicePresenter(DataLinkageListItem view)
    {
    }

    [Token(Token = "0x600BAF8")]
    [Address(RVA = "0x1E4AD40", Offset = "0x1E4AD40", VA = "0x1E4AD40")]
    public void AssignFgGIDRegisterPresenter(DataLinkageListItem view)
    {
    }

    [Token(Token = "0x600BAF9")]
    [Address(RVA = "0x1E4AE0C", Offset = "0x1E4AE0C", VA = "0x1E4AE0C")]
    public void AssignFgGIDAddDevicePresenter(DataLinkageListItem view)
    {
    }

    [Token(Token = "0x600BAFA")]
    [Address(RVA = "0x1E4AED8", Offset = "0x1E4AED8", VA = "0x1E4AED8")]
    public void AssignFgGIDLinkStatusPresenter(
      ILinkStatusView view,
      Action<bool> onStatusButtonClicked)
    {
    }
  }
}
