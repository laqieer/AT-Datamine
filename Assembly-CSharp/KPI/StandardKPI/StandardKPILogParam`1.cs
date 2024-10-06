// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPILogParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A70")]
  [Serializable]
  public abstract class StandardKPILogParam<T> : StandardKPILogParamBase where T : IStandardKPILogBodyParam
  {
    [Token(Token = "0x4003061")]
    [FieldOffset(Offset = "0x0")]
    public T body;

    [Token(Token = "0x6003B45")]
    public StandardKPILogParam()
    {
    }
  }
}
