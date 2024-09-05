// Decompiled with JetBrains decompiler
// Type: GameCore.AssetLoadBalancer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BCA")]
  public class AssetLoadBalancer
  {
    [Token(Token = "0x40035BB")]
    [FieldOffset(Offset = "0x10")]
    private float realtimeSecond;
    [Token(Token = "0x40035BC")]
    [FieldOffset(Offset = "0x14")]
    private int beforeRealtimeUpdateFrame;
    [Token(Token = "0x40035BD")]
    [FieldOffset(Offset = "0x18")]
    private bool isWait;
    [Token(Token = "0x40035BE")]
    private const float waitRealtimeBalanceScond = 0.2f;

    [Token(Token = "0x600435A")]
    [Address(RVA = "0x363F708", Offset = "0x363F708", VA = "0x363F708")]
    public bool IsShouldWait() => new bool();

    [Token(Token = "0x600435B")]
    [Address(RVA = "0x363F908", Offset = "0x363F908", VA = "0x363F908")]
    public AssetLoadBalancer()
    {
    }
  }
}
