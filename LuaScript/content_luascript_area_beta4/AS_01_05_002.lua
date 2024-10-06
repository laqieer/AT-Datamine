-- このluaスクリプトは、AS_common.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:今日も街は五月祭で賑わってるみたいだな<br>こんなに人が集まるなんて思わなかった
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_0020003")


	--★★ノワール★★:それにしても、なんとなく学園の生徒たちが<br>ソワソワしているように見えるのは…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_0020004")


	--★★ノワール★★:<dot>あれ</dot>のせいだろうな、たぶん
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_0020005")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end
