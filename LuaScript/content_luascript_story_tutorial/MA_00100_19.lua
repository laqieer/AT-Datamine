-- このluaスクリプトは、MA_00100_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_01","100021_01_h")
Include("content_adv_advsmall_100021_01","Template100021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100021_01_001,CameraAssetBundleName100021_01,CameraPos100021_01_001)
	InitializeTemplateRandomCamera100021_01()
	InitializeTemplate100021_01()
-- ▼直接出力
 --ボタン制御
ShowGlobalMenuButton(false)
-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor002,{0, 0, -21.5,   0},true)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
turn_lookat_position(Actor002,CharaPos100021_01_001[1],CharaPos100021_01_001[2],CharaPos100021_01_001[3],0)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,CharaPos100021_01_001[1],CharaPos100021_01_001[2],CharaPos100021_01_001[3],4.5)
wait_time(3.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
wait_time(0.65)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(3.0)
setup_small_camera_start(RndCamera002)
wait_time(0.6)
-- ▲直接出力

	--★★アルハン★★:<dot>まだひとり</dot>だな？
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★アルハン★★:ようこそ。<Player Name><br>六千年学園へ
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190004")

	open_select_window_tag(Actor002,"Normal","MA_00100_190005","MA_00100_190006","MA_00100_190007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
change_face(Actor002,"Surprise")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン★★:しゃべるであろう、猫だって
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190009")

	change_face(Actor001,"Normal")

	--★★アルハン★★:逆に「わあ人ってしゃべるんだあ～」<br>と言われたら不快だと思わないか
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★アルハン★★:ワタシは不快だね、少なくともワタシは
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
change_face(Actor002, "Normal")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:ここに至るまでに見ただろう？
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★アルハン★★:キサマもいずれ<br><dot>つがい</dot>を見つける
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★アルハン★★:いや、急かしているわけではない<br>むしろ熟考してもらわねばならんよ
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
change_face(Actor002, "Sad")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アルハン★★:外界のことには関心がないか？<br>気が合いそうだ
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190021")

	change_face(Actor001,"Normal")

	--★★アルハン★★:人の記憶を喰らう魔物と<br>それを退治する者
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190023")

	change_face(Actor001,"Normal")

	--★★アルハン★★:わかりやすく言えばそのようなものだ<br>なあに、いずれわかる
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:六千年前から<ruby=し>識</ruby>っている
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190027")


	--★★アルハン★★:いつかこの日が来るのだと
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00100_190029")

-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(0.0, 0.0, 0.0, 1.0, 1.0)
wait_time(1.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Invasion2")
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
