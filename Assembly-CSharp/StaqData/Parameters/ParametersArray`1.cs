// Decompiled with JetBrains decompiler
// Type: StaqData.Parameters.ParametersArray`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.Parameters
{
  [Token(Token = "0x20021AE")]
  public class ParametersArray<TElement> where TElement : Element
  {
    [Token(Token = "0x17002CE7")]
    public TElement[] Parameters
    {
      [Token(Token = "0x600CDD4")] get => (TElement[]) null;
    }

    [Token(Token = "0x600CDD5")]
    public ParametersArray(int size)
    {
    }

    [Token(Token = "0x600CDD6")]
    public TElement Get(int index) => (TElement) null;

    [Token(Token = "0x600CDD7")]
    public void Init(int index, TElement initData)
    {
    }

    [Token(Token = "0x600CDD8")]
    public void Set(int index, int value)
    {
    }

    [Token(Token = "0x600CDD9")]
    public void Set(int index, float value)
    {
    }

    [Token(Token = "0x600CDDA")]
    private bool ValidIndex(int index) => new bool();
  }
}
