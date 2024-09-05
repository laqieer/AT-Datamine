// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapAutoMoveRouteHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F3")]
  public class FreeMapAutoMoveRouteHandler
  {
    [Token(Token = "0x400641C")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapLocationHolder locationHolderRef;
    [Token(Token = "0x400641D")]
    [FieldOffset(Offset = "0x18")]
    private Stack<FreeMapUIParamBase> taskParamStack;

    [Token(Token = "0x6007C34")]
    [Address(RVA = "0x219F8F0", Offset = "0x219F8F0", VA = "0x219F8F0")]
    public FreeMapAutoMoveRouteHandler(FreeMapLocationHolder locationHolder)
    {
    }

    [Token(Token = "0x6007C35")]
    [Address(RVA = "0x219F980", Offset = "0x219F980", VA = "0x219F980")]
    public void CalcRouteUIParamList(int fromAreaID, int toAreaID, FreeMapUIParamBase uiParam)
    {
    }

    [Token(Token = "0x6007C36")]
    [Address(RVA = "0x219FB40", Offset = "0x219FB40", VA = "0x219FB40")]
    public FreeMapUIParamBase GetNextUIParam() => (FreeMapUIParamBase) null;

    [Token(Token = "0x6007C37")]
    [Address(RVA = "0x219FBB4", Offset = "0x219FBB4", VA = "0x219FBB4")]
    public void Clear()
    {
    }
  }
}
