// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListConnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002404")]
  public class FieldUnitListConnect
  {
    [Token(Token = "0x40099F2")]
    [FieldOffset(Offset = "0x10")]
    private CameraDirector _camera;
    [Token(Token = "0x40099F3")]
    [FieldOffset(Offset = "0x18")]
    private MapDirectorBase _map;
    [Token(Token = "0x40099F4")]
    [FieldOffset(Offset = "0x20")]
    private UIManager _ui;
    [Token(Token = "0x40099F5")]
    [FieldOffset(Offset = "0x28")]
    private UnitParameterData _currentUnitParameterData;
    [Token(Token = "0x40099F6")]
    [FieldOffset(Offset = "0x30")]
    public int tempUnitId;

    [Token(Token = "0x17002F6A")]
    public CameraDirector Camera
    {
      [Token(Token = "0x600DCAD"), Address(RVA = "0x1E21834", Offset = "0x1E21834", VA = "0x1E21834")] get
      {
        return (CameraDirector) null;
      }
      [Token(Token = "0x600DCAE"), Address(RVA = "0x1E2183C", Offset = "0x1E2183C", VA = "0x1E2183C")] set
      {
      }
    }

    [Token(Token = "0x17002F6B")]
    public MapDirectorBase Map
    {
      [Token(Token = "0x600DCAF"), Address(RVA = "0x1E21844", Offset = "0x1E21844", VA = "0x1E21844")] get
      {
        return (MapDirectorBase) null;
      }
      [Token(Token = "0x600DCB0"), Address(RVA = "0x1E2184C", Offset = "0x1E2184C", VA = "0x1E2184C")] set
      {
      }
    }

    [Token(Token = "0x17002F6C")]
    public UIManager UI
    {
      [Token(Token = "0x600DCB1"), Address(RVA = "0x1E21854", Offset = "0x1E21854", VA = "0x1E21854")] get
      {
        return (UIManager) null;
      }
      [Token(Token = "0x600DCB2"), Address(RVA = "0x1E2185C", Offset = "0x1E2185C", VA = "0x1E2185C")] set
      {
      }
    }

    [Token(Token = "0x17002F6D")]
    public UnitParameterData CurrentUnitParameterData
    {
      [Token(Token = "0x600DCB3"), Address(RVA = "0x1E21864", Offset = "0x1E21864", VA = "0x1E21864")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600DCB4"), Address(RVA = "0x1E2186C", Offset = "0x1E2186C", VA = "0x1E2186C")] set
      {
      }
    }

    [Token(Token = "0x600DCB5")]
    [Address(RVA = "0x1E21874", Offset = "0x1E21874", VA = "0x1E21874")]
    public FieldUnitListConnect()
    {
    }
  }
}
