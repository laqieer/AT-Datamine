// Decompiled with JetBrains decompiler
// Type: Opening.MA_00100_23_SettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Opening
{
  [Token(Token = "0x2000A66")]
  [CreateAssetMenu(menuName = "Opening/MA_00100_23 Settings Asset")]
  public class MA_00100_23_SettingsAsset : ScriptableObject
  {
    [Token(Token = "0x4003048")]
    [FieldOffset(Offset = "0x18")]
    [Header("演出内容(3D)")]
    public DuelCharacterModelSettingsAsset mainCharacterModel;
    [Token(Token = "0x4003049")]
    [FieldOffset(Offset = "0x20")]
    public SexTypeEnum mainCharacterGender;

    [Token(Token = "0x6003B35")]
    [Address(RVA = "0x331C424", Offset = "0x331C424", VA = "0x331C424")]
    public MA_00100_23_SettingsAsset()
    {
    }
  }
}
