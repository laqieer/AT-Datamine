// Decompiled with JetBrains decompiler
// Type: Network.NetworkErrorResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019FF")]
  public class NetworkErrorResult
  {
    [Token(Token = "0x4006F4E")]
    [FieldOffset(Offset = "0x10")]
    public ConnectParam ConnectParam;
    [Token(Token = "0x4006F4F")]
    [FieldOffset(Offset = "0x50")]
    public ResponseParam RespounseParam;
    [Token(Token = "0x4006F50")]
    [FieldOffset(Offset = "0x68")]
    public INetworkErrorData ErrorMasterData;
    [Token(Token = "0x4006F51")]
    [FieldOffset(Offset = "0x70")]
    private bool isHandled;

    [Token(Token = "0x6009462")]
    [Address(RVA = "0x4D15E54", Offset = "0x4D15E54", VA = "0x4D15E54")]
    public NetworkErrorResult(
      ConnectParam connectParam,
      ResponseParam respounseParam,
      INetworkErrorData errorMasterData)
    {
    }

    [Token(Token = "0x6009463")]
    [Address(RVA = "0x4D14898", Offset = "0x4D14898", VA = "0x4D14898")]
    public void SetHandled()
    {
    }

    [Token(Token = "0x6009464")]
    [Address(RVA = "0x4D15EA8", Offset = "0x4D15EA8", VA = "0x4D15EA8")]
    public bool IsHandled() => new bool();
  }
}
