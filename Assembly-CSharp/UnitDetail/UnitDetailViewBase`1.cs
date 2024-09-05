// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailViewBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A3")]
  public class UnitDetailViewBase<T>
  {
    [Token(Token = "0x17000327")]
    public T Data
    {
      [Token(Token = "0x6001A00")] get => (T) null;
      [Token(Token = "0x6001A01")] private set
      {
      }
    }

    [Token(Token = "0x6001A02")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001A03")]
    protected virtual void InitializeImpl()
    {
    }

    [Token(Token = "0x6001A04")]
    public void UpdateView(T data)
    {
    }

    [Token(Token = "0x6001A05")]
    protected virtual void UpdateViewImpl()
    {
    }

    [Token(Token = "0x6001A06")]
    public UnitDetailViewBase()
    {
    }
  }
}
