// Decompiled with JetBrains decompiler
// Type: GameCore.AppLifeCycleObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BBA")]
  public class AppLifeCycleObserver : SingletonMonoBehaviour<AppLifeCycleObserver>
  {
    [Token(Token = "0x4003575")]
    [FieldOffset(Offset = "0x20")]
    private List<IAppLifeCycleListener> listernerList;

    [Token(Token = "0x60042F4")]
    [Address(RVA = "0x363D618", Offset = "0x363D618", VA = "0x363D618")]
    private void OnApplicationPause(bool pause)
    {
    }

    [Token(Token = "0x60042F5")]
    [Address(RVA = "0x363D76C", Offset = "0x363D76C", VA = "0x363D76C")]
    public void AddListerner(IAppLifeCycleListener listerner)
    {
    }

    [Token(Token = "0x60042F6")]
    [Address(RVA = "0x363D900", Offset = "0x363D900", VA = "0x363D900")]
    public void RemoveListerner(IAppLifeCycleListener listerner)
    {
    }

    [Token(Token = "0x60042F7")]
    [Address(RVA = "0x363D84C", Offset = "0x363D84C", VA = "0x363D84C")]
    private void ClearUnnecessaryReferences()
    {
    }

    [Token(Token = "0x60042F8")]
    [Address(RVA = "0x363D970", Offset = "0x363D970", VA = "0x363D970")]
    public AppLifeCycleObserver()
    {
    }
  }
}
