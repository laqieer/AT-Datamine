// Decompiled with JetBrains decompiler
// Type: Network.Param.IPostApiResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A73")]
  public interface IPostApiResult : ICommonApiResult
  {
    [Token(Token = "0x170019B6")]
    UpdatedPlayerDataSet UpdatedPlayerDataSet { [Token(Token = "0x6009871")] get; }

    [Token(Token = "0x170019B7")]
    PlayerCoinType PlayerCoin { [Token(Token = "0x6009872")] get; }
  }
}
