// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.NetworkErrorMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E96")]
  [Serializable]
  public sealed class NetworkErrorMaster : BaseMaster<NetworkErrorData>
  {
    [Token(Token = "0x400468E")]
    public const string TEXT_AB = "text_system";
    [Token(Token = "0x400468F")]
    public const string TEXT_RESOURCES = "resources";
    [Token(Token = "0x4004690")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, List<NetworkErrorData>> networkErrorDataDic;

    [Token(Token = "0x60058B5")]
    [Address(RVA = "0x3C2D040", Offset = "0x3C2D040", VA = "0x3C2D040")]
    public IReadOnlyDictionary<int, NetworkErrorData> GetEntities()
    {
      return (IReadOnlyDictionary<int, NetworkErrorData>) null;
    }

    [Token(Token = "0x60058B6")]
    [Address(RVA = "0x3C2D048", Offset = "0x3C2D048", VA = "0x3C2D048", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058B7")]
    [Address(RVA = "0x3C2D100", Offset = "0x3C2D100", VA = "0x3C2D100", Slot = "5")]
    protected override NetworkErrorData LoadEntity(IMasterDataReader reader)
    {
      return (NetworkErrorData) null;
    }

    [Token(Token = "0x60058B8")]
    [Address(RVA = "0x3C2D0B0", Offset = "0x3C2D0B0", VA = "0x3C2D0B0")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60058B9")]
    [Address(RVA = "0x3C2D170", Offset = "0x3C2D170", VA = "0x3C2D170")]
    private void OnLoadEntity(NetworkErrorData entity)
    {
    }

    [Token(Token = "0x60058BA")]
    [Address(RVA = "0x3C2D2B8", Offset = "0x3C2D2B8", VA = "0x3C2D2B8")]
    public bool GetErrorData(string errorCode, out List<NetworkErrorData> list) => new bool();

    [Token(Token = "0x60058BB")]
    [Address(RVA = "0x3C2D370", Offset = "0x3C2D370", VA = "0x3C2D370")]
    public NetworkErrorData GetErrorData(
      string errorCode,
      string apiPath,
      long httpStatus,
      int? extraStatusCode)
    {
      return (NetworkErrorData) null;
    }

    [Token(Token = "0x60058BC")]
    [Address(RVA = "0x3C2D5A0", Offset = "0x3C2D5A0", VA = "0x3C2D5A0")]
    public NetworkErrorMaster()
    {
    }
  }
}
