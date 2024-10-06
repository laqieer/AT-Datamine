-- このluaスクリプトは、MA_01A111_45.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation04_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_012)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
RndCamera001 =　RndCamera002
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101200011)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","002","101018002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101037","002","101037002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴェルナルス★★:あの虐殺が<br>ただの意趣返しだと思っているか？
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450002")

	change_face(Actor001,"Anger")

	--★★ガウェイン★★:あんたを見損なうにはじゅうぶんだったぜ…！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A111_450003")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:ログレスの民がどう思うかなど<br>関係がないのだ
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴェルナルス★★:あれは<br>ローマを焚きつける炎だ
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450005")


	--★★ヴェルナルス★★:ユーサー時代、肉親をバルバロイに喰われ<br>その存在を忘却してしまったローマの民たち
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450006")


	--★★ヴェルナルス★★:彼らは…いたはずの誰かを思い出せず<br>空虚な日々を過ごしている
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450007")


	--★★ヴェルナルス★★:ルーシャス様は彼らがすがるべき拠り所と<br>無念の矛先を…討つべき敵を与えた
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ラグネル★★:家族がバルバロイに喰われて悲しんでるのに<br>バルバロイを使って復讐しようっていうの…！？
	Talk(Actor002,"CHRNAME_RAGNAR2","speech","L","MA_01A111_450011")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ラシア★★:例えば短剣によって殺された親の復讐のために<br>同様の短剣を扱おうが不思議はありませんよね？
	Talk(Actor004,"CHRNAME_RASIA2","speech","L","MA_01A111_450012")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ガウェイン★★:誰ひとり本当かどうかわからない歴史を<br>信じるってのかよ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A111_450013")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴェルナルス★★:本当かどうかなど<br>どうでもよい者たちもいる
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450014")


	--★★ヴェルナルス★★:ただ力を欲する者たち<br>ブリテンの支配権を握りたい者たち
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450015")


	--★★ヴェルナルス★★:ローマの治世をふたたび取り戻したい者たち<br>大陸の帝国の分裂を憂う者たち…
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:彼らに大義名分を与えれば、正義が産まれる<br>一死報国の英雄にならんとする意志が宿る
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A111_450017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 =　RndCamera002
	InitializeLoad_Preload()
	load_duel_scene_preload(101200011)
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","002","101018002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101037","002","101037002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
