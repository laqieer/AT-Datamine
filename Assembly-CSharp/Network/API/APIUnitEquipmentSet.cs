// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitEquipmentSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EBD")]
  public class APIUnitEquipmentSet
  {
    [Token(Token = "0x4008408")]
    public const string DefaultAPIPath = "api/v1/unit/equipment_set";
    [Token(Token = "0x400840C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400840D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitEquipmentSetResponse> onSuccess;
    [Token(Token = "0x400840E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025AB")]
    public APIUnitEquipmentSetRequest Request
    {
      [Token(Token = "0x600B685"), Address(RVA = "0x22ECDB4", Offset = "0x22ECDB4", VA = "0x22ECDB4")] private get
      {
        return (APIUnitEquipmentSetRequest) null;
      }
      [Token(Token = "0x600B686"), Address(RVA = "0x22ECDBC", Offset = "0x22ECDBC", VA = "0x22ECDBC")] set
      {
      }
    }

    [Token(Token = "0x170025AC")]
    public APIUnitEquipmentSetResponse Response
    {
      [Token(Token = "0x600B687"), Address(RVA = "0x22ECDC4", Offset = "0x22ECDC4", VA = "0x22ECDC4")] get
      {
        return (APIUnitEquipmentSetResponse) null;
      }
      [Token(Token = "0x600B688"), Address(RVA = "0x22ECDCC", Offset = "0x22ECDCC", VA = "0x22ECDCC")] private set
      {
      }
    }

    [Token(Token = "0x170025AD")]
    public int ResponseCode
    {
      [Token(Token = "0x600B689"), Address(RVA = "0x22ECDD4", Offset = "0x22ECDD4", VA = "0x22ECDD4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B68A"), Address(RVA = "0x22ECDDC", Offset = "0x22ECDDC", VA = "0x22ECDDC")] private set
      {
      }
    }

    [Token(Token = "0x170025AE")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B68B"), Address(RVA = "0x22ECDE4", Offset = "0x22ECDE4", VA = "0x22ECDE4")] set
      {
      }
      [Token(Token = "0x600B68C"), Address(RVA = "0x22ECE00", Offset = "0x22ECE00", VA = "0x22ECE00")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B68D")]
    [Address(RVA = "0x22ECE1C", Offset = "0x22ECE1C", VA = "0x22ECE1C")]
    public APIUnitEquipmentSet(string apiPath = "api/v1/unit/equipment_set")
    {
    }

    [Token(Token = "0x600B68E")]
    [Address(RVA = "0x22ECEB4", Offset = "0x22ECEB4", VA = "0x22ECEB4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B68F")]
    [Address(RVA = "0x22ECF44", Offset = "0x22ECF44", VA = "0x22ECF44")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B690")]
    [Address(RVA = "0x22ECF50", Offset = "0x22ECF50", VA = "0x22ECF50")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B691")]
    [Address(RVA = "0x22ED024", Offset = "0x22ED024", VA = "0x22ED024")]
    private void OnSuccess(string json)
    {
    }
  }
}
