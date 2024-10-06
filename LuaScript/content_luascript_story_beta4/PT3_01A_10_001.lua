-- このluaスクリプトは、PT3_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン","挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール<br>おはよーさん
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:おはよう、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:しっかし、ローマもとんでもねーこと考えるよな<br>この島をふたつに分ける壁を作るなんてよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010005")


	--★★ガウェイン★★:ローマの皇太子様は<br>俺たちと発想のスケールが違うぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:発想のスケールだけじゃなく<br>次の戦いはバルバロイの量もけた違いだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ガウェイン★★:ああ<br>それにたぶん、あの人も出てくる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010008")

-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの人？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン","肯定")
-- ▲直接出力

	--★★ガウェイン★★:ヴェルナルス大将軍だよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010010")


	--★★ガウェイン★★:戦闘技術、戦術ともに<br>今のローマで右に出るヤツはいねーそうだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010011")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:ちょっと前の戦いなんざ、ほんの小手調べ<br>本気で来られたら一筋縄じゃいかねーぜ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:でも、負けるつもりなんてないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_10_0010013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…へっ<br>あたりめーだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01A_10_0010014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
