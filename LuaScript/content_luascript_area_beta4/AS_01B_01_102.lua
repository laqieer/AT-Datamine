-- このluaスクリプトは、AS_01B_01_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★マーリン★★:ノワール様…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","AS_01B_01_1020001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は信じられないし、受け入れたくない<br>アーサーがバルバロイになってしまうだなんて
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1020002")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:私も同じ気持ちでした<br>ですが、一番そう思っていたのはあの方本人かも
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","AS_01B_01_1020003")


	--★★ノワール★★:確かにそうかもしれませんね<br>でも、そんな顔を見せないから、アーサーは
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1020004")


	--★★マーリン★★:そんな顔を見せることができた相手とアーサー様<br>これからどんな結末を迎えるかは、おふたり次第
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","AS_01B_01_1020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかりました<br>俺もできるかぎり協力するつもりです
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
