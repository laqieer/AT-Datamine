-- このluaスクリプトは、AS_01_07_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★トリスタン★★:いきなりなに？<br>ボクは忙しいんだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AS_01_07_1040002")


	--★★ノワール★★:ブライアンの行き先をつかんでいないか？<br>わずかな情報でもいいんだ、教えてくれ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1040003")


	--★★トリスタン★★:知らないね<br>たとえ知っていてもキミに話すと思う？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AS_01_07_1040004")


	--★★ノワール★★:話さないと思う<br>だが、話してくれるまで俺はここを動かない
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1040005")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:やれやれ。知らないってのは本当だよ<br>ボクのほうがキミに情報を聞きたかったくらいさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","AS_01_07_1040006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ブライアンが足跡を残すような真似はしないか…<br>話を聞かせてくれてありがとう、トリスタン
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1040007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
