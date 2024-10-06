// Decompiled with JetBrains decompiler
// Type: GameCore.Effect.EffectHandlingProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Effect
{
  [Token(Token = "0x200146B")]
  public class EffectHandlingProvider : Singleton<EffectHandlingProvider>
  {
    [Token(Token = "0x4005E07")]
    [FieldOffset(Offset = "0x18")]
    private EffectHandlingProvider.HandleCacheTable handleCacheTable;

    [Token(Token = "0x170011A2")]
    public EffectAssetInfo EffectAssetInfo
    {
      [Token(Token = "0x6007312"), Address(RVA = "0x4054EAC", Offset = "0x4054EAC", VA = "0x4054EAC")] get
      {
        return (EffectAssetInfo) null;
      }
    }

    [Token(Token = "0x6007313")]
    [Address(RVA = "0x4054EB4", Offset = "0x4054EB4", VA = "0x4054EB4")]
    public void Initilalize()
    {
    }

    [Token(Token = "0x6007314")]
    [Address(RVA = "0x4054ECC", Offset = "0x4054ECC", VA = "0x4054ECC")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6007315")]
    [Address(RVA = "0x4054F54", Offset = "0x4054F54", VA = "0x4054F54")]
    public EffectHandlingProvider.Handler BeginHandling(EffectInfo effectInfo)
    {
      return (EffectHandlingProvider.Handler) null;
    }

    [Token(Token = "0x6007316")]
    [Address(RVA = "0x40553FC", Offset = "0x40553FC", VA = "0x40553FC")]
    public void EndHandling(EffectHandlingProvider.Handler handler)
    {
    }

    [Token(Token = "0x6007317")]
    [Address(RVA = "0x4055404", Offset = "0x4055404", VA = "0x4055404")]
    public void Clean(string label)
    {
    }

    [Token(Token = "0x6007318")]
    [Address(RVA = "0x4055578", Offset = "0x4055578", VA = "0x4055578")]
    public void CleanAll()
    {
    }

    [Token(Token = "0x6007319")]
    [Address(RVA = "0x4055358", Offset = "0x4055358", VA = "0x4055358")]
    private void BusyStatusUpdate(
      EffectHandlingProvider.IBusyStatusAccessor busyStatusAccessor,
      bool busy)
    {
    }

    [Token(Token = "0x600731A")]
    [Address(RVA = "0x40550E8", Offset = "0x40550E8", VA = "0x40550E8")]
    private EffectHandlingProvider.Handler TryGetHandler(
      string label,
      ref EffectHandlingProvider.HandlerList handlers)
    {
      return (EffectHandlingProvider.Handler) null;
    }

    [Token(Token = "0x600731B")]
    [Address(RVA = "0x4055804", Offset = "0x4055804", VA = "0x4055804")]
    public EffectHandlingProvider()
    {
    }

    [Token(Token = "0x200146C")]
    private class HandlerList : List<EffectHandlingProvider.Handler>
    {
      [Token(Token = "0x600731C")]
      [Address(RVA = "0x4055234", Offset = "0x4055234", VA = "0x4055234")]
      public HandlerList()
      {
      }
    }

    [Token(Token = "0x200146D")]
    private class HandleCacheTable : Dictionary<string, EffectHandlingProvider.HandlerList>
    {
      [Token(Token = "0x600731D")]
      [Address(RVA = "0x40558AC", Offset = "0x40558AC", VA = "0x40558AC")]
      public HandleCacheTable()
      {
      }
    }

    [Token(Token = "0x200146E")]
    private interface IBusyStatusAccessor
    {
      [Token(Token = "0x600731E")]
      void Update(bool value);
    }

    [Token(Token = "0x200146F")]
    public class Handler : EffectHandlingProvider.IBusyStatusAccessor
    {
      [Token(Token = "0x4005E09")]
      [FieldOffset(Offset = "0x18")]
      private GameObject entity;
      [Token(Token = "0x4005E0A")]
      [FieldOffset(Offset = "0x20")]
      private EffectInfo effectInfo;

      [Token(Token = "0x170011A3")]
      public bool IsBusy
      {
        [Token(Token = "0x600731F"), Address(RVA = "0x40558F4", Offset = "0x40558F4", VA = "0x40558F4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6007320"), Address(RVA = "0x40558FC", Offset = "0x40558FC", VA = "0x40558FC")] private set
        {
        }
      }

      [Token(Token = "0x170011A4")]
      public Transform Entity
      {
        [Token(Token = "0x6007321"), Address(RVA = "0x4055908", Offset = "0x4055908", VA = "0x4055908")] get
        {
          return (Transform) null;
        }
      }

      [Token(Token = "0x6007322")]
      [Address(RVA = "0x40552A0", Offset = "0x40552A0", VA = "0x40552A0")]
      public Handler(EffectInfo effectInfo)
      {
      }

      [Token(Token = "0x6007323")]
      [Address(RVA = "0x4055A38", Offset = "0x4055A38", VA = "0x4055A38")]
      public void Show()
      {
      }

      [Token(Token = "0x6007324")]
      [Address(RVA = "0x4055AC8", Offset = "0x4055AC8", VA = "0x4055AC8")]
      public void Hide()
      {
      }

      [Token(Token = "0x6007325")]
      [Address(RVA = "0x4055ACC", Offset = "0x4055ACC", VA = "0x4055ACC")]
      public void EntityDestory()
      {
      }

      [Token(Token = "0x6007326")]
      [Address(RVA = "0x4055A08", Offset = "0x4055A08", VA = "0x4055A08")]
      private void SetActive(bool active)
      {
      }

      [Token(Token = "0x6007327")]
      [Address(RVA = "0x4055924", Offset = "0x4055924", VA = "0x4055924")]
      private GameObject LoadAsset(string assetBundleName, string assetName) => (GameObject) null;

      [Token(Token = "0x6007328")]
      [Address(RVA = "0x4055B6C", Offset = "0x4055B6C", VA = "0x4055B6C", Slot = "4")]
      private void GameCore\u002EEffect\u002EEffectHandlingProvider\u002EIBusyStatusAccessor\u002EUpdate(
        bool value)
      {
      }
    }
  }
}
