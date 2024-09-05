// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.Limit`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004E0")]
  [Serializable]
  public class Limit<T>
  {
    [Token(Token = "0x400196F")]
    [FieldOffset(Offset = "0x0")]
    public T min;
    [Token(Token = "0x4001970")]
    [FieldOffset(Offset = "0x0")]
    public T max;

    [Token(Token = "0x6001BAA")]
    public Limit()
    {
    }
  }
}
