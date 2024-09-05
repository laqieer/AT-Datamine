// Decompiled with JetBrains decompiler
// Type: GameCore.DesignPattern.SingletonMonoBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.DesignPattern
{
  [Token(Token = "0x20014D8")]
  public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
  {
    [Token(Token = "0x1700121C")]
    public static T Instance
    {
      [Token(Token = "0x600758E")] get => (T) null;
      [Token(Token = "0x600758F")] private set
      {
      }
    }

    [Token(Token = "0x1700121D")]
    protected virtual bool IsDontDestroy
    {
      [Token(Token = "0x6007590")] get => new bool();
    }

    [Token(Token = "0x6007591")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x6007592")]
    protected virtual void DestoryInstance()
    {
    }

    [Token(Token = "0x6007593")]
    protected virtual void Awake()
    {
    }

    [Token(Token = "0x6007594")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007595")]
    protected SingletonMonoBehaviour()
    {
    }
  }
}
