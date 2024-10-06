-- このluaスクリプトは、EA_010_036.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetPlayerTemplate("Actor001",20,CharaPos110071_02_005,CameraAssetBundleName110071_02,CameraPos110071_02_005)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110071_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_008)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
    heroIdshort = 101003
    Yof=1.6
elseif heroId == 101005001 then
    heroIdshort = 101005
    Yof=1.6
elseif heroId == 101007001 then
    heroIdshort = 101007
    Yof=1.6
elseif heroId == 101004001 then
    heroIdshort = 101004
    Yof=1.45
elseif heroId == 101006001 then
    heroIdshort = 101006
    Yof=1.45
else
    heroIdshort = 101008
    Yof=1.45
end
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10201007)
set_pos(prop001 ,{-0.48,0.13,42.8})
set_rot(prop001,{0, 230, 0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,{0.65, 0.13, 12.37})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110072)
	Actor001 = InitializePlayerCharacter("Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	Actor003 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101035","002","101035002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ロンギヌス2★★:待ってください！！
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0360005")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
IN_RUN(Actor003,CharaPos110071_02_008)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ロンギヌス★★:に、逃げてくださいっ<br>ここは私が…！
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_010_0360009")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0017")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ロンギヌス★★:あれは『イミテーション』<br>今のあなたに勝てる相手ではありません…っ！
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360011")

	goto Block1end

::Block1end::
	change_face(Actor003,"Anger")

	--★★ロンギヌス★★:<ruby=ノワール>過去の継承者</ruby>が選択しなかった世界線<br>選ばれなかった歴史の因子…
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360012")


	--★★ロンギヌス★★:その可能性が穢れ、形を成し<br>バルバロイの傀儡となり果てた存在です…！
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ロンギヌス★★:過去、『白き竜』として形を成したソレは<br>一度封じられましたが──
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360015")


	--★★ロンギヌス★★:封が衰えた今<br>解き放たれるのも時間の問題でした…！
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360016")

-- ▼直接出力
local move = {-3.764, 0.13, 19.108}
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ロンギヌス★★:レーヴァテインは<br>傷を一手に引き受け──
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360018")


	--★★ロンギヌス★★:あなたの記憶が癒える時間を<br>作るつもりでした
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360019")


	--★★ロンギヌス★★:いつ、あなたの前から消えてもいいよう<br>あなたを拒んで………
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360020")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to  Std_Surp")
change_face(Actor001,"Surprise")
wait_time(1.8)
setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★テロップ★★:「喰らわれたひとはいなくなって<br>そのひとのことは思い出せなくなってく」
	Talk(Actor002,"telop","simple","N","EA_010_0360022")


	--★★テロップ★★:「思い出が消えたことだけを知る」<br>「そうしたら」
	Talk(Actor002,"telop","simple","N","EA_010_0360023")


	--★★テロップ★★:「笑えなくなった」
	Talk(Actor002,"telop","simple","N","EA_010_0360024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ロンギヌス★★:そもそも我々は<br>イミテーションの出現に備えてあなたを──…
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360025")


	--★★ロンギヌス★★:ですがあなたはまだ<br>なにも思い出せていない、だから…！
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360026")


	--★★テロップ★★:
	Talk(Actor002,"telop","simple","N","EA_010_0360027")

	open_select_window_tag(Actor001,"Normal","EA_010_0360029")
	if is_select(1) then
		goto BlockEA_010_036_2_1
	end

::BlockEA_010_036_2_1::
	CloseTalkWindow()
	goto BlockEA_010_036_2end

::BlockEA_010_036_2end::
-- ▼直接出力
local gopos = {-2.232, 0.13, 23.035}
--到着までの時間を計算------------------
local disx = gopos[1] - CharaPos110071_02_005[1]
local disz = gopos[3] - CharaPos110071_02_005[3]
disx = math.abs(disx)
disz = math.abs(disz)
local dis = disx^2 + disz^2
local distance = math.sqrt(dis)
local SPEED = 4
local MOVETIME = distance / SPEED
----------------------------------------
local TURN_TIME = 0.2
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001, gopos, TURN_TIME)
wait_time(TURN_TIME)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001, gopos, MOVETIME) --2.8秒ぐらい
wait_time(1.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor003,1.0)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003, gopos, TURN_TIME)
wait_time(TURN_TIME)
setup_small_camera_end(RndCamera007)
setup_small_camera_start(Camera002)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
PlayPartVoiceDirect("リリアーナ","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ロンギヌス★★:
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0360032")


	--★★テロップ★★:
	Talk(Actor002,"telop","simple","N","EA_010_0360033")

-- ▼直接出力
set_pos(Actor001,{0.188,0.13,22.022})
turn_chara(Actor001,110,0)
-- ▲直接出力

	--★★テロップ★★:「戦う意味とか、どこにもないよ」
	Talk(Actor002,"telop","simple","N","EA_010_0360034")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_010_0360036")
	if is_select(1) then
		goto Block3_1
	end

::Block3_1::
	CloseTalkWindow()
	goto Block3end

::Block3end::
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
    heroIdshort = 101003
    Yof=1.6
elseif heroId == 101005001 then
    heroIdshort = 101005
    Yof=1.6
elseif heroId == 101007001 then
    heroIdshort = 101007
    Yof=1.6
elseif heroId == 101004001 then
    heroIdshort = 101004
    Yof=1.45
elseif heroId == 101006001 then
    heroIdshort = 101006
    Yof=1.45
else
    heroIdshort = 101008
    Yof=1.45
end
setup_prop_object_preload(10201007)
	InitializeLoad_Preload()
	load_area_scene_preload(110072)
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101035","002","101035002")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
