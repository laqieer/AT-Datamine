// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.DeepLinkEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FC5")]
  internal class DeepLinkEventListener : IDeepLinkEventListener, IDisposable
  {
    [Token(Token = "0x40087AD")]
    private const string DeepLinkKey = "fggid";
    [Token(Token = "0x40087AE")]
    [FieldOffset(Offset = "0x10")]
    private DeepLinkEventDispatcher deepLinkEventDispatcher;
    [Token(Token = "0x40087AF")]
    [FieldOffset(Offset = "0x18")]
    public DeepLinkEventListener.OnDeepLinkActivatedEvent OnDeepLinkActivatedCallback;

    [Token(Token = "0x600BC99")]
    [Address(RVA = "0x1E52E58", Offset = "0x1E52E58", VA = "0x1E52E58")]
    public DeepLinkEventListener(DeepLinkEventDispatcher deepLinkEventDispatcher)
    {
    }

    [Token(Token = "0x600BC9A")]
    [Address(RVA = "0x1E54258", Offset = "0x1E54258", VA = "0x1E54258")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BC9B")]
    [Address(RVA = "0x1E542AC", Offset = "0x1E542AC", VA = "0x1E542AC")]
    private void Release()
    {
    }

    [Token(Token = "0x600BC9C")]
    [Address(RVA = "0x1E534E0", Offset = "0x1E534E0", VA = "0x1E534E0", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600BC9D")]
    [Address(RVA = "0x1E54300", Offset = "0x1E54300", VA = "0x1E54300", Slot = "4")]
    public void OnDeepLinkActivated(DeepLinkData deepLinkData)
    {
    }

    [Token(Token = "0x600BC9E")]
    [Address(RVA = "0x1E53108", Offset = "0x1E53108", VA = "0x1E53108")]
    public void Focus()
    {
    }

    [Token(Token = "0x2001FC6")]
    public delegate void OnDeepLinkActivatedEvent(DeepLinkData deepLinkData);
  }
}
