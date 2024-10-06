-- このluaスクリプトは、PT3_01_05_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力

	--★★ラグネル★★:おはよ、ノワール
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:やあ、ラグネル
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_05_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ラグネル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:あたしさ、燃えてるんだよね！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:燃えてる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_05_0030006")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:ガウェインとも話したんだけど<br>女の子を泣かせる悪い奴は許せないよね！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:女の子を泣かせる悪い奴…<br>ひょっとして、魔女のことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_05_0030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:そう！<br>そうだよ！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:殿下のお父さんやキャメリアードの人たちに<br>酷いことをたくさんして…許せない！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030010")


	--★★ラグネル★★:このあいだは到着に手間取っちゃって<br>戦いに参加できなかったけど
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030011")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ラグネル★★:次はぜったい！<br>あたしが魔女をギャフンと言わせるんだから！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギャフン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_05_0030013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力

	--★★ラグネル★★:魔女と戦うってなったときは<br>あたしに声かけてね！約束だよ！？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01_05_0030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ああ<br>頼りにさせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_05_0030015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
