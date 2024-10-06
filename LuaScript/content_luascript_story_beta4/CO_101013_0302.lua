-- このluaスクリプトは、CO_101013_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_03","110071_03_h")
Include("content_adv_advsmall_110071_03","Template110071_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos110071_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_004)
	Camera002 = SetTemplate("Actor002",65,CharaPos110071_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_002)
	InitializeTemplateRandomCamera110071_03()
	InitializeTemplate110071_03()
-- ▼直接出力
lookat_delay_weight(Actor002,0.4, 0.5, 0.8, 0.5,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:まずは近場から…って思ったけど実はキンイロチョウって聞いたことないんだよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★子供（男）★★:それは通称で、正式名称はログレスサンシャインバタフライっていうんだよ
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03020003")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:名前長っ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020004")

-- ▼直接出力
setup_small_camera_start()
lookat_delay_weight_reset(Actor002,0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なんか心躍る名前だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020005")

	change_face(Actor004,"Normal")

	--★★子供（男）★★:名前のとおり派手な金色だから見たらすぐわかると思う
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:派手な金色かますます興味が湧くな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:やっぱりそーゆーとこに食いつくんだな、お前
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020008")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんまり聞いたことない特徴だから気になっただけだよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺は別に金色のものとか派手なものが全部好きってわけじゃないからな！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:へいへいそーゆーことにしといてやるよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020011")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ま、とりあえずこのあたりを探そうぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020012")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
lookat_weight(Actor001,0.5, 0.5, 0.7, 0.5)
keep_ik_lookat(Actor001,Actor003, "J_Head")
keep_ik_lookat(Actor002,Actor003, "J_Head")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:調子悪いのか、ラグネル？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:調子が悪いわけじゃないんだけどあたし、虫がちょっと、ね…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_03020016")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020017")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:実は俺もそんなにというか、全然というか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03020018")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:…ったく、しょうがねぇなぁ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020019")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:よーし、太陽が出てるんだラグネルのぶんまで俺が働くぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020021")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:もう少し先まで行ってみっか！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ3_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
