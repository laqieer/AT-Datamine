Include("content_luascript_common","ADVSmallPack")

function Load()
  InitializeLoadActive()
  Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end

function Play()
  StartPlayActive()

  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_010001")
  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_010002")
  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_010003")

  CloseTalkWindow()

  EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  InitializeActiveCharacter_Preload("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end
