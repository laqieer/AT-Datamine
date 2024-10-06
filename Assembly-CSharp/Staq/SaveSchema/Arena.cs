// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Arena
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C65")]
  public struct Arena : IFlatbufferObject
  {
    [Token(Token = "0x4010BC4")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D58")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BFB"), Address(RVA = "0x37B64D4", Offset = "0x37B64D4", VA = "0x37B64D4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BFC")]
    [Address(RVA = "0x37B64DC", Offset = "0x37B64DC", VA = "0x37B64DC")]
    public static Arena GetRootAsArena(ByteBuffer _bb) => new Arena();

    [Token(Token = "0x6017BFD")]
    [Address(RVA = "0x37B64E8", Offset = "0x37B64E8", VA = "0x37B64E8")]
    public static Arena GetRootAsArena(ByteBuffer _bb, Arena obj) => new Arena();

    [Token(Token = "0x6017BFE")]
    [Address(RVA = "0x37B6544", Offset = "0x37B6544", VA = "0x37B6544")]
    public static bool ArenaBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017BFF")]
    [Address(RVA = "0x37B6590", Offset = "0x37B6590", VA = "0x37B6590", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C00")]
    [Address(RVA = "0x37B652C", Offset = "0x37B652C", VA = "0x37B652C")]
    public Arena __assign(int _i, ByteBuffer _bb) => new Arena();

    [Token(Token = "0x17004D59")]
    public bool ShowFullDuelAnimation
    {
      [Token(Token = "0x6017C01"), Address(RVA = "0x37B659C", Offset = "0x37B659C", VA = "0x37B659C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D5A")]
    public bool FastBattleMode
    {
      [Token(Token = "0x6017C02"), Address(RVA = "0x37B65EC", Offset = "0x37B65EC", VA = "0x37B65EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017C03")]
    [Address(RVA = "0x37B6634", Offset = "0x37B6634", VA = "0x37B6634")]
    public BattleCamera? Cameras(int j) => new BattleCamera?();

    [Token(Token = "0x17004D5B")]
    public int CamerasLength
    {
      [Token(Token = "0x6017C04"), Address(RVA = "0x37B670C", Offset = "0x37B670C", VA = "0x37B670C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D5C")]
    public int CameraIndex
    {
      [Token(Token = "0x6017C05"), Address(RVA = "0x37B6740", Offset = "0x37B6740", VA = "0x37B6740")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D5D")]
    public bool GridView
    {
      [Token(Token = "0x6017C06"), Address(RVA = "0x37B6784", Offset = "0x37B6784", VA = "0x37B6784")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D5E")]
    public int NeedResult
    {
      [Token(Token = "0x6017C07"), Address(RVA = "0x37B67CC", Offset = "0x37B67CC", VA = "0x37B67CC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C08")]
    [Address(RVA = "0x37B6814", Offset = "0x37B6814", VA = "0x37B6814")]
    public static Offset<Arena> CreateArena(
      FlatBufferBuilder builder,
      bool show_full_duel_animation = true,
      bool fast_battle_mode = false,
      VectorOffset camerasOffset = default (VectorOffset),
      int cameraIndex = 0,
      bool grid_view = false,
      int need_result = -1)
    {
      return new Offset<Arena>();
    }

    [Token(Token = "0x6017C09")]
    [Address(RVA = "0x37B69CC", Offset = "0x37B69CC", VA = "0x37B69CC")]
    public static void StartArena(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C0A")]
    [Address(RVA = "0x37B695C", Offset = "0x37B695C", VA = "0x37B695C")]
    public static void AddShowFullDuelAnimation(
      FlatBufferBuilder builder,
      bool showFullDuelAnimation)
    {
    }

    [Token(Token = "0x6017C0B")]
    [Address(RVA = "0x37B693C", Offset = "0x37B693C", VA = "0x37B693C")]
    public static void AddFastBattleMode(FlatBufferBuilder builder, bool fastBattleMode)
    {
    }

    [Token(Token = "0x6017C0C")]
    [Address(RVA = "0x37B68FC", Offset = "0x37B68FC", VA = "0x37B68FC")]
    public static void AddCameras(FlatBufferBuilder builder, VectorOffset camerasOffset)
    {
    }

    [Token(Token = "0x6017C0D")]
    [Address(RVA = "0x37B69E4", Offset = "0x37B69E4", VA = "0x37B69E4")]
    public static VectorOffset CreateCamerasVector(
      FlatBufferBuilder builder,
      Offset<BattleCamera>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C0E")]
    [Address(RVA = "0x37B6A8C", Offset = "0x37B6A8C", VA = "0x37B6A8C")]
    public static VectorOffset CreateCamerasVectorBlock(
      FlatBufferBuilder builder,
      Offset<BattleCamera>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C0F")]
    [Address(RVA = "0x37B6B14", Offset = "0x37B6B14", VA = "0x37B6B14")]
    public static void StartCamerasVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C10")]
    [Address(RVA = "0x37B68DC", Offset = "0x37B68DC", VA = "0x37B68DC")]
    public static void AddCameraIndex(FlatBufferBuilder builder, int cameraIndex)
    {
    }

    [Token(Token = "0x6017C11")]
    [Address(RVA = "0x37B691C", Offset = "0x37B691C", VA = "0x37B691C")]
    public static void AddGridView(FlatBufferBuilder builder, bool gridView)
    {
    }

    [Token(Token = "0x6017C12")]
    [Address(RVA = "0x37B68BC", Offset = "0x37B68BC", VA = "0x37B68BC")]
    public static void AddNeedResult(FlatBufferBuilder builder, int needResult)
    {
    }

    [Token(Token = "0x6017C13")]
    [Address(RVA = "0x37B697C", Offset = "0x37B697C", VA = "0x37B697C")]
    public static Offset<Arena> EndArena(FlatBufferBuilder builder) => new Offset<Arena>();

    [Token(Token = "0x6017C14")]
    [Address(RVA = "0x37B6B34", Offset = "0x37B6B34", VA = "0x37B6B34")]
    public static void FinishArenaBuffer(FlatBufferBuilder builder, Offset<Arena> offset)
    {
    }

    [Token(Token = "0x6017C15")]
    [Address(RVA = "0x37B6B90", Offset = "0x37B6B90", VA = "0x37B6B90")]
    public static void FinishSizePrefixedArenaBuffer(
      FlatBufferBuilder builder,
      Offset<Arena> offset)
    {
    }
  }
}
