// Decompiled with JetBrains decompiler
// Type: Gacha.API.SelectGachaSetTargetResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015B3")]
  internal class SelectGachaSetTargetResult
  {
    [Token(Token = "0x170012E3")]
    public GachaDetailGroupInfo GachaDetailGroupInfo
    {
      [Token(Token = "0x6007ADA"), Address(RVA = "0x229EF48", Offset = "0x229EF48", VA = "0x229EF48")] get
      {
        return (GachaDetailGroupInfo) null;
      }
      [Token(Token = "0x6007ADB"), Address(RVA = "0x229EF50", Offset = "0x229EF50", VA = "0x229EF50")] private set
      {
      }
    }

    [Token(Token = "0x6007ADC")]
    [Address(RVA = "0x229EF58", Offset = "0x229EF58", VA = "0x229EF58")]
    public static SelectGachaSetTargetResult CreateFromServerData(
      SelectGachaRequest reequest,
      APIG0001Set_targetResponse serverData)
    {
      return (SelectGachaSetTargetResult) null;
    }

    [Token(Token = "0x6007ADD")]
    [Address(RVA = "0x229EFDC", Offset = "0x229EFDC", VA = "0x229EFDC")]
    public SelectGachaSetTargetResult()
    {
    }
  }
}
