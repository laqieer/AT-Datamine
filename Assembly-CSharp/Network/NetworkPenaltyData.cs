// Decompiled with JetBrains decompiler
// Type: Network.NetworkPenaltyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A1F")]
  public class NetworkPenaltyData
  {
    [Token(Token = "0x4006FE0")]
    [FieldOffset(Offset = "0x10")]
    public int ID;
    [Token(Token = "0x4006FE1")]
    [FieldOffset(Offset = "0x18")]
    public string formatText;
    [Token(Token = "0x4006FE2")]
    [FieldOffset(Offset = "0x20")]
    public string detailText;
    [Token(Token = "0x4006FE3")]
    [FieldOffset(Offset = "0x28")]
    public bool showEndAt;

    [Token(Token = "0x6009532")]
    [Address(RVA = "0x48ECD38", Offset = "0x48ECD38", VA = "0x48ECD38")]
    public NetworkPenaltyData()
    {
    }
  }
}
