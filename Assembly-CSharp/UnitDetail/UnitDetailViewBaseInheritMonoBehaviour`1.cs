// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailViewBaseInheritMonoBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A4")]
  public class UnitDetailViewBaseInheritMonoBehaviour<T> : MonoBehaviour
  {
    [Token(Token = "0x17000328")]
    public T Data
    {
      [Token(Token = "0x6001A07")] get => (T) null;
      [Token(Token = "0x6001A08")] private set
      {
      }
    }

    [Token(Token = "0x6001A09")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001A0A")]
    protected virtual void InitializeImpl()
    {
    }

    [Token(Token = "0x6001A0B")]
    public void UpdateView(T data)
    {
    }

    [Token(Token = "0x6001A0C")]
    protected virtual void UpdateViewImpl()
    {
    }

    [Token(Token = "0x6001A0D")]
    public UnitDetailViewBaseInheritMonoBehaviour()
    {
    }
  }
}
