// Decompiled with JetBrains decompiler
// Type: Battle.Data.IExtendableRangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200270E")]
  public interface IExtendableRangeData : IBasicRangeData
  {
    [Token(Token = "0x600F252")]
    void ChangeOffset(int minRangeOffset, int maxRangeOffset);
  }
}
