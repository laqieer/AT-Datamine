// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDeepLinkEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F90")]
  public interface IDeepLinkEventListener
  {
    [Token(Token = "0x600BB5B")]
    void OnDeepLinkActivated(DeepLinkData deepLinkData);
  }
}
