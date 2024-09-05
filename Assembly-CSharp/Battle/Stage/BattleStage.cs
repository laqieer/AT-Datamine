// Decompiled with JetBrains decompiler
// Type: Battle.Stage.BattleStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using Battle.ViewCamera;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Stage
{
  [Token(Token = "0x200246D")]
  public sealed class BattleStage : MonoBehaviour
  {
    [Token(Token = "0x4009C3C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MapViewCamera mapViewCamera;
    [Token(Token = "0x4009C3D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WorldSpaceCanvasManager worldSpaceCanvasManager;
    [Token(Token = "0x4009C3E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform mapRoot;
    [Token(Token = "0x4009C3F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform gridRoot;
    [Token(Token = "0x4009C40")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform unitRoot;

    [Token(Token = "0x17002FE0")]
    public MapViewCamera MapViewCamera
    {
      [Token(Token = "0x600DF53"), Address(RVA = "0x201A118", Offset = "0x201A118", VA = "0x201A118")] get
      {
        return (MapViewCamera) null;
      }
    }

    [Token(Token = "0x17002FE1")]
    public WorldSpaceCanvasManager WorldSpaceCanvasManager
    {
      [Token(Token = "0x600DF54"), Address(RVA = "0x201A120", Offset = "0x201A120", VA = "0x201A120")] get
      {
        return (WorldSpaceCanvasManager) null;
      }
    }

    [Token(Token = "0x17002FE2")]
    public Transform MapRoot
    {
      [Token(Token = "0x600DF55"), Address(RVA = "0x201A128", Offset = "0x201A128", VA = "0x201A128")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002FE3")]
    public Transform GridRoot
    {
      [Token(Token = "0x600DF56"), Address(RVA = "0x201A130", Offset = "0x201A130", VA = "0x201A130")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002FE4")]
    public Transform UnitRoot
    {
      [Token(Token = "0x600DF57"), Address(RVA = "0x201A138", Offset = "0x201A138", VA = "0x201A138")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600DF58")]
    [Address(RVA = "0x201A140", Offset = "0x201A140", VA = "0x201A140")]
    public BattleStage()
    {
    }
  }
}
