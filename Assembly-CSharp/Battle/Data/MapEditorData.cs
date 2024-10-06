// Decompiled with JetBrains decompiler
// Type: Battle.Data.MapEditorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using YamlDotNet.Serialization;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002703")]
  public sealed class MapEditorData
  {
    [Token(Token = "0x1700334B")]
    [YamlMember(Alias = "width")]
    public int MapWidth
    {
      [Token(Token = "0x600F1B8"), Address(RVA = "0x41AF5FC", Offset = "0x41AF5FC", VA = "0x41AF5FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1B9"), Address(RVA = "0x41AF604", Offset = "0x41AF604", VA = "0x41AF604")] set
      {
      }
    }

    [Token(Token = "0x1700334C")]
    [YamlMember(Alias = "height")]
    public int MapHeight
    {
      [Token(Token = "0x600F1BA"), Address(RVA = "0x41AF60C", Offset = "0x41AF60C", VA = "0x41AF60C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1BB"), Address(RVA = "0x41AF614", Offset = "0x41AF614", VA = "0x41AF614")] set
      {
      }
    }

    [Token(Token = "0x1700334D")]
    [YamlMember(Alias = "movable_width")]
    public int MovableWidth
    {
      [Token(Token = "0x600F1BC"), Address(RVA = "0x41AF61C", Offset = "0x41AF61C", VA = "0x41AF61C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1BD"), Address(RVA = "0x41AF624", Offset = "0x41AF624", VA = "0x41AF624")] set
      {
      }
    }

    [Token(Token = "0x1700334E")]
    [YamlMember(Alias = "movable_height")]
    public int MovableHeight
    {
      [Token(Token = "0x600F1BE"), Address(RVA = "0x41AF62C", Offset = "0x41AF62C", VA = "0x41AF62C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1BF"), Address(RVA = "0x41AF634", Offset = "0x41AF634", VA = "0x41AF634")] set
      {
      }
    }

    [Token(Token = "0x1700334F")]
    [YamlMember(Alias = "objects")]
    public List<MapObject> Objects
    {
      [Token(Token = "0x600F1C0"), Address(RVA = "0x41AF63C", Offset = "0x41AF63C", VA = "0x41AF63C")] get
      {
        return (List<MapObject>) null;
      }
      [Token(Token = "0x600F1C1"), Address(RVA = "0x41AF644", Offset = "0x41AF644", VA = "0x41AF644")] set
      {
      }
    }

    [Token(Token = "0x17003350")]
    [YamlMember(Alias = "ground")]
    public List<Ground> Grounds
    {
      [Token(Token = "0x600F1C2"), Address(RVA = "0x41AF64C", Offset = "0x41AF64C", VA = "0x41AF64C")] get
      {
        return (List<Ground>) null;
      }
      [Token(Token = "0x600F1C3"), Address(RVA = "0x41AF654", Offset = "0x41AF654", VA = "0x41AF654")] set
      {
      }
    }

    [Token(Token = "0x17003351")]
    [YamlMember(Alias = "attributes")]
    public List<int> LandformAttributes
    {
      [Token(Token = "0x600F1C4"), Address(RVA = "0x41AF65C", Offset = "0x41AF65C", VA = "0x41AF65C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F1C5"), Address(RVA = "0x41AF664", Offset = "0x41AF664", VA = "0x41AF664")] set
      {
      }
    }

    [Token(Token = "0x17003352")]
    [YamlMember(Alias = "duel_scenes")]
    public List<string> PrimaryDuelSceneNames
    {
      [Token(Token = "0x600F1C6"), Address(RVA = "0x41AF66C", Offset = "0x41AF66C", VA = "0x41AF66C")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x600F1C7"), Address(RVA = "0x41AF674", Offset = "0x41AF674", VA = "0x41AF674")] set
      {
      }
    }

    [Token(Token = "0x17003353")]
    [YamlMember(Alias = "heights")]
    public List<List<float>> Heights
    {
      [Token(Token = "0x600F1C8"), Address(RVA = "0x41AF67C", Offset = "0x41AF67C", VA = "0x41AF67C")] get
      {
        return (List<List<float>>) null;
      }
      [Token(Token = "0x600F1C9"), Address(RVA = "0x41AF684", Offset = "0x41AF684", VA = "0x41AF684")] set
      {
      }
    }

    [Token(Token = "0x600F1CA")]
    [Address(RVA = "0x41AF68C", Offset = "0x41AF68C", VA = "0x41AF68C")]
    public int GetLandform(int x, int y) => new int();

    [Token(Token = "0x600F1CB")]
    [Address(RVA = "0x41AF738", Offset = "0x41AF738", VA = "0x41AF738")]
    public IReadOnlyList<float> GetHeights(int x, int y) => (IReadOnlyList<float>) null;

    [Token(Token = "0x600F1CC")]
    [Address(RVA = "0x41AF7F0", Offset = "0x41AF7F0", VA = "0x41AF7F0")]
    public float[] HeightsToSingleArray() => (float[]) null;

    [Token(Token = "0x600F1CD")]
    [Address(RVA = "0x41AF944", Offset = "0x41AF944", VA = "0x41AF944")]
    public float GetSquareCenterHeightAt(int x, int y) => new float();

    [Token(Token = "0x600F1CE")]
    [Address(RVA = "0x41AF9EC", Offset = "0x41AF9EC", VA = "0x41AF9EC")]
    public float GetSquareMaxHeightAt(int x, int y) => new float();

    [Token(Token = "0x600F1CF")]
    [Address(RVA = "0x41AFA94", Offset = "0x41AFA94", VA = "0x41AFA94")]
    public string GetPrimaryDuelSceneName(int x, int y) => (string) null;

    [Token(Token = "0x600F1D0")]
    [Address(RVA = "0x41AF724", Offset = "0x41AF724", VA = "0x41AF724")]
    private int GetEditorMapIndex(int x, int y) => new int();

    [Token(Token = "0x600F1D1")]
    [Address(RVA = "0x41AFB50", Offset = "0x41AFB50", VA = "0x41AFB50")]
    public void CalcAdjustMapSize(
      BattleData masterData,
      out Vector2Int size,
      out Vector2Int offset)
    {
    }

    [Token(Token = "0x600F1D2")]
    [Address(RVA = "0x41AFBC4", Offset = "0x41AFBC4", VA = "0x41AFBC4")]
    public void CalcAdjustMapSize(
      Vector2Int mapSize,
      Vector2Int mapOffset,
      out Vector2Int size,
      out Vector2Int offset)
    {
    }

    [Token(Token = "0x600F1D3")]
    [Address(RVA = "0x41AFC1C", Offset = "0x41AFC1C", VA = "0x41AFC1C")]
    public MapEditorData()
    {
    }
  }
}
