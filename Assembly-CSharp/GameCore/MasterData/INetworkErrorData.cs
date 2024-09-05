// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.INetworkErrorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013EE")]
  public interface INetworkErrorData
  {
    [Token(Token = "0x170010E1")]
    string ErrorCode { [Token(Token = "0x6006FDE")] get; }

    [Token(Token = "0x170010E2")]
    long HttpStatusCode { [Token(Token = "0x6006FDF")] get; }

    [Token(Token = "0x170010E3")]
    string Button1String { [Token(Token = "0x6006FE0")] get; }

    [Token(Token = "0x170010E4")]
    string Button2String { [Token(Token = "0x6006FE1")] get; }

    [Token(Token = "0x170010E5")]
    string DialogString { [Token(Token = "0x6006FE2")] get; }

    [Token(Token = "0x170010E6")]
    ErrorViewTypeEnum ViewType { [Token(Token = "0x6006FE3")] get; }

    [Token(Token = "0x170010E7")]
    ErrorTransitionTypeEnum Button1TransitionType { [Token(Token = "0x6006FE4")] get; }

    [Token(Token = "0x170010E8")]
    ErrorTransitionTypeEnum Button2TransitionType { [Token(Token = "0x6006FE5")] get; }

    [Token(Token = "0x6006FE6")]
    string GetDialogString(long httpStatusCode);
  }
}
