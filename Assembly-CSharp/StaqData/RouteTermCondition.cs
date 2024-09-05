// Decompiled with JetBrains decompiler
// Type: StaqData.RouteTermCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020AF")]
  public static class RouteTermCondition
  {
    [Token(Token = "0x600C5DB")]
    [Address(RVA = "0x1A07484", Offset = "0x1A07484", VA = "0x1A07484")]
    public static bool Validation(int routeID, (int begin, int end) term) => new bool();

    [Token(Token = "0x600C5DC")]
    [Address(RVA = "0x1A07F38", Offset = "0x1A07F38", VA = "0x1A07F38")]
    public static bool ValidationRoute(int conditionRouteID) => new bool();

    [Token(Token = "0x600C5DD")]
    [Address(RVA = "0x1A082AC", Offset = "0x1A082AC", VA = "0x1A082AC")]
    public static bool ValidationTerm((int begin, int end) term) => new bool();
  }
}
