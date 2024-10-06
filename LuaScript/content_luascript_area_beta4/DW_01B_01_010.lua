-- このluaスクリプトは、DW_01B_01_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("フィエナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_01_0100001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0100002")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_01_0100003")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0100004")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_01_0100005")

	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_01_0100006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0100007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end
