// Decompiled with JetBrains decompiler
// Type: Model.IK.IKImplManager`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Model.IK
{
  [Token(Token = "0x2003F1E")]
  public class IKImplManager<TImpl> where TImpl : IIKImplementor
  {
    [Token(Token = "0x40114BF")]
    [FieldOffset(Offset = "0x0")]
    protected List<IKImplManager<TImpl>.ImplContainer> containers;

    [Token(Token = "0x60197FB")]
    public void Add(TImpl impl, bool isLock = false)
    {
    }

    [Token(Token = "0x60197FC")]
    public bool TryGetImpl(out TImpl impl) => new bool();

    [Token(Token = "0x60197FD")]
    public void Remove(TImpl impl)
    {
    }

    [Token(Token = "0x60197FE")]
    public void RemoveAll()
    {
    }

    [Token(Token = "0x60197FF")]
    public IKImplManager()
    {
    }

    [Token(Token = "0x2003F1F")]
    protected struct ImplContainer
    {
      [Token(Token = "0x40114C0")]
      [FieldOffset(Offset = "0x0")]
      public TImpl impl;
      [Token(Token = "0x40114C1")]
      [FieldOffset(Offset = "0x0")]
      public bool locked;

      [Token(Token = "0x6019800")]
      public bool IsValid() => new bool();
    }
  }
}
