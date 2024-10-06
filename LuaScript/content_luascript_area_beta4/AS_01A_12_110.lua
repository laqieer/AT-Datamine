-- このluaスクリプトは、AS_01A_12_110.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:やあやあノワール<br>今日も寒いね～やあやあ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1100001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ああ<br>今日も寒いな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1100002")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:最近は、っていうか今年はさ<br>いろんなことが立て続けに起こりすぎだよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1100003")


	--★★ギネヴィア★★:毎日毎日めまぐるしくてさ<br>こんな調子じゃ１年なんてあっという間だよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1100004")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:休みをもらえないか<br>アーサーやケイに頼んでみようかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1100005")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:いいわね！じゃ、そんときにゆっくりできるよう<br>ノワールの用事を全部片づけといてよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1100006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
