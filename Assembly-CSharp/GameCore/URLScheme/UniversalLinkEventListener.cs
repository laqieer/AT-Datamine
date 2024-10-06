// Decompiled with JetBrains decompiler
// Type: GameCore.URLScheme.UniversalLinkEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage;
using Il2CppDummyDll;

#nullable disable
namespace GameCore.URLScheme
{
  [Token(Token = "0x2000BD4")]
  public class UniversalLinkEventListener : IDeepLinkEventListener
  {
    [Token(Token = "0x40035D5")]
    [FieldOffset(Offset = "0x10")]
    public UniversalLinkEventListener.OnDeepLinkActivatedEvent OnDeepLinkActivatedCallback;
    [Token(Token = "0x40035D6")]
    [FieldOffset(Offset = "0x18")]
    private DeepLinkEventDispatcher DeepLinkEventDispatcher;

    [Token(Token = "0x60043A7")]
    [Address(RVA = "0x3642938", Offset = "0x3642938", VA = "0x3642938")]
    public UniversalLinkEventListener()
    {
    }

    [Token(Token = "0x60043A8")]
    [Address(RVA = "0x3642B94", Offset = "0x3642B94", VA = "0x3642B94")]
    public void Release()
    {
    }

    [Token(Token = "0x60043A9")]
    [Address(RVA = "0x3642BB0", Offset = "0x3642BB0", VA = "0x3642BB0", Slot = "4")]
    public void OnDeepLinkActivated(DeepLinkData deepLinkData)
    {
    }

    [Token(Token = "0x60043AA")]
    [Address(RVA = "0x36429F4", Offset = "0x36429F4", VA = "0x36429F4")]
    private static AddDeepLinkActivatedHandler GetAddDeepLinkActivatedHandler()
    {
      return (AddDeepLinkActivatedHandler) null;
    }

    [Token(Token = "0x60043AB")]
    [Address(RVA = "0x3642AC4", Offset = "0x3642AC4", VA = "0x3642AC4")]
    private static SubDeepLinkActivatedHandler GetSubDeepLinkActivatedHandler()
    {
      return (SubDeepLinkActivatedHandler) null;
    }

    [Token(Token = "0x2000BD5")]
    public delegate void OnDeepLinkActivatedEvent(DeepLinkData deepLinkData);
  }
}
