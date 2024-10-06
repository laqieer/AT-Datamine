-- このluaスクリプトは、EA_066_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_01","112041_01_h")
Include("content_adv_advsmall_112041_01","Template112041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_002)
	Camera003 = SetTemplate("Actor005",nil,CharaPos112041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_003)
	InitializeTemplateRandomCamera112041_01()
	InitializeTemplate112041_01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0002")
-- ▲直接出力

	--★★男性A★★:伝説級の武器？知らないなあ…あ、けど伝説といえば――
	Talk(Actor003,"NPCNAME_0178","speech","L","EA_066_0210003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★男性A★★:この近くの湖に妖精が現れたんだってよ
	Talk(Actor003,"NPCNAME_0178","speech","L","EA_066_0210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★男性A★★:一目見ただけでそうと分かる<br>それはそれは美しく可憐なお姿だったそうだ
	Talk(Actor003,"NPCNAME_0178","speech","L","EA_066_0210005")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("市民_女1","0010")
-- ▲直接出力

	--★★女性A★★:ここだけの話なんだけどね<br>となり街に『継承者』がいるらしいのよ
	Talk(Actor004,"NPCNAME_0183","speech","L","EA_066_0210006")

	PlayAction(Actor004,"to  Std_Talk")

	--★★女性A★★:でも継承者って<br>いったいなにをする人なんだろうね？
	Talk(Actor004,"NPCNAME_0183","speech","L","EA_066_0210007")

	PlayAction(Actor005,"to  Std_Talk")

	--★★男性B★★:聞いて驚くなよ。なんでも…<br>『聖杯』が見つかったらしいんだ！
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow() --疑似バトルならclose_speech_window(
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0046")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0210011")

	PlayAction(Actor005,"to Sit01_BA01")
-- ▼直接出力
PlayPartVoiceDirect("市民_男2","0034")
-- ▲直接出力

	--★★男性B★★:
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0037")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:いや、すまない<br>あまりにも荒唐無稽な話すぎて
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0210013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0037")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0210014")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Pain")

	--★★男性B★★:
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210015")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0002")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0210016")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★男性B★★:
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210017")

	PlayAction(Actor005,"to Sit02_BA01")
	change_face(Actor005,"Smile")

	--★★男性B★★:その冒険者は『山をも打ち砕く力』を求めて<br>その遺跡に潜ったそうだ
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★男性B★★:すると遺跡の奥には魔物がウジャウジャ絶体絶命！助けてくれ、と願ったそのとき
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210019")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Surprise")

	--★★男性B★★:遺跡の奥から突如眩い光が溢れ出して<br>魔物たちが瞬時に消えたそうだ
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210020")

	PlayAction(Actor005,"to Sit01_BA01")
	change_face(Actor005,"Smile")

	--★★男性B★★:光を放つそれは杯のような形をしていて――まさに聖杯と呼ぶべき代物だったと
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0210022")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★男性B★★:
	Talk(Actor005,"NPCNAME_0179","speech","L","EA_066_0210023")

-- ▼直接出力
lookat_delay_weight_default(Actor002, 1)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ええ。とても興味を引かれるわ<br>ぜひ調べてみたい。そう思わない？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0210024")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0210025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
