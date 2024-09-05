// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildCheck_maintenance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CB9")]
  public class APIGuildCheck_maintenance
  {
    [Token(Token = "0x4007ACD")]
    public const string DefaultAPIPath = "api/v1/guild/check_maintenance";
    [Token(Token = "0x4007AD1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AD2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildCheck_maintenanceResponse> onSuccess;
    [Token(Token = "0x4007AD3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700206B")]
    public APIGuildCheck_maintenanceRequest Request
    {
      [Token(Token = "0x600A935"), Address(RVA = "0x19147DC", Offset = "0x19147DC", VA = "0x19147DC")] private get
      {
        return (APIGuildCheck_maintenanceRequest) null;
      }
      [Token(Token = "0x600A936"), Address(RVA = "0x19147E4", Offset = "0x19147E4", VA = "0x19147E4")] set
      {
      }
    }

    [Token(Token = "0x1700206C")]
    public APIGuildCheck_maintenanceResponse Response
    {
      [Token(Token = "0x600A937"), Address(RVA = "0x19147EC", Offset = "0x19147EC", VA = "0x19147EC")] get
      {
        return (APIGuildCheck_maintenanceResponse) null;
      }
      [Token(Token = "0x600A938"), Address(RVA = "0x19147F4", Offset = "0x19147F4", VA = "0x19147F4")] private set
      {
      }
    }

    [Token(Token = "0x1700206D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A939"), Address(RVA = "0x19147FC", Offset = "0x19147FC", VA = "0x19147FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A93A"), Address(RVA = "0x1914804", Offset = "0x1914804", VA = "0x1914804")] private set
      {
      }
    }

    [Token(Token = "0x1700206E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A93B"), Address(RVA = "0x191480C", Offset = "0x191480C", VA = "0x191480C")] set
      {
      }
      [Token(Token = "0x600A93C"), Address(RVA = "0x1914828", Offset = "0x1914828", VA = "0x1914828")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A93D")]
    [Address(RVA = "0x1914844", Offset = "0x1914844", VA = "0x1914844")]
    public APIGuildCheck_maintenance(string apiPath = "api/v1/guild/check_maintenance")
    {
    }

    [Token(Token = "0x600A93E")]
    [Address(RVA = "0x19148DC", Offset = "0x19148DC", VA = "0x19148DC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A93F")]
    [Address(RVA = "0x191496C", Offset = "0x191496C", VA = "0x191496C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A940")]
    [Address(RVA = "0x1914978", Offset = "0x1914978", VA = "0x1914978")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A941")]
    [Address(RVA = "0x1914A4C", Offset = "0x1914A4C", VA = "0x1914A4C")]
    private void OnSuccess(string json)
    {
    }
  }
}
