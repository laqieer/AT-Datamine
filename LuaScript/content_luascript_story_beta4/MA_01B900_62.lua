-- このluaスクリプトは、MA_01B900_62.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_03","110051_03_h")
Include("content_adv_advsmall_110051_03","Template110051_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_MA01B900_62_Controller","to Std_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_002)
	Camera003 = SetTemplate("Actor003",235,CharaPos110051_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_003)
	Camera006 = SetTemplate("Actor006",123,CharaPos110051_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_03,CameraPos110051_03_001)
	InitializeTemplateRandomCamera110051_03()
	InitializeTemplate110051_03()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
--load_image("MA01B9006201", "content_still_10102011_image", "101020110_StillImage")
load_image("101010090", "content_still_10101009_image", "101010090_StillImage")
CUT_01 = cat_template_camera("P10_Cam")
CUT_02 = cat_template_camera("P11_Cam")
CUT_03 = cat_template_camera("P12_Cam")
CUT_04 = cat_template_camera("P13_Cam")
CUT_05 = cat_template_camera("P14_Cam")
RndCamera001 =  CUT_01
stillAnime = load_ui_effect("content_still_10102011_anim", "10102011_StillAnim", nil, nil, nil, "Root")
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
set_pos(Actor003, {3.695,0.035,4.060})
set_pos(Actor006, {-3.604,0.035,4.052})
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★ノワール★★:<ruby=うしな>喪</ruby>ったものの数だけ<br>痛いほど刻まれた記憶がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_620002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Fist01_loop")
-- ▲直接出力

	--★★ランスロット★★:その悼みを<br>忘れず武器へと換えることだけが──
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01B900_620004")


	--★★ランスロット★★:武器を握り続けるこの一手だけが<br>幻影めいた停滞を断ち斬る
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01B900_620006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_02)
-- ▲直接出力
-- ▼直接出力
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Fist02_start")
-- ▲直接出力

	--★★ノワール★★:我が手には、2本の<ruby=つるぎ>劔</ruby>
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_620007")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
show_image("101010090", 0.0, 0.0, 0.0,true,true)
-- ▲直接出力
-- ▼直接出力
set_scale_image(1.2,1.2)
-- ▲直接出力
-- ▼直接出力
set_position_image(-200,-120)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Std01_loop")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ノワール★★:<ruby=す>透</ruby>いて<ruby=さんぜん>燦然</ruby>たる湖剣<br>道<ruby=な>成</ruby>す誇りアロンダイト
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B900_620009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
set_scale_image(1.4,1.4)
-- ▲直接出力
-- ▼直接出力
set_position_image(400,70)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ノワール★★:咎と誓いの黄金剣<br>ジョワイユに比肩する者なし
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B900_620011")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_03)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ノワール★★:託された多くの命に報いるために<br>一千年先まで彼らを歴史に刻むべく──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_620012")


	--★★ノワール★★:俺は名を改める
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_620013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★テロップ★★:「来い、ノワール」
	Talk(Actor008,"telop","narration","N","MA_01B900_620015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_04)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:世界平和を叶える聖杯を探し求め<br>その聖杯へ導く妖精を見送った騎士
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_620016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
--ノワール,CHRNAME_LANCELOT @名前変更
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_05)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:俺は円卓の騎士『ランスロット』
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_620018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★テロップ★★:「決闘だ、ランスロット！」
	Talk(Actor008,"telop","narration","N","MA_01B900_620019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★ランスロット★★:その名と闘え
	Talk(Actor007,"CHRNAME_LANCELOT","simple","N","MA_01B900_620021")

-- ▼直接出力
	CloseTalkWindow()
fadeout(255, 255, 255, 255,1.0,STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	stillAnime.SetActive(true)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はランスロットという名前と…<br>最強騎士を名乗るがゆえの責務と闘い続ける
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_620023")


	--★★ノワール★★:きっと追いつける日は来ない<br>それでいい
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_620025")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力

	--★★ランスロット★★:走り続けろ
	Talk(Actor007,"CHRNAME_LANCELOT","simple","N","MA_01B900_620027")

-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(255, 255, 255, 0, 0.5)
wait_time(0.5)
stillAnime.SetActive(false)
show_image("101010150", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
wait_time(2.0)
fadein(1.0)
wait_time(1.0)
-- ▲直接出力

	--★★ノワール★★:ずっと先で<br>待っていてくれ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_620029")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010090", "content_still_10101009_image", "101010090_StillImage")
load_ui_effect_preload("content_still_10102011_anim", "10102011_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	system.PreLoadRequest(CameraAssetBundleName110051_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
