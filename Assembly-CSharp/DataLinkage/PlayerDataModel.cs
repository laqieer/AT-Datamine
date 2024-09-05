// Decompiled with JetBrains decompiler
// Type: DataLinkage.PlayerDataModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F92")]
  public class PlayerDataModel
  {
    [Token(Token = "0x170026CF")]
    public string DeviceID
    {
      [Token(Token = "0x600BB62"), Address(RVA = "0x1E4CE6C", Offset = "0x1E4CE6C", VA = "0x1E4CE6C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BB63"), Address(RVA = "0x1E4CE74", Offset = "0x1E4CE74", VA = "0x1E4CE74")] private set
      {
      }
    }

    [Token(Token = "0x170026D0")]
    public string SecretKey
    {
      [Token(Token = "0x600BB64"), Address(RVA = "0x1E4CE7C", Offset = "0x1E4CE7C", VA = "0x1E4CE7C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BB65"), Address(RVA = "0x1E4CE84", Offset = "0x1E4CE84", VA = "0x1E4CE84")] private set
      {
      }
    }

    [Token(Token = "0x170026D1")]
    public string PlayerID
    {
      [Token(Token = "0x600BB66"), Address(RVA = "0x1E4CE8C", Offset = "0x1E4CE8C", VA = "0x1E4CE8C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BB67"), Address(RVA = "0x1E4CE94", Offset = "0x1E4CE94", VA = "0x1E4CE94")] private set
      {
      }
    }

    [Token(Token = "0x170026D2")]
    public uint? ShortPlayerID
    {
      [Token(Token = "0x600BB68"), Address(RVA = "0x1E4CE9C", Offset = "0x1E4CE9C", VA = "0x1E4CE9C")] get
      {
        return new uint?();
      }
      [Token(Token = "0x600BB69"), Address(RVA = "0x1E4CEA4", Offset = "0x1E4CEA4", VA = "0x1E4CEA4")] private set
      {
      }
    }

    [Token(Token = "0x170026D3")]
    public bool IsNotCreated
    {
      [Token(Token = "0x600BB6A"), Address(RVA = "0x1E4809C", Offset = "0x1E4809C", VA = "0x1E4809C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BB6B")]
    [Address(RVA = "0x1E4A88C", Offset = "0x1E4A88C", VA = "0x1E4A88C")]
    public PlayerDataModel()
    {
    }

    [Token(Token = "0x600BB6C")]
    [Address(RVA = "0x1E4CEAC", Offset = "0x1E4CEAC", VA = "0x1E4CEAC")]
    public void ApplyInheritedPlayerData(string deviceID, string playerID, Action onComplete)
    {
    }
  }
}
