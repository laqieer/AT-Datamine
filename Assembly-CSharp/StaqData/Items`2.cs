// Decompiled with JetBrains decompiler
// Type: StaqData.Items`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002039")]
  public abstract class Items<TServerData, TClientData> : IEnumerable<TClientData>, IEnumerable
  {
    [Token(Token = "0x17002873")]
    protected System.Collections.Generic.List<TClientData> List
    {
      [Token(Token = "0x600C11F")] get => (System.Collections.Generic.List<TClientData>) null;
      [Token(Token = "0x600C120")] private set
      {
      }
    }

    [Token(Token = "0x600C121")]
    public abstract void Apply(TServerData data);

    [Token(Token = "0x600C122")]
    private IEnumerator<TClientData> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTClientData\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<TClientData>) null;
    }

    [Token(Token = "0x600C123")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C124")]
    protected Items()
    {
    }
  }
}
