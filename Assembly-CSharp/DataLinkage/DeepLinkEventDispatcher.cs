// Decompiled with JetBrains decompiler
// Type: DataLinkage.DeepLinkEventDispatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F8D")]
  public class DeepLinkEventDispatcher : IDisposable
  {
    [Token(Token = "0x40086ED")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, List<IDeepLinkEventListener>> deepLinkEventListeners;
    [Token(Token = "0x40086EE")]
    [FieldOffset(Offset = "0x18")]
    private FakeDeepLinkEvent fakeDeepLinkEvent;
    [Token(Token = "0x40086EF")]
    [FieldOffset(Offset = "0x20")]
    private AddDeepLinkActivatedHandler addDeepLinkActivatedHandler;
    [Token(Token = "0x40086F0")]
    [FieldOffset(Offset = "0x28")]
    private SubDeepLinkActivatedHandler subDeepLinkActivatedHandler;
    [Token(Token = "0x40086F1")]
    [FieldOffset(Offset = "0x30")]
    private bool dontDestoryObjectOnLoad;

    [Token(Token = "0x600BB4D")]
    [Address(RVA = "0x1E488DC", Offset = "0x1E488DC", VA = "0x1E488DC")]
    public DeepLinkEventDispatcher(
      AddDeepLinkActivatedHandler addDeepLinkActivatedHandler,
      SubDeepLinkActivatedHandler subDeepLinkActivatedHandler,
      bool dontDestoryObjectOnLoad = false)
    {
    }

    [Token(Token = "0x600BB4E")]
    [Address(RVA = "0x1E4C4E8", Offset = "0x1E4C4E8", VA = "0x1E4C4E8")]
    private void Initialize(
      AddDeepLinkActivatedHandler addDeepLinkActivatedHandler,
      SubDeepLinkActivatedHandler subDeepLinkActivatedHandler,
      bool dontDestoryObjectOnLoad)
    {
    }

    [Token(Token = "0x600BB4F")]
    [Address(RVA = "0x1E4C5A0", Offset = "0x1E4C5A0", VA = "0x1E4C5A0")]
    private void Release()
    {
    }

    [Token(Token = "0x600BB50")]
    [Address(RVA = "0x1E4C63C", Offset = "0x1E4C63C", VA = "0x1E4C63C")]
    public void Register(string keyword, IDeepLinkEventListener deepLinkEventListener)
    {
    }

    [Token(Token = "0x600BB51")]
    [Address(RVA = "0x1E4C790", Offset = "0x1E4C790", VA = "0x1E4C790")]
    public void UnRegister(string keyword, IDeepLinkEventListener deepLinkEventListener)
    {
    }

    [Token(Token = "0x600BB52")]
    [Address(RVA = "0x1E4C82C", Offset = "0x1E4C82C", VA = "0x1E4C82C")]
    private void OnDeepLinkActivated(string url)
    {
    }

    [Token(Token = "0x600BB53")]
    [Address(RVA = "0x1E4CA60", Offset = "0x1E4CA60", VA = "0x1E4CA60", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
