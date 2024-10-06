-- このluaスクリプトは、AS_01_04_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeCharacter_2DOnly("401035","001","401035001")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:えっと<br>学園の学生寮ってのはここか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1020002")


	--★★キャメロット軍兵士_上位★★:そうだが…見たところ制服を着ているし<br>お前も生徒ではないのか？
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01_04_1020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、入学したばかりなんだ<br>…入学させてくれって頼んだわけじゃないけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1020004")


	--★★キャメロット軍兵士_上位★★:うん？事情はよくわからんが<br>入寮を許可されているなら、入っていいぞ
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01_04_1020005")


	--★★ノワール★★:ついでに教えてほしいんだけど、寮の利用時に<br>注意しておいたほうがいいことってあるかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1020006")


	--★★キャメロット軍兵士_上位★★:夜に寮から出ることはあまりよしとされないから<br>やるべきことを済ませて戻るのがいいだろうな
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01_04_1020007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeCharacter_2DOnly_Preload("401035","001","401035001")
end
